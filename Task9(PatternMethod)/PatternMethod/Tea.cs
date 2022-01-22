using System;

namespace PatternMethod
{
    public class Tea : CaffeineBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("чай");
        }
        protected override void AddCondiments()
        {
            Console.WriteLine("сахар");
        }
    }
}