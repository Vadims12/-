using System;
using System.Collections.Generic;
using System.Text;

namespace Command.DeviceControl
{
    public class GardenLight
    {
        public void SetDuskTime(int hour, int minutes)
        {
            Console.WriteLine($"Время выключения освещения в саду: {hour} ч. {minutes} мин.");
        }

        public void SetDawnTime(int hour, int minutes)
        {
            Console.WriteLine($"Время включения освещения в саду: {hour} ч. {minutes} мин.");
        }

        public void ManualOn()
        {
            Console.WriteLine("Освещение включено вручную.");
        }

        public void ManualOff()
        {
            Console.WriteLine("Освещение выключено вручную.");
        }
    }
}
