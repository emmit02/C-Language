#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <winsock2.h>

#define PORT1 8080
#define PORT2 8081
#define BUFFER_SIZE 1024

void connect_to_server(int port) {
    SOCKET client_socket;
    struct sockaddr_in server_address;
    char buffer[BUFFER_SIZE] = {0};

    if ((client_socket = socket(AF_INET, SOCK_STREAM, 0)) == INVALID_SOCKET) {
        perror("Socket creation failed");
        WSACleanup();
        exit(EXIT_FAILURE);
    }

    server_address.sin_family = AF_INET;
    server_address.sin_port = htons(port);

    // Convert IPv4 address from text to binary
    server_address.sin_addr.s_addr = inet_addr("127.0.0.1");

    if (connect(client_socket, (struct sockaddr *)&server_address, sizeof(server_address)) == SOCKET_ERROR) {
        perror("Connection failed");
        WSACleanup();
        exit(EXIT_FAILURE);
    }

    printf("Connected to server on PORT %d\n", port);

    while (1) {
        printf("Enter message: ");
        fgets(buffer, BUFFER_SIZE, stdin);
        send(client_socket, buffer, strlen(buffer), 0);

        int bytes_read = recv(client_socket, buffer, BUFFER_SIZE, 0);
        if (bytes_read > 0) {
            printf("Server echoed: %s\n", buffer);
        }
        memset(buffer, 0, BUFFER_SIZE);
    }

    closesocket(client_socket);
}

int main() {
    WSADATA wsa_data;

    // Initialize Winsock
    if (WSAStartup(MAKEWORD(2, 2), &wsa_data) != 0) {
        printf("WSAStartup failed\n");
        return 1;
    }

    printf("Connecting to server on PORT1...\n");
    connect_to_server(PORT1);

    printf("Connecting to server on PORT2...\n");
    connect_to_server(PORT2);

    WSACleanup();
    return 0;
}
