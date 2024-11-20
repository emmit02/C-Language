#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <winsock2.h>

#define PORT1 8080
#define PORT2 8081
#define BUFFER_SIZE 1024

void handle_client(SOCKET client_socket) {
    char buffer[BUFFER_SIZE] = {0};
    int bytes_read;
    
    while ((bytes_read = recv(client_socket, buffer, BUFFER_SIZE, 0)) > 0) {
        printf("Received: %s\n", buffer);
        send(client_socket, buffer, bytes_read, 0); // Echo back the message
        memset(buffer, 0, BUFFER_SIZE);
    }
    
    closesocket(client_socket);
    printf("Client disconnected\n");
}

int main() {
    WSADATA wsa_data;
    SOCKET server_socket1, server_socket2, client_socket;
    struct sockaddr_in address1, address2;
    int addr_len = sizeof(struct sockaddr_in);

    // Initialize Winsock
    if (WSAStartup(MAKEWORD(2, 2), &wsa_data) != 0) {
        printf("WSAStartup failed\n");
        return 1;
    }

    // Create socket 1
    if ((server_socket1 = socket(AF_INET, SOCK_STREAM, 0)) == INVALID_SOCKET) {
        perror("Socket creation failed");
        WSACleanup();
        return 1;
    }

    // Create socket 2
    if ((server_socket2 = socket(AF_INET, SOCK_STREAM, 0)) == INVALID_SOCKET) {
        perror("Socket creation failed");
        WSACleanup();
        return 1;
    }

    // Prepare address 1
    address1.sin_family = AF_INET;
    address1.sin_addr.s_addr = INADDR_ANY;
    address1.sin_port = htons(PORT1);

    // Bind socket 1
    if (bind(server_socket1, (struct sockaddr *)&address1, sizeof(address1)) == SOCKET_ERROR) {
        perror("Bind failed");
        WSACleanup();
        return 1;
    }

    // Prepare address 2
    address2.sin_family = AF_INET;
    address2.sin_addr.s_addr = INADDR_ANY;
    address2.sin_port = htons(PORT2);

    // Bind socket 2
    if (bind(server_socket2, (struct sockaddr *)&address2, sizeof(address2)) == SOCKET_ERROR) {
        perror("Bind failed");
        WSACleanup();
        return 1;
    }

    // Listen on both sockets
    if (listen(server_socket1, 3) == SOCKET_ERROR || listen(server_socket2, 3) == SOCKET_ERROR) {
        perror("Listen failed");
        WSACleanup();
        return 1;
    }

    printf("Server listening on ports %d and %d...\n", PORT1, PORT2);

    // Accept connections on both sockets
    while (1) {
        printf("Waiting for clients...\n");

        if ((client_socket = accept(server_socket1, (struct sockaddr *)&address1, &addr_len)) != INVALID_SOCKET) {
            printf("Client connected on PORT1\n");
            handle_client(client_socket);
        }

        if ((client_socket = accept(server_socket2, (struct sockaddr *)&address2, &addr_len)) != INVALID_SOCKET) {
            printf("Client connected on PORT2\n");
            handle_client(client_socket);
        }
    }

    closesocket(server_socket1);
    closesocket(server_socket2);
    WSACleanup();
    return 0;
}
