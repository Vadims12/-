using System;
using System.Collections.Generic;
using System.Text;

namespace Task3_Decorator_.Coffee
{
    class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf";
        }
        public override double Cost()
        {
            return 0.99;
        }
    }
}
