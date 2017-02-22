using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod7
{
    class Course
    {
        private string _name;
        private int _credit;
        //private Student[] _s = new Student[3];
        public static ArrayList _s = new ArrayList();
        private int studenNumber = 0;
        private Teacher _t;


        #region Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Credit
        {
            get { return _credit; }
            set { _credit = value; }
        }
        public Teacher Staff
        {
            get { return _t; }
            set { _t = value; }
        }
        
        #endregion

        public Course(string name, int credit)
        {
            Name = name;
            Credit = credit;
        }
        public void addStudent(Student s)
        {
            if (studenNumber < 3)
            {
                _s.Add(s);
                studenNumber++;
            }
            else
            {
                Console.WriteLine("Full.");
            }
        }
        public Student returnStudent(int order)
        {
            return (Student)_s[order];
        }
        public static void ListStudent()
        {
            foreach (Student student in _s)
            {
                Console.WriteLine("The name of the student is {0} {1}.", student.FirstName, student.LastName);
                foreach (int grades in student.Grades)
                {
                    Console.WriteLine("The student's grades are {0}.", grades);
                }
            }
        }
    }
}
