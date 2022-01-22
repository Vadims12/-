using System;
using System.Collections.Generic;
using System.Text;

namespace Command.DeviceControl
{
    public class Thermostat
    {
        public void SetTemperature(int value)
        {
            Console.WriteLine($"Выставлена температура {value}.");
        }
    }
}
