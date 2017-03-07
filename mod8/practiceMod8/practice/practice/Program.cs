using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region GenericListDemo
            //List<string> coffeeList = new List<string>();

            //coffeeList.Add("BlueMountain"); 
            //coffeeList.Add("WhiteCoffee");
            //coffeeList.Add("WeaselCoffee");
            //foreach (string coff in coffeeList)
            //{
            //    Console.WriteLine("Coffee Name: {0}", coff);
            //}
            //coffeeList.Sort();

            //foreach (string coff in coffeeList)
            //{
            //    Console.WriteLine("Coffee Name: {0}", coff);
            //}
            
            //Console.WriteLine("The first coffee in the list is {0}.", coffeeList[0]);
            ////Console.WriteLine("The third coffee in the list is {1}.", coffeeList[1]);
            //Console.ReadLine();
            //#endregion

            #region GenericQueueDemo
            Queue<Coffee> coffeeQueue = new Queue<Coffee>();
            Coffee BlueMountain = new Coffee("BlueMountain", 2);
            Coffee WhiteCoffee = new Coffee("WhiteCoffee", 3);
            Coffee WeaselCoffee = new Coffee("WeaselCoffee", 4);
            coffeeQueue.Enqueue(BlueMountain);
            coffeeQueue.Enqueue(WhiteCoffee);
            coffeeQueue.Enqueue(WeaselCoffee);

            Console.WriteLine("{0}",coffeeQueue.Peek().Name);
            Console.ReadLine();

            //Console.WriteLine("Dequeueing: {0}", coffeeQueue.Dequeue().Name);
            //Console.WriteLine("The next coffee to be dequeued: {0}", coffeeQueue.Peek().Name);
            //Console.WriteLine("Dequeueing: {0}", coffeeQueue.Dequeue().Name);

            //foreach (Coffee coff in coffeeQueue)
            //{
            //    Console.WriteLine("The coffee remaining in the queue is {0}",coff.Name);
            //}
            
            //Console.ReadLine();
            #endregion

            //#region GenericDictionaryDemo
            //Dictionary<string, int> coffeeDictionary = new Dictionary<string, int>();
            //for (int i = 0; i < 3; i++)
            //{
            //    var current = coffeeQueue.Peek();
            //    coffeeDictionary.Add(current.Name, current.Strength);
            //    coffeeQueue.Dequeue();   
            //}
            //Console.WriteLine("The strength of BlueMountain is [0].", coffeeDictionary["WhiteCoffee"]); //need indexer to enable dictionary output??
            //Console.ReadLine();            

            //#endregion


        }
    }
    //class CustomList<T>
    //{
    //    public T this[int index] { get; set; }
    //    public void Add(T item)
    //    {
    //        // Do Sth
    //    }
    //    public void Remove(T item)
    //    { 
    //        //Do Sth
    //    }
    //}
    class Coffee
    {
        public string Name { get; set; }
        public int Strength { get; set; }

        public Coffee(string name, int strength)
        {
            Name = name;
            Strength = strength;
        }
    }
}
