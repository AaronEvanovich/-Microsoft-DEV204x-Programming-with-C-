using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod4
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] student= new Student[5];
            student[0] = new Student("Jessie Pinkman", 'M', "Sep 24, 1984", "US");

            Console.WriteLine("The name of first student is {0}.", student[0].name);
            Console.WriteLine("The sex of first student is {0}.", student[0].sex);
            Console.WriteLine("The birthday of first student is {0}.", student[0].birthday);
            Console.WriteLine("The country of first student is {0}.", student[0].country);

            Console.ReadLine();

        }
    }
    struct Student
    {
        internal string name;
        internal char sex;
        internal DateTime birthday;
        internal string country;

        public Student(string name, char sex, string birthday, string country)
        {
            this.name = name;
            this.sex = sex;
            this.birthday = DateTime.Parse(birthday);
            this.country = country;
        }
    }
}
