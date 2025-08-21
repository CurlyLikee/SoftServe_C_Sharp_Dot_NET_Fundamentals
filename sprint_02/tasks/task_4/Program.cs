/* task_4
Create a class Solution. In the method Main() of this class write code for solving the next task:

Declare struct Dog with fields name, mark, and age.
Declare object myDog of Dog type and read values for it.
Output information on the console. (Override method ToString in the struct)

Example of output:
Name: Ava, mark: excellent, age: 3
 */



namespace task_4
{
    public struct Dog
    {
        public string name;
        public string mark;
        public int age;
    }


    public class Solution
    {
        public static void Main()
        {

            Dog myDog;
            myDog.name = Convert.ToString(Console.ReadLine());
            myDog.mark = Convert.ToString(Console.ReadLine());
            myDog.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Name: {myDog.name}, mark: {myDog.mark}, age: {myDog.age}");
        }
    }
}
