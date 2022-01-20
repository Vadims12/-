using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class NoFly : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Данный объект/существо не имеет возможности летать");
        }
    }
}
