using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Pattern
{   
    class BearAdapter : ToyBear
    {
        Bear bear;
        public BearAdapter(Bear b)
        {
            bear = b;
        }
        void ToyBear.hug()
        {
            bear.maul();
        }
    }
}
