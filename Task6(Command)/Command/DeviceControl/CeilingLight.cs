using System;

namespace Command.DeviceControl
{
    public class CeilingLight
    {
        public void On()
        {
            Console.WriteLine("светильник включен.");
        }

        public void Off()
        {
            Console.WriteLine("Светильник выключен.");
        }

        public void Dim()
        {
            Console.WriteLine("Светильник включен в тусклом режиме.");
        }
    }
}