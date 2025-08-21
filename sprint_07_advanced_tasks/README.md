# 7. Exception Handling

## Task 1
Create a method for calculating an area of a rectangle int GetRectangleArea(int a, int b), which should throw an ArgumentException if at least one of its arguments is negative and throw OverflowException if area bigger than Int32.MaxValue.

Create TryGetRectangleArea method which takes two parameters and calls GetRectangleArea to evaluate an area of a rectangle. Catch exceptions that can be generated and print the exception message if caught.

TryGetRectangleArea shouldn't generate any exceptions. In case when ArgumentException or OverflowException  is caught the method should return 0;

### Tests
**Test 1**
- **Test:** Console.WriteLine(ExceptionsTest.IsGetRectangleAreaCorrect_PositiveValidRange());
- **Expected:** True
- **Got:** True

---

**Test 2**
- **Test:** Console.WriteLine(ExceptionsTest.IsTryGetRectangleAreaCorrect_PositiveValidRange());
- **Expected:** True
- **Got:** True

---

**Test 3**
- **Test:** Console.WriteLine(ExceptionsTest.IsGetRectangleAreaCorrect_NegativeArguments());
- **Expected:** True
- **Got:** True

---

**Test 4**
- **Test:** Console.WriteLine(ExceptionsTest.IsTryGetRectangleAreaCorrect_NegativeArguments());
- **Expected:**
Value does not fall within the expected range.
Value does not fall within the expected range.
Value does not fall within the expected range.
True
- **Got:**
Value does not fall within the expected range.
Value does not fall within the expected range.
Value does not fall within the expected range.
True

---

**Test 5**
- **Test:** Console.WriteLine(ExceptionsTest.IsGetRectangleAreaCorrect_TooBigArguments());
- **Expected:** True
- **Got:** True

---

**Test 6**
- **Test:** Console.WriteLine(ExceptionsTest.IsTryGetRectangleAreaCorrect_TooBigArguments());
- **Expected:**
Arithmetic operation resulted in an overflow.
Arithmetic operation resulted in an overflow.
Arithmetic operation resulted in an overflow.
True
- **Got:**
Arithmetic operation resulted in an overflow.
Arithmetic operation resulted in an overflow.
Arithmetic operation resulted in an overflow.
True

---


## Task 2

We have the class PrintStackTraceDemo with four methods: L, M, T, X.
One of the methods of PrintStackTraceDemo throws Exception, 
the other one catches the exception and prints a stack trace.

We have this part of stack trace that was generated in PrintStackTraceDemo class:

at StackTrace.PrintStackTraceDemo.l() in prog.cs:line 21
at StackTrace.PrintStackTraceDemo.x() in prog.cs:line 26
at StackTrace.PrintStackTraceDemo.m() in prog.cs:line 16
at StackTrace.PrintStackTraceDemo.t() in prog.cs:line 5

Please, fill in the gaps in the code of the PrintStackTraceDemo class so that the stack trace will remain the same.
(Please, don't change line positions of methods - don't add or remove lines)


### Tests
**Test 1**
- **Test:** Console.WriteLine(Reflector.IsTypeClass("StackTrace.PrintStackTraceDemo"));
- **Expected:** True
- **Got:** True

---

**Test 2**
- **Test:** Console.WriteLine(Reflector.HasTypeDeclaredMethod(typeof(PrintStackTraceDemo), "T", Array.Empty<Type>()));
- **Expected:** True
- **Got:** True

---

**Test 3**
- **Test:** Console.WriteLine(Reflector.HasTypeDeclaredMethod(typeof(PrintStackTraceDemo), "X", Array.Empty<Type>()));;
- **Expected:** True
- **Got:** True

---

**Test 4**
- **Test:** Console.WriteLine(Reflector.HasTypeDeclaredMethod(typeof(PrintStackTraceDemo), "M", Array.Empty<Type>()));
- **Expected:** True
- **Got:** True

---

**Test 5**
- **Test:** Console.WriteLine(Reflector.HasTypeDeclaredMethod(typeof(PrintStackTraceDemo), "L", Array.Empty<Type>()));
- **Expected:** True
- **Got:** True

---

**Test 6**
- **Test:** PrintStackTraceDemo.T();
- **Expected:**
at StackTrace.PrintStackTraceDemo.L() in prog.cs:line 22
at StackTrace.PrintStackTraceDemo.X() in prog.cs:line 27
at StackTrace.PrintStackTraceDemo.M() in prog.cs:line 17
at StackTrace.PrintStackTraceDemo.T() in prog.cs:line 7
- **Got:**
at StackTrace.PrintStackTraceDemo.L() in prog.cs:line 22
at StackTrace.PrintStackTraceDemo.X() in prog.cs:line 27
at StackTrace.PrintStackTraceDemo.M() in prog.cs:line 17
at StackTrace.PrintStackTraceDemo.T() in prog.cs:line 7

---

**Test 7**
- **Test:** Console.WriteLine(StackTraceTest.MTryCall());
- **Expected:**
at StackTrace.PrintStackTraceDemo.L() in prog.cs:line 22
at StackTrace.PrintStackTraceDemo.X() in prog.cs:line 27
at StackTrace.PrintStackTraceDemo.M() in prog.cs:line 17
at StackTrace.StackTraceTest.MTryCall() in StackTraceTest.cs:line 13
- **Got:**
at StackTrace.PrintStackTraceDemo.L() in prog.cs:line 22
at StackTrace.PrintStackTraceDemo.X() in prog.cs:line 27
at StackTrace.PrintStackTraceDemo.M() in prog.cs:line 17
at StackTrace.StackTraceTest.MTryCall() in StackTraceTest.cs:line 13

---



