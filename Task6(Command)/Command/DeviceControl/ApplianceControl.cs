using System;
using System.Threading.Channels;

namespace Command.DeviceControl
{
    public class ApplianceControl
    {
        public void On()
        {
            Console.WriteLine("Контроль бытовой техники включен.");
        }

        public void Off()
        {
            Console.WriteLine("Контроль бытовой техники выключен.");
        }
    }
}