using System;
using System.Collections.Generic;
using System.Text;

namespace Task3_Decorator_
{
    abstract class Beverage
    {
        protected string description = "Unknown beverage";

        public string GetDescription()
        {
            return description;
        }

        public abstract double Cost();
    }
}
