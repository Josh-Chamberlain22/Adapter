//Implements Bear functions.
using System;
using System.Collections.Generic;
using System.Text;
//Implements Bear functions.
namespace Adapter_Pattern
{
    //Allows the Grizzly to hibernate and maul.
    interface Bear
    {
        //Shows user the bear is hibernating
        void hibernate();
        //Shows user the bear is mauling someone to death
        void maul();
    }
    //Implements hibernate and maul
    class Grizzly : Bear
    {
        void Bear.hibernate()
        {
            Console.WriteLine("The bear is hibernating");
        }
        void Bear.maul()
        {
            Console.WriteLine("The bear is mauling someone to death.");
        }
    }
}
