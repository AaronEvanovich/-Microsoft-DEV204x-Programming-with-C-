using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod8
{
    class Student : Person
    {
        private static int _studentCount;
        //public Stack Grades = new Stack();
        public Stack<int> Grades = new Stack<int>();

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
        public void FindGrades()
        {
            foreach (int grades in Grades)
            {
                Console.WriteLine("The grades are {0}.", grades);
            }
        }
    }
}
