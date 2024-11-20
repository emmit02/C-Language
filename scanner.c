#include <stdio.h>
#include <stdlib.h>
#include <time.h>

#define MAX_GROUPS 10
#define MAX_CONDITIONS 10

// Variables to be compared
typedef enum 
{   BID_PRICE,
    BID_QTY,
    ASK_PRICE,
    ASK_QTY 
} Variable;

// Comparison operations
typedef enum 
{ 
    GT,
    LT,
    EQ 
} Operation;

// Condition structure
typedef struct {
    Variable var1; 
    int is_value;  
    Variable var2; 
    float value;   
    Operation op;  
} Condition;

typedef struct {
    Condition conditions[MAX_CONDITIONS];
    int num_conditions;
} Group;

// Function to generate random values
void generate_random_values(float *bid_price, float *bid_qty, float *ask_price, float *ask_qty) 
{
    *bid_price = (rand() % 10000) + 1;
    *bid_qty = (rand() % 10000) + 1;
    *ask_price = (rand() % 10000) + 1;
    *ask_qty = (rand() % 10000) + 1;
}

// Function to evaluate a single condition
int evaluate_condition(Condition condition, float bid_price, float bid_qty, float ask_price, float ask_qty) {
    float var1_value = 0, var2_value = 0;

    // Determine the value of the first variable
    switch (condition.var1) {
        case BID_PRICE: var1_value = bid_price; break;
        case BID_QTY: var1_value = bid_qty; break;
        case ASK_PRICE: var1_value = ask_price; break;
        case ASK_QTY: var1_value = ask_qty; break;
    }

    // Determine the value of the second entity (value or variable)
    if (condition.is_value) {
        var2_value = condition.value;
    } else {
        switch (condition.var2) {
            case BID_PRICE: var2_value = bid_price; break;
            case BID_QTY: var2_value = bid_qty; break;
            case ASK_PRICE: var2_value = ask_price; break;
            case ASK_QTY: var2_value = ask_qty; break;
        }
    }

    // Perform the comparison
    switch (condition.op) {
        case GT: return var1_value > var2_value;
        case LT: return var1_value < var2_value;
        case EQ: return var1_value == var2_value;
        default: return 0;
    }
}

// Function to evaluate a group of conditions (with AND and OR)
int evaluate_group(Group group, float bid_price, float bid_qty, float ask_price, float ask_qty) {
    int result = evaluate_condition(group.conditions[0], bid_price, bid_qty, ask_price, ask_qty);
    for (int i = 1; i < group.num_conditions; i++) 
    {
        // For simplicity, assume AND operation between conditions (can be expanded for OR)
        result = result && evaluate_condition(group.conditions[i], bid_price, bid_qty, ask_price, ask_qty);
    }
    return result;
}

int main() {
    srand(time(0));

    int num_groups;
    printf("Enter number of groups: ");
    scanf("%d", &num_groups);

    Group groups[MAX_GROUPS];

    // Input groups and conditions
    for (int i = 0; i < num_groups; i++) {
        printf("\nEnter number of conditions in group %d: ", i + 1);
        scanf("%d", &groups[i].num_conditions);

        for (int j = 0; j < groups[i].num_conditions; j++) {
            int var1, op, is_value, var2, check;
            float value;

            printf("\nSelect for Condition:   *%d*   and Group:   *%d*    first entity (1. bid_price, 2. bid_qty, 3. ask_price, 4. ask_qty): ", j+1 , i+1);
            scanf("%d", &var1);
            groups[i].conditions[j].var1 = var1 - 1;

            do
            {
                printf("Select comparison operation (1. >, 2. <, 3. ==): ");
                scanf("%d", &op);
                groups[i].conditions[j].op = op - 1;
                
                printf("Is Condition:   *%d*   and Group:   *%d*   second entity a value? (1 for value, 0 for variable): ",j+1 , i+1);
                scanf("%d", &is_value);
                groups[i].conditions[j].is_value = is_value;

                if (is_value) {
                    printf("Enter value: ");
                    scanf("%f", &value);
                    groups[i].conditions[j].value = value;
                } else {
                    printf("Select second entity (1. bid_price, 2. bid_qty, 3. ask_price, 4. ask_qty): ");
                    scanf("%d", &var2);
                    groups[i].conditions[j].var2 = var2 - 1;
                }
                printf("\nDo you want to apply the extra condition? (1 for Yes, 0 for No) :  ");
                scanf("%d", &check);
            }while(check == 1);    
        }
    }

    // Random value generation and evaluation loop
    for (int iteration = 0; iteration < 100; iteration++) 
    {
        float bid_price, bid_qty, ask_price, ask_qty;
        generate_random_values(&bid_price, &bid_qty, &ask_price, &ask_qty);

        int group_result = evaluate_group(groups[0], bid_price, bid_qty, ask_price, ask_qty);
        for (int i = 1; i < num_groups; i++) {
            // Assume AND between groups (can be modified to OR)
            group_result = group_result && evaluate_group(groups[i], bid_price, bid_qty, ask_price, ask_qty);
        }

        if(group_result == 1)
        {
            printf("\nIteration %d: Bid Price: %.2f, Bid Qty: %.2f, Ask Price: %.2f, Ask Qty: %.2f -> Result: %s\n",
               iteration + 1, bid_price, bid_qty, ask_price, ask_qty, group_result ? "TRUE" : "FALSE");
        }
    }
    return 0;
}