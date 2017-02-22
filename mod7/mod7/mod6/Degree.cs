using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod7
{
    class Degree
    {
        private string _name;
        private Course _cs;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Course Cs
        {
            get { return _cs; }
            set { _cs = value; }
        }
        public Degree(string name)
        {
            Name = name;
        }
    }
}
