using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.Swim
{
    class Swimable : ISwimable
    {
        public void Swim()
        {
            Console.WriteLine("Этот объект/существо плавает");
        }
    }
}
