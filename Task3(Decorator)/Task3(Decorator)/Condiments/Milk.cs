using System;
using System.Collections.Generic;
using System.Text;

namespace Task3_Decorator_.Condiments
{
    class Milk : CondimentDecorator
    {
        private protected Beverage beverageDecorateTo;
        public Milk(Beverage beverage)
        {
            this.beverageDecorateTo = beverage;
            this.description = beverageDecorateTo.GetDescription() + " + Milk";
        }

        public override string GetDescription()
        {
            return this.description;
        }

        public override double Cost()
        {
            return beverageDecorateTo.Cost() + 0.30;
        }
    }
}
