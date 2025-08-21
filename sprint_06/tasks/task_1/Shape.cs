using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    public abstract class Shape : IComparable
    {
        string name;
        public Shape(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public abstract double Area();
        public abstract double Perimeter();

        public virtual int CompareTo(object obj1)
        {
            Shape shape1 = obj1 as Shape;
            if (shape1 == null)
            {
                throw new ArgumentException("Object is not Shape");
            }
            else
            {
                return this.Area().CompareTo(shape1.Area());
            }
        }
    }
}
