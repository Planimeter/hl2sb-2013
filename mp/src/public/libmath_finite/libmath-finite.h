
#ifndef LIB_MATH_FINITE_
#define LIB_MATH_FINITE_

#include <math.h>

#if defined(__cplusplus)
extern "C" {
#endif

double __acos_finite(double x) { return acos(x); }
double __asin_finite(double x) { return asin(x); }
double __atan_finite(double x) { return atan(x); }
double __atan2_finite(double x, double y) { return atan2(x, y); }
double __exp_finite(double x) { return exp(x); }
double __exp2_finite(double x) { return exp2(x); }
double __fmod_finite(double x, double y) { return fmod(x, y); }
double __log_finite(double x) { return log(x); }
double __log2_finite(double x) { return log2(x); }
double __log10_finite(double x) { return log10(x); }
double __pow_finite(double x, double y) { return pow(x, y); }

#if defined(__USE_ISOC99)
float __acosf_finite(float x) { return acosf(x); }
float __asinf_finite(float x) { return asinf(x); }
float __atanf_finite(float x) { return atanf(x); }
float __atan2f_finite(float x, float y) { return atan2f(x, y); }
float __expf_finite(float x) { return expf(x); }
float __exp2f_finite(float x) { return exp2f(x); }
float __fmodf_finite(float x, float y) { return fmodf(x, y); }
float __logf_finite(float x) { return logf(x); }
float __log2f_finite(float x) { return log2f(x); }
float __log10f_finite(float x) { return log2f(x); }
float __powf_finite(float x, float y) { return powf(x, y); }
#endif

#if defined(__cplusplus)
}
#endif

#endif  // LIB_MATH_FINITE_

