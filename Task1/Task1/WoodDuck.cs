using System;
using System.Collections.Generic;
using System.Text;
using Task1.Swim;

namespace Task1
{
    class WoodDuck : Duck
    {
        public WoodDuck()
            :base(new NoFly(), new NoQuack(), new NotSwimable())
        { }

        public override void Display()
        {
            Console.WriteLine("Wood duck");
            base.Display();
        }
    }
}
