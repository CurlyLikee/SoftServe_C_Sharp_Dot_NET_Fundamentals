using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    public class Student
    {
        public List<int> grades = new List<int>();
        public delegate void MyDel(int f);
        public event MyDel MarkChange;




        public void AddMark(int newMark)
        {
            grades.Add(newMark);

            if (MarkChange != null)
            {
                MarkChange.Invoke(newMark);
            }

        }
    }
}
