#include <stdio.h>
int main() {
   // using scanf() 
   int user_input;
   
   printf("Please enter a number: ");
   scanf("%d", &user_input);
   printf("You entered: %d", user_input);
   scanf("%d", &user_input);
   return 0;
}