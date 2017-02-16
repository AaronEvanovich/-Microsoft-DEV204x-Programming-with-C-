using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    abstract class employee
    {
        private string empNumber;
        private string firstName = "Tom";
        private string lastName;
        private string address;

        public string EmpNumber
        {
            get { return empNumber; }
            set { empNumber = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            manager leadManager = new manager();
            
            Console.WriteLine("The name of the leadManager is {0} {1}", leadManager.FirstName, leadManager.LastName);
            Console.ReadLine();
        }
    }
}
