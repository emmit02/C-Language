#include <stdio.h>
#include "program_runner.c"

int factorial(int n) {
    if (n < 0) {
        return -1; 
    }
    int result = 1;
    for (int i = 1; i <= n; i++) {
        result *= i;
    }
    return result;
}

int calling() {
    int num;
    printf("Enter a number: ");
    scanf("%d", &num);

    int result = factorial(num);
    if (result == -1) {
        printf("Factorial is not for negative numbers.\n");
    } else {
        printf("Factorial of %d is %d.\n\n", num, result);
    }
    return 0;
}