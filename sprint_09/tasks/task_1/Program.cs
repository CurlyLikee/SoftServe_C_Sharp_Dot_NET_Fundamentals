/* task_1
Create struct Point:

fields x and y;
method ToString(), which return the Point in format "(x,y)";
method DistanceTo() with parameter Point, which returns the distance to the given point (e.g. point1.DistanceTo(point2));
method DistanceToOrigin() computes the Euclidean distance from the point to the origin using the formula
\(\sqrt{(x-0)^{2}+(y-0)^{2}}\) , which simplifies to \(\sqrt{x^{2}+y^{2}}\)


Create class Triangle:

fields vertex1, vertex2, vertex3 of type Point;
constructor;
methods Perimeter() - calculate the perimeter of the shape, Area() - its area, Print() - to provide the output;
method ClosestVertexToOrigin()  to find the vertex of a triangle that is closest to the origin point (0,0). 
The method calculates the distance of each vertex of the triangle (vertex1, vertex2, vertex3) to the origin. 
This is achieved by calling the DistanceToOrigin() method of the Point struct.
In the Main() create a list of 3 triangles and write into the console the information about these shapes.

Print the triangle with the vertex which is the closest to the origin (0,0)
 */

using System;
using System.Collections.Generic;


namespace task_1
{
    public struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"({x},{y})";
        }

        public double DistanceTo(Point other)
        {
            double dx = this.x - other.x;
            double dy = this.y - other.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public double DistanceToOrigin()
        {
            return Math.Sqrt(x * x + y * y);
        }
    }

    class Triangle
    {
        Point vertex1;
        Point vertex2;
        Point vertex3;

        public Triangle(Point vertex1, Point vertex2, Point vertex3)
        {
            this.vertex1 = vertex1;
            this.vertex2 = vertex2;
            this.vertex3 = vertex3;
        }


        public double Perimeter()
        {
            double a = vertex1.DistanceTo(vertex2);
            double b = vertex2.DistanceTo(vertex3);
            double c = vertex3.DistanceTo(vertex1);
            double perimeter = a + b + c;
            return perimeter;
        }

        public double Area()
        {
            double a = vertex1.DistanceTo(vertex2);
            double b = vertex2.DistanceTo(vertex3);
            double c = vertex3.DistanceTo(vertex1);
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }


        public void Print()
        {
            Console.WriteLine($"Triangle vertices: {vertex1}, {vertex2}, {vertex3}");
            Console.WriteLine($"Perimeter: {Perimeter()}");
            Console.WriteLine($"Area: {Area()}");
        }


        public Point ClosestVertexToOrigin()
        {
            double d1, d2, d3;
            d1 = vertex1.DistanceToOrigin();
            d2 = vertex2.DistanceToOrigin();
            d3 = vertex3.DistanceToOrigin();

            if (d1 < d2 && d1 < d3)
            {
                return vertex1;
            }
            else if (d2 < d1 && d2 < d3)
            {
                return vertex2;
            }
            else
            {
                return vertex3;
            }

        }
    }

    class ShapeProblem
    {
        public static void Main()
        {
            Triangle ? bestTriangle = null;

            double bestDist = double.PositiveInfinity;

            var triangles = new List<Triangle>()
            {
                new Triangle(new Point(0,0), new Point(1,0), new Point(0,1)),
                new Triangle(new Point(0,0), new Point(2,0), new Point(1,2)),
                new Triangle(new Point(1,1), new Point(4,1), new Point(1,3))
            };
            foreach (var triangle in triangles)
            {
                triangle.Print();
                var p = triangle.ClosestVertexToOrigin();
                var d = p.DistanceToOrigin();

                if (d < bestDist)
                {
                    bestDist = d;
                    bestTriangle = triangle;
                }
            }

            Console.WriteLine("\nTriangle with a vertex closest to the origin:");
            bestTriangle?.Print();
        }
    }
}
