using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class FlyingWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("*Летит, используя крылья*");
        }
    }
}
