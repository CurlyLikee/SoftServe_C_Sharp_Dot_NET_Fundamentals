/* task_2
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
*/

using System;
using System.Data;

namespace task_2
{
    class PrintStackTraceDemo
    {
        public static void T()
        {
            try
            {
                M();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public static void M()
        {
            X();
        }

        public static void L()
        {
            throw new Exception("An error occurred in method L.");
        }

        public static void X()
        {
            L();
        }
    }
}