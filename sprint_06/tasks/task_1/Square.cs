using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    public class Square : Shape, IComparable<Square>
    {
        double side;
        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }
        public double Side { get { return side; } }
        public override double Area()
        {
            return side * side;
        }

        public override double Perimeter()
        {
            return 4 * side;
        }

        public int CompareTo(Square other)
        {
            if (other == null) return 1;
            return this.side.CompareTo(other.side);
        }
    }
}
