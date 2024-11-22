#include <stdio.h>
#include "program.c" 

void test_factorial_positive() {
    if (factorial(5) == 120) {
        printf("positive passed.\n");
    } else {
        printf("positive failed.\n");
    }
}

void test_factorial_zero() {
    if (factorial(0) == 1) {
        printf("zero passed.\n");
    } else {
        printf("zero failed.\n");
    }
}

void test_factorial_negative() {
    if (factorial(-3) == -1) {
        printf("negative passed.\n");
    } else {
        printf("negative failed.\n");
    }
}

int main() {
    calling();
    test_factorial_positive();
    test_factorial_zero();
    test_factorial_negative();
    return 0;
}
