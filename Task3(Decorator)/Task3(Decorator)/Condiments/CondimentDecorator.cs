using System;
using System.Collections.Generic;
using System.Text;

namespace Task3_Decorator_.Condiments
{
    abstract class CondimentDecorator : Beverage
    {
        public new abstract string GetDescription();
    }
}
