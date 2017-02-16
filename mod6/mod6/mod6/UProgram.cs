using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod6
{
    class UProgram
    {
        private string _name;
        private Degree _dg;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Degree Dg
        {
            get { return _dg; }
            set { _dg = value; }
        }
        public UProgram(string name)
        {
            Name = name;
        }
    }
}
