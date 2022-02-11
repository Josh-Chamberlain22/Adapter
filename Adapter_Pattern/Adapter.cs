//Allows for Toybears to adapt to Grizzlies
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Pattern
{   
    //Adapts a ToyBear to a Grizzly.
    class BearAdapter : ToyBear
    {
        Bear bear;
        //Allows a bear to use Grizzly functions.
        public BearAdapter(Bear b)
        {
            bear = b;
        }
        //Allows the BearAdapter to maul
        void ToyBear.hug()
        {
            bear.maul();
        }
    }
}
