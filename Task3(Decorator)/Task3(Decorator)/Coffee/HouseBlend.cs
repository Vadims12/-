using System;
using System.Collections.Generic;
using System.Text;

namespace Task3_Decorator_.Coffee
{
    class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend";
        }
        public override double Cost()
        {
            return 0.89;
        }
    }
}
