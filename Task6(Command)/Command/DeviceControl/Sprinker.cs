using System;
using System.Collections.Generic;
using System.Text;

namespace Command.DeviceControl
{
    public class Sprinker
    {
        public void WaterOn()
        {
            Console.WriteLine("Вода включена.");
        }

        public void WaterOff()
        {
            Console.WriteLine("Вода выключена.");
        }
    }
}
