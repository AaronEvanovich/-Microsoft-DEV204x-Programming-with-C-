using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod6
{
    class Course
    {
        private string _name;
        private int _credit;
        private Student[] _s = new Student[3];
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
                _s[studenNumber] = s;
                studenNumber++;
            }
            else
            {
                Console.WriteLine("Full.");
            }
        }
        public Student returnStudent(int order)
        {
            return _s[order];
        }
    }
}
