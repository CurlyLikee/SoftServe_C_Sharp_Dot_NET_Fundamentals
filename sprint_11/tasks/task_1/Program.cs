/* task_1
Use classes Shape, Circle, and Square from one of the previous homework tasks (Inheritance in C#).
Create a class Operator and use Linq and string functions to complete the next tasks:

1) Create method AddShape that takes Shape as an argument and adds the received shape to 
the field shapes (add this field to the Operator set initial value - empty List of shapes to it).

2) Create method FindIn10To100Range that finds and writes to the console shapes with area from 
the range [10,100]

3) Create method FindContaininga that finds and writes to the console shapes whose name contains 
the letter 'a'

4) Create a method RemoveWithPerimeterLessThan5 that finds and removes from the list all shapes 
with a perimeter of less than 5 and writes the result list to the Console.
 */


using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public abstract class Shape : IComparable<Shape>
{
    private string name;

    public Shape(string name)
    {
        this.name = name;
    }

    public string Name { get { return name; } }

    public int CompareTo(Shape other)
    {
        return Area().CompareTo(other.Area());
    }

    public abstract double Area();
    public abstract double Perimeter();

    public override string ToString()
    {
        return Name;
    }
}

public class Circle : Shape
{
    public const double pi = 3.14;
    public double Radius { get; set; }

    public Circle(string name, double radius) : base(name)
    {
        Radius = radius;
    }

    public override double Area()
    {
        return pi * Radius * Radius;
    }
    public override double Perimeter()
    {
        return 2 * pi * Radius;
    }

}

public class Square : Shape
{
    public double Side { get; set; }

    public Square(string name, double side) : base(name)
    {
        Side = side;
    }

    public override double Area()
    {
        return Side * Side;
    }
    public override double Perimeter()
    {
        return 4 * Side;
    }
}

public class Operator
{
    private List<Shape> shapes = new List<Shape>();

    public void AddShape(Shape shape)
    {
        shapes.Add(shape);
    }

    public void FindIn10To100Range()
    {
        var filtered = shapes.Where(s => s.Area() >= 10 && s.Area() <= 100);
        foreach (var shape in filtered)
        {
            Console.WriteLine(shape.Name);
        }
    }

    public void FindContaininga()
    {
        foreach (var shape in shapes)
        {
            if (Regex.IsMatch(shape.Name, "a", RegexOptions.IgnoreCase))
            {
                Console.WriteLine(shape.Name);
            }
        }
    }

    public void RemoveWithPerimeterLessThan5()
    {
        shapes.RemoveAll(shape => shape.Perimeter() < 5);
        foreach (var shape in shapes)
        {
            Console.WriteLine(shape.Name);
        }
    }


    public void Sort()
    {
        shapes.Sort();
        foreach (var shape in shapes)
        {
            Console.WriteLine(shape.Name);
        }
    }
}