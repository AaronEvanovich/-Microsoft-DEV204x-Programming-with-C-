using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class manager : employee
    {
        private char payRate;
        private employee[] emp;
        private string firstName = "Jim";

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
    }
}
