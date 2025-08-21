using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    public class Operator : IComparable<Operator>
    {
        public static void GetInfo(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                Console.WriteLine($"{shape.Name}: Area = {shape.Area()}, Perimeter = {shape.Perimeter()}");
            }
        }


        public static void GetLargestPerimeter(Shape[] shapes)
        {
            Shape largest = null;
            double maxPerimeter = 0;

            foreach (Shape s in shapes)
            {
                double p = s.Perimeter();
                if (p > maxPerimeter)
                {
                    maxPerimeter = p;
                    largest = s;
                }
            }
        }


        public static void Sort(List<Shape> shapes)
        {
            shapes.Sort();
            foreach (Shape s in shapes)
            {
                Console.WriteLine(s.Name);
            }
        }

        public int CompareTo(Operator other)
        {
            if (other == null) return 1;
            return this.GetType().Name.CompareTo(other.GetType().Name);
        }
    }
}
