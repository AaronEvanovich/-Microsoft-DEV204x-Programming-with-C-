using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mod6;

namespace mod6
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

            s1.TakeTest();
            Console.WriteLine("{0}", c1.returnStudent(1).FirstName);
            t1.GradeTest();

            Console.WriteLine("===============Challenges!!===============");
            //CHALLENGES:       
            //Create an instance of a Person object in code
            //Create an instance of a Student object in code
            //Assign the Student object to the Person object
            //Access the properties of the Person instance you created
            //What do you notice about the properties for the Person instance?
            //Can you explain the behavior of the properties?

            Person randomPer = new Person();
            randomPer.FirstName = "PersonName";
            Student randomStu = new Student();
            randomStu.FirstName = "StudenName";
            randomPer = randomStu;
            Console.WriteLine("The person's first name is {0}.", randomPer.FirstName);
            Console.WriteLine("The student's first name  is {0}.", randomStu.FirstName);



            Console.ReadLine();

        }
    }
}