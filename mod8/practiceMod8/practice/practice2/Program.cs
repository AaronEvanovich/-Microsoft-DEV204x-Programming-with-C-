using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Mocha";
            string s2 = "Latte";
            string s3 = "Espresso";

            List<string> CoffeeList = new List<string>();

            CoffeeList.Add(s1);
            CoffeeList.Add(s2);
            CoffeeList.Add(s3);

            foreach (string Coffee in CoffeeList)
            {
                Console.WriteLine("The name of the coffee is {0}.", Coffee);
            }
            Console.ReadLine();


        }
    }

    
}
