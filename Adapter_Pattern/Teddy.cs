//Description: Implements ToyBear functions.
using System;
using System.Collections.Generic;
using System.Text;
namespace Adapter_Pattern
{
    //Allows a TeddyBear to hug
    interface ToyBear
    {
        void hug();
    }
    //Implements hug
    class TeddyBear : ToyBear
    {
        //Shows user the TeddyBear is hugging
        void ToyBear.hug()
        {
            Console.WriteLine("The teddy bear is hugging someone to death");
        }
    }
}
