using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("John", "Smith", "M");
            Student s2 = new Student("Tom", "Orr", "M");
            Student s3 = new Student("Ellen", "Tousi", "F");

            Course c1 = new Course("Programming with C#", 3);
            c1.addStudent(s1);
            c1.addStudent(s2);
            c1.addStudent(s3);
            Teacher t1 = new Teacher("Walter", "White", "M");
            c1.Staff = t1;
            Degree d1 = new Degree("Bachelor");
            d1.Cs = c1;
            UProgram u1 = new UProgram("Information Technology");
            u1.Dg = d1;

            Console.WriteLine("{0} program contains {1} degree.", u1.Name, u1.Dg.Name);
            Console.WriteLine("{0} degree contains {1} course.", d1.Name, d1.Cs.Name);
            Console.WriteLine("{0} course contains {1} students.", c1.Name, Student.StudentCount());
            Console.ReadLine();

        }
    }
    class Student
    {
        private static int _studentCount;
        private string _firstName;
        private string _lastName;
        private string _sex;
        
        #region Properties
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
        #endregion

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
    }
    class Teacher
    {
        private string _firstName;
        private string _lastName;
        private string _sex;

        #region Properties
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
        #endregion

        public Teacher(string first, string last, string sex)
        {
            FirstName = first;
            LastName = last;
            Sex = sex;
        }
    }
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
            if (studenNumber<3)
            {
                _s[studenNumber] = s;
                studenNumber++;
            }
            else
            {
                Console.WriteLine("Full.");
            }
        }
    }
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
