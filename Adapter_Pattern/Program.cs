//Name: Joshua Chamberlain
//Date: 02/10/2022
//Description: Test the classes Grizzly, TeddyBear, and BearAdapter and adapter design pattern. 
using System;

namespace Adapter_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Bear Bob = new Grizzly();
            ToyBear Ted = new TeddyBear();
            ToyBear Andrew = new BearAdapter(Bob);
            Console.WriteLine("Grizzly Bob is hibernating");
            Bob.hibernate();
            Console.WriteLine("Grizzly Bob is mauling");
            Bob.maul();
            Console.WriteLine("Teddy Bear Ted is hugging");
            Ted.hug();
            Console.WriteLine("BearAdapter Andrew is mauling");
            Andrew.hug();
        }
    }
    
}
