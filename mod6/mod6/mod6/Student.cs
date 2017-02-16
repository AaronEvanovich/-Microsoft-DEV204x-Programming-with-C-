using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod6
{
    class Student : Person
    {
        private static int _studentCount;

        public Student()
        {
            _studentCount++;
        }
        public Student(string first, string last, string sex)
        {
            FirstName = first;
            LastName = last;
            Sex = sex;
            _studentCount++;
        }
        public static int StudentCount()
        {
            return _studentCount;
        }
        public void TakeTest()
        {
            Console.WriteLine("Student takes test.");
        }
    }
}
