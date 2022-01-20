using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class NoQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Данный объект / данное существо не крякает");
        }
    }
}
