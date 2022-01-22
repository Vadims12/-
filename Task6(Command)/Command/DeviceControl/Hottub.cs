using System;
using System.Collections.Generic;
using System.Text;

namespace Command.DeviceControl
{
    public class Hottub
    {
        public void Circulate()
        {
            Console.WriteLine("Hottub: Circulating...");
        }

        public void JetsOn()
        {
            Console.WriteLine("Hottub: Jets on.");
        }
        public void JetsOff()
        {
            Console.WriteLine("Hottub: Jets off.");
        }

        public void SetTemperature(int value)
        {
            Console.WriteLine($"Hottub: Water temperature now is: {value}");
        }
    }
}
