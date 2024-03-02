
#include "pch.h"
#include "Multiply.h"


extern "C" __declspec(dllexport) int MultiplyNumbers(int num1, int num2) {
    return num1 * num2;
}