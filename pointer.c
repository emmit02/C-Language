#include<stdio.h>
#include<conio.h>

void main()
{
    int a[10];
    int i;
    int *p;

    p = &a[0]; 
    for(int i = 0;i<10;i++)
    {
        
        printf("%d\n", &*p);
        p++;

    }
    getch();
}