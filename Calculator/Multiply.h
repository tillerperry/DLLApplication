#pragma once

#ifdef EXAMPLEDLL_EXPORTS
#define EXAMPLEDLL_API __declspec(dllexport)
#else
#define EXAMPLEDLL_API __declspec(dllimport)
#endif

extern "C" {
    // Function declaration
    EXAMPLEDLL_API int MultiplyNumbers(int num1, int num2);
}
