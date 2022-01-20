using System;
using System.Collections.Generic;
using System.Text;

namespace Task3_Decorator_.Condiments
{
    class Mocha : CondimentDecorator
    {
        private protected Beverage beverageDecorateTo;
        public Mocha(Beverage beverage)
        {
            this.beverageDecorateTo = beverage;
            this.description = beverageDecorateTo.GetDescription() + " + Mocha";
        }

        public override string GetDescription()
        {
            return this.description;
        }

        public override double Cost()
        {
            return beverageDecorateTo.Cost() + 0.20;
        }
    }
}
