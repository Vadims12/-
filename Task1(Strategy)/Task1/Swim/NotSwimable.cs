using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.Swim
{
    class NotSwimable : ISwimable
    {
        public void Swim()
        {
            Console.WriteLine("Данный объект/существо не плавает");
        }
    }
}
