using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class DuckQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Уточка крякает!");
        }
    }
}
