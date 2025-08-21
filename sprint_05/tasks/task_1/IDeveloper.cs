using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    public interface IDeveloper : IComparable<IDeveloper>
    {
        void Create();

        void Destroy();
        string Tool { get; set; }

        public int CompareTo(IDeveloper other)
        {
            if (other == null) return 1;
            return Tool.CompareTo(other.Tool);
        }
    }
}
