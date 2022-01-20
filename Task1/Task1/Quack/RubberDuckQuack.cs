using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class RubberDuckQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Резиновая уточка крякает!");
        }
    }
}
