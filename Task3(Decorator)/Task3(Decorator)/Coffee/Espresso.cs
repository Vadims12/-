using System;
using System.Collections.Generic;
using System.Text;

namespace Task3_Decorator_.Coffee
{
    class Espresso : Beverage
    {
        public Espresso()
        {
             description = "Espresso";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}
