#include<stdio.h>
#include<string.h>
#include<stdlib.h>

struct items{
    char item[20];
    float price;
    int quantity;
};
 
struct orders{
    char customer[50];
    float date[50];
    int no_of_items;
    struct items itm[50];
};


//function to generate bill
void generateBillHeader(char name[50], char date[30])
{
    printf("\n\n");
        printf("\t      Sanjeevani Restaurant");
        printf("\n\t    --------------------------");
        printf("\nDate: %s", date);
        printf("\nInvoice to: %s", name);
        printf("\n");
        printf("-----------------------------------------------\n");
        printf("Items\t\t");
        printf("Quantity\t\t");
        printf("Total\t\t");
        printf("\n-----------------------------------------------");
        printf("\n\n");
}

void generateBillBody(char item[30], int quantity, float price)
{
    printf("%s\t\t", item);
    printf("%d\t\t", quantity);
    printf("%.2f\t\t", quantity * price);
    printf("\n");
}
 

void generateBillFooter(float total)
{
    printf("\n");
    float dis = 0.1* total;
    float net_total = total - dis;
    float cgst = 0.09 * net_total;
    float grand_total = net_total + 2*cgst;
    printf("--------------------------------------------------\n");
    printf("Sub Total\t\t\t%.2f",total);
    printf("\nDiscount @10%s\t\t\t%.2f","%",dis);
    printf("\n\t\t\t\t-------------");
    printf("\nNet Total\t\t\t%.2f",net_total);
    printf("\nCGST @9\t\t\t\t%.2f",cgst);
    printf("\nSGST @9\t\t\t\t%.2f",net_total);
    printf("\n----------------------------------------------------");
    printf("\nGrand Total\t\t\t%.2f",grand_total);
    printf("\n----------------------------------------------------\n");
   
}

int main()
{
    float total;
    int opt, n;
    struct orders ord;
    struct orders orders;
    {
        /* data */
    };
    
    char savebill='y';
    FILE *fp;
    //dashboard
    printf("\n\n==========Sanjeevani Restaurant===========");
    printf("\nPlease select your prefered operation: \t");
    printf("\n1. Generate Invoice");
    printf("\n2. Show all invoices");
    printf("\n3. Search Invoices");
    printf("\n4. Exit");

    printf("\nThank you for choosing us! \t");
    scanf("%d", &opt);
    printf("\nYou have chosen: *%d", opt);
    fgetc(stdin);

    switch(opt)
    {
        case 1:
        system("clear");
        printf("\n\nPlease Enter the name of the customer:\t");
        fgets(ord.customer, 50, stdin);
        ord.customer[strlen(ord.customer)-1]=0;
        strcpy(ord.date, __DATE__);
        printf("Please Enter the number of item:\t");
        scanf("%d", &n);
        ord.no_of_items = n;
        for(int i = 0; i < n; i++)
        {
            fgetc(stdin);
            printf("\n\n");
            printf("Please enter the item %d\t\t", i+1);
            fgets(ord.itm[i].item, 20, stdin);
            ord.itm[i].item[strlen(ord.itm[i].item)-1]=0;
            printf("Please enter the quantity:\t");
            scanf("%d", &ord.itm[i].quantity);
            printf("Please enter the unit price:\t");
            scanf("%f", &ord.itm[i].price);
            total += ord.itm[i].quantity *ord.itm[i].price;
        }
        generateBillHeader(ord.customer, ord.date);
        for(int i=0;i<ord.no_of_items;i++)
        {
            generateBillBody(ord.itm[i].item, ord.itm[i].quantity, ord.itm[i].price);
        }
        generateBillFooter(total);

        printf("\nDo you want to save the invoice : [y/n]\t");
        scanf("%s", &savebill);

        if(savebill == 'y')
        {
            fp = fopen("Restaurent.dat","a+");
            fwrite(&ord, sizeof(struct orders),1,fp);
            if(fwrite != 0)
            {
                printf("\nSuccesfull saved!");
            }
            else{
                printf("Error in saving");
            }
            fclose(fp);
        }
        break;
        

        case 2 :
        system("clear");
        fp = fopen(("Restaurent.dat","r"));
        printf("\n ******** Your Previous Invoices ********\n");
        while(fread(&orders, sizeof(struct orders),1,fp))
        {
            float tot = 0;
            generateBillHeader(orders.customer, orders.date);
            for(int i=0; i<orders.no_of_items ;i++)
            {
                generateBillBody(orders.itm[i].item, orders.itm[i].quantity, orders.itm[i].price);
                tot += orders.itm[i].quantity *orders.itm[i].price;
            }
            generateBillFooter(tot);
            
        };
        fclose(fp);
        break;


        case 3:
        printf("Enter the name of the customer: ");
        system("clear");
        fp = fopen(("Restaurent.dat","r"));
        printf("\n ******** Your Previous Invoices ********\n");
        while(fread(&orders, sizeof(struct orders),1,fp))
        {
            float tot = 0;
            generateBillHeader(orders.customer, orders.date);
            for(int i=0; i<orders.no_of_items ;i++)
            {
                generateBillBody(orders.itm[i].item, orders.itm[i].quantity, orders.itm[i].price);
                tot += orders.itm[i].quantity *orders.itm[i].price;
            }
            generateBillFooter(tot);
            
        };
        fclose(fp);
        break;

        
    }
    printf("\n\n");
    return 0;
}