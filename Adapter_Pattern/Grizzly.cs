using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Pattern
{
    interface Bear
    {
        void hibernate();

        void maul();
    }
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
