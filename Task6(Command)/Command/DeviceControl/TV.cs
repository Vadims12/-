using System;

namespace Command.DeviceControl
{
    public class TV
    {
        public void On()
        {
            Console.WriteLine("Телевизор включён.");
        }

        public void Off()
        {
            Console.WriteLine("Телевизор выключен.");
        }

        public void SetInputChannel(int channelNumber)
        {
            Console.WriteLine($"Канал номер {channelNumber} включён.");
        }

        public void SetVolume(int volumeValue)
        {
            Console.WriteLine($"Выставлена громкость {volumeValue}.");
        }
    }
}