using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    public class Builder : IDeveloper
    {
        string tool;

        public string Tool
        {
            get { return tool; }
            set { tool = value; }
        }

        public void Create()
        {
            Console.WriteLine("Builder created");
        }

        public void Destroy()
        {
            Console.WriteLine("Builder destroyed");
        }

        public int CompareTo(IDeveloper other)
        {
            if (other == null) return 1;
            return Tool.CompareTo(other.Tool);
        }
    }
}