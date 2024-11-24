#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <winsock2.h>
#include <time.h>

#define PORT1 8080
#define PORT2 8081
#define BUFFER_SIZE 1024

void generate_and_send_data(SOCKET client_socket) 
{
    char buffer[BUFFER_SIZE];
    srand((unsigned int)time(NULL)); // Seed for random number generation

    while (1) {
        // Generate random data
        int token = rand() % 100000;
        time_t now = time(NULL);
        struct tm *local_time = localtime(&now);

        int bid_value = rand() % 100000;
        int bid_qty = rand() % 50000;
        int ask_value = rand() % 100000;
        int ask_qty = rand() % 50000;
        float open = 900 + (rand() % 100) / 10.0;
        float high = open + (rand() % 50) / 10.0;
        float low = open - (rand() % 50) / 10.0;
        float close = low + (rand() % 50) / 10.0;

        snprintf(buffer, BUFFER_SIZE,
                 "| Token: %d | Time: [%02d:%02d:%02d] | Stock name: adaniENT | Bid_value = %d | Bid Qty = %d | Ask value = %d | Ask Qty = %d | Open: %.2f | High: %.2f | Low: %.2f | Close: %.2f |\n",
                 token, local_time->tm_hour, local_time->tm_min, local_time->tm_sec,
                 bid_value, bid_qty, ask_value, ask_qty, open, high, low, close);

        if (send(client_socket, buffer, strlen(buffer), 0) == SOCKET_ERROR) {
            printf("Send failed. Client disconnected.\n");
            break;
        }

        printf("Sent: %s", buffer);

        Sleep(10); 
    }
}
void handle_client(SOCKET client_socket) 
{
    printf("Client connected, Generating random Data.....");
    Sleep(5000);    
    generate_and_send_data(client_socket);
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
