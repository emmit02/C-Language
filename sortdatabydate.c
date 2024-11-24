#include <stdio.h>
#include <string.h>

#define MAX_LINE_LENGTH 256
int counter = 1;
int main() 
{
    FILE *file = fopen("result.txt", "r"); 
    if (file == NULL) {
        printf("Error: Could not open file.\n");
        return 1;
    }
    
    char line[MAX_LINE_LENGTH];
    char previousTime[20] = ""; 

    while (fgets(line, sizeof(line), file)) 
    { 
        char time[20] = ""; 

        if (sscanf(line, " COUNT: %*d | Token: %*d | Time: [%19[^]]", time) == 1) {
            if (strcmp(time, previousTime) != 0) 
            { 
                printf("counter : %d | %s", counter, line); 
                strncpy(previousTime, time, sizeof(previousTime) - 1); 
                previousTime[sizeof(previousTime) - 1] = '\0'; 
                counter++;
            }
        }
        
    }

    fclose(file); // Close the file
    return 0;
}
