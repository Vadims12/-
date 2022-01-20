using System;
using System.Collections.Generic;
using System.Text;

namespace Task3_Decorator_.Coffee
{
    class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roast";
        }

        public override double Cost()
        {
            return 0.99;
        }
    }
}
