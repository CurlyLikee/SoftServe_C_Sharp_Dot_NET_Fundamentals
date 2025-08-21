/* task_1

Your task is:

1. Define a delegate MyDel that takes an integer parameter and returns void.
2. Create a Student class with a list of integers to store marks.
Include an event MarkChange of the type MyDel.
Implement an AddMark method to add a new mark and invoke the MarkChange event.

3. Create a Parent class with a method OnMarkChange that takes an integer parameter and prints it.

4. Create an Accountancy class with a method PayingFellowship that decides and prints whether the student 
should receive a scholarship based on the provided mark.

5. In the Main method, instantiate a Student, Parent, and Accountancy. 
Subscribe the Parent's OnMarkChange method and Accountancy's PayingFellowship method to the Student's MarkChange event.  

Test the functionality by calling AddMark. Provide the input of the mark from the console and check the notification.


 */

using System;


namespace task_1
{
    public class DelegateProblem
    {
        public static void Main()
        {
            Student student = new Student();
            Parent parent = new Parent();
            Accountancy accountancy = new Accountancy();


            Console.WriteLine("Please, input the mark");
            int mark = int.Parse(Console.ReadLine());

            student.MarkChange += parent.OnMarkChange;
            student.MarkChange += accountancy.PayingFellowship;

            student.AddMark(mark);
        }
    }
}
