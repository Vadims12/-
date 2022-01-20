using System;

namespace Command.DeviceControl
{
    public class CeilingFan
    {
        public readonly int high = 3;
        public readonly int medium = 2;
        public readonly int low = 1;
        public readonly int off = 1;
        public int Speed { get; set; }
        public void High()
        {
            Console.WriteLine("Потолочные вентиляторы работают в сильном режиме.");
            Speed = high;
        }

        public void Medium()
        {
            Console.WriteLine("Потолочные вентиляторы работают в среднем режиме.");
            Speed = medium;
        }

        public void Low()
        {
            Console.WriteLine("Потолочные вентиляторы работают в слабом режиме.");
            Speed = low;
        }

        public void Off()
        {
            Console.WriteLine("Вентилятор выключен.");
            Speed = off;
        }

        public int GetSpeed()
        {
            return Speed;
        }
    }
}