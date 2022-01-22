using System;

namespace Command.DeviceControl
{
    public class OutdoorLight
    {
        public void On()
        {
            Console.WriteLine("Наружный свет включён.");
        }

        public void Off()
        {
            Console.WriteLine("Наружный свет выключен.");
        }
    }
}