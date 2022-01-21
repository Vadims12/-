using System;
using System.Collections.Generic;
using System.Text;

namespace Task3_Decorator_
{
    public abstract class Beverage
    {
        protected string description = "";
        public abstract double Cost();

        public string GetDescription()
        {
            return description;
        }
    }
}
