using System;

namespace Command.DeviceControl
{
    public class Light
    {
        public void On()
        {
            Console.WriteLine("Свет включён.");
        }

        public void Off()
        {
            Console.WriteLine("Свет выключен.");
        }
    }
}