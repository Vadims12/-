using System;
using System.Collections.Generic;
using System.Text;
using Task1.Swim;

namespace Task1
{
    class RubberDuck : Duck
    {
        public RubberDuck()
            :base(new NoFly(), new RubberDuckQuack(), new Swimable())
        { }

        public override void Display()
        {
            Console.WriteLine("Rubber duck:");
            base.Display();
        }
    }
}
