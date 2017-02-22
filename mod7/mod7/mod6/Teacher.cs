using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod7
{
    class Teacher : Person
    {
        public Teacher(string first, string last, string sex)
        {
            FirstName = first;
            LastName = last;
            Sex = sex;
        }
        public void GradeTest()
        {
            Console.WriteLine("Teacher grades test.");
        }
    }
}
