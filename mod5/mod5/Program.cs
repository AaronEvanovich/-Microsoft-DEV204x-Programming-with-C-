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
            int nameList;
            Console.WriteLine("How many names are you going to put in?");
            nameList = Convert.ToInt32(Console.ReadLine());

            DrinksMachine[] dm = new DrinksMachine[nameList];

            //DrinksMachine tm = new DrinksMachine();
            //DrinksMachine jn = new DrinksMachine("John");

            for (int i = 0; i < nameList; i++)
            {
                Console.WriteLine("The detail of the {0} customer is?", i);
                dm[i] = new DrinksMachine(Console.ReadLine());
            }

            for (int j = 0; j < nameList; j++)
            {
                Console.WriteLine("The name of the {0} customer is {1}.", j, dm[j].customer);
            }

            Console.ReadLine();
        }
    }
    class DrinksMachine
    {
        public string customer { get; set; }
        public string drinks { get; set; }
        public int number { get; set; }
        //constructor
        internal DrinksMachine(string customer = "Tom", string drinks = "coffee", int number = 1)
        {
            this.customer = customer;
            this.drinks = drinks;
            this.number = number;
        }
        ///method
        internal Boolean namelen(string name)
        {
            if (name.Length > 4) return true;
            else return false;
        }

    }
}
