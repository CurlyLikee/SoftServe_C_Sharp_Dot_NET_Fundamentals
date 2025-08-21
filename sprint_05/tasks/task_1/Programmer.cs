using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    public class Programmer : IDeveloper
    {
        string language;
        public string Tool
        {
            get { return language; }
            set { language = value; }
        }

        public void Create()
        {
            Console.WriteLine("Programmer created");
        }

        public void Destroy()
        {
            Console.WriteLine("Programmer destroyed");
        }

        public int CompareTo(IDeveloper other)
        {
            if (other == null) return 1;
            return Tool.CompareTo(other.Tool);
        }
    }
}
