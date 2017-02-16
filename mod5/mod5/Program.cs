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
        { //(1)
            Student Stud001 = new Student();
            Student Stud002 = new Student();
            Student Stud003 = new Student();
            //(2)
            Course ProgrammingWithCSharp = new Course();
            ProgrammingWithCSharp.CourseName = "Programming with C#";
            //(3)
            ProgrammingWithCSharp.ArrayStudent[0] = Stud001;
            ProgrammingWithCSharp.ArrayStudent[1] = Stud002;
            ProgrammingWithCSharp.ArrayStudent[2] = Stud003;
            //(4)
            Teacher Teacher001 = new Teacher();
            //(5)
            ProgrammingWithCSharp.ArrayTeacher[0] = Teacher001;
            //(6)
            Degree Bachelor = new Degree();
            Bachelor.DegreeName = "Bachelor of Science";
            //(7)
            Bachelor.SingleCourse = ProgrammingWithCSharp;
            //(8)
            UProgram InformationTechnology = new UProgram();
            InformationTechnology.Name = "Information Technology";
            //(9)
            InformationTechnology.SingleDegree = Bachelor;
            //(10)
            Console.WriteLine("The {0} program contains the {1} degree." +
            "\nThe {1} degree contains the course {2}." +
            "\nThe {2} course contains {3} student(s)."
            , InformationTechnology.Name, Bachelor.DegreeName, ProgrammingWithCSharp.CourseName, Stud003.Counter);
            Console.WriteLine("{0}", ProgrammingWithCSharp.ArrayStudent[0].FirstName);
            Console.ReadKey();
        }
        public class Student
        { //Private member variables:
            private string firstName;
            private string lastName;
            private int age;
            //private int StudentCount;

            //public properties
            public string FirstName
            {
                get { return firstName; }
                set { this.firstName = value; }
            }
            public string LastName
            {
                get { return lastName; }
                set { this.lastName = value; }
            }
            public int Age
            {
                get { return age; }
                set { this.age = value; }
            }
            //Track Number of students enrolled:
            static private int counter;
            public int Counter
            {
                get { return counter; }
            }
            public Student()
            {
                firstName = "Tom";
                counter++;
            }
        }
        public class Teacher
        {
            //private members
            private string firstName;
            private string lastName;
            private int yearsOfExp;
            //public properties
            public string FirstName
            {
                get { return firstName; }
                set { this.FirstName = value; }
            }
            public string LastName
            {
                get { return lastName; }
                set { this.lastName = value; }
            }
            public int YearsOfExp
            {
                get { return yearsOfExp; }
                set { this.yearsOfExp = value; }
            }
        }
        public class UProgram
        {
            //Private members
            private string name;
            private DateTime dateAccredited;
            private int maxEnrollment;
            private Degree singleDegree;
            public string Name
            {
                get { return name; }
                set { this.name = value; }
            }
            public DateTime DateAccredited
            {
                get { return dateAccredited; }
                set { this.dateAccredited = value; }
            }
            public int MaxEnrollment
            {
                get { return maxEnrollment; }
                set { this.maxEnrollment = value; }
            }
            public Degree SingleDegree
            {
                get { return singleDegree; }
                set { this.singleDegree = value; }
            }
        }
        public class Degree
        {
            //private members
            private string degreeName;
            private bool isGraduate;
            private int duration;
            private Course singleCourse;
            //public properties
            public string DegreeName
            {
                get { return degreeName; }
                set { this.degreeName = value; }
            }
            public bool IsGraduate
            {
                get { return isGraduate; }
                set { this.isGraduate = value; }
            }
            public int Duration
            {
                get { return duration; }
                set { this.duration = value; }
            }
            public Course SingleCourse
            {
                get { return singleCourse; }
                set { this.singleCourse = value; }
            }
        }
        public class Course
        {
            //Private members
            private string courseName;
            private string department;
            private DateTime startDate;
            private Student[] arrayStudent = new Student[3];
            private Teacher[] arrayTeacher = new Teacher[3];
            public string CourseName
            {
                get { return courseName; }
                set { this.courseName = value; }
            }
            public string Department
            {
                get { return department; }
                set { this.department = value; }
            }
            public DateTime StartDate
            {
                get { return startDate; }
                set { this.startDate = value; }
            }
            public Student[] ArrayStudent
            {
                get { return arrayStudent; }
                set { this.arrayStudent = value; }
            }
            public Teacher[] ArrayTeacher
            {
                get { return arrayTeacher; }
                set { this.arrayTeacher = value; }
            }
        }
    }
}