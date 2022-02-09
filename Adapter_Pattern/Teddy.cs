using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Pattern
{
    interface ToyBear
    {
        void hug();
    }
    class TeddyBear : ToyBear
    {
        void ToyBear.hug()
        {
            Console.WriteLine("The teddy bear is hugging someone to death");
        }
    }
}
