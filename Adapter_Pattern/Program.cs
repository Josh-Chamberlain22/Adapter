using System;

namespace Adapter_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Bear Bob = new Grizzly();
            ToyBear Ted = new TeddyBear();
            BearAdapter Josh = new BearAdapter(Bob);
            Console.WriteLine("Grizzly Bob is hibernating");
            Bob.hibernate();
            Console.WriteLine("Grizzly Bob is mauling");
            Bob.maul();
            Console.WriteLine("Teddy Bear Ted is hugging");
            Ted.hug();
            Console.WriteLine("BearAdapter Josh is mauling");
            
        }
    }
    
}
