using System;
using System.Collections.Generic;
using System.Text;
using Task1.Swim;

namespace Task1
{
    class MallardDuck : Duck
    {
        public MallardDuck()
            : base(new FlyingWithWings(), new DuckQuack(), new Swimable())
        { }
        public override void Display()
        {
            Console.WriteLine("Mallard Duck:");
            base.Display();
        }
    }
}
