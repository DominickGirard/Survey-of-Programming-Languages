#include <iostream>

// Function to swap values pointed to by two int pointers
void customSwap(int* ptrA, int* ptrB) {
    int temp = *ptrA;
    *ptrA = *ptrB;
    *ptrB = temp;
}

// Function to display address and value
void displayInfo(const char* name, int* ptr) {
    std::cout << "Address of " << name << ": " << ptr << ", Value: " << *ptr << std::endl;
}

int main() {
    // Initialize two integer variables
    int firstValue = 4;
    int secondValue = 22;

    // Declare and initialize two integer pointers
    int* ptrFirst = &firstValue;
    int* ptrSecond = &secondValue;

    // Print addresses and values before the custom swap
    std::cout << "Before Custom Swap:\n";
    displayInfo("firstValue", ptrFirst);
    displayInfo("secondValue", ptrSecond);

    // Call the customSwap function to swap values using pointers
    customSwap(ptrFirst, ptrSecond);

    // Print addresses and values after the custom swap
    std::cout << "\nAfter Custom Swap:\n";
    displayInfo("firstValue", ptrFirst);
    displayInfo("secondValue", ptrSecond);

    return 0;
}