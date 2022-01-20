using System;
using System.Collections.Generic;
using System.Text;

namespace Command.DeviceControl
{
    public class Stereo
    {
        public void On()
        {
            Console.WriteLine("Стерео включено.");
        }

        public void Off()
        {
            Console.WriteLine("Стерео выключено.");
        }

        public void SetCd()
        {
            Console.WriteLine("Режим 'CD' включён. ");
        }

        public void SetDvd()
        {
            Console.WriteLine("Режим 'DVD' включён. ");
        }

        public void SetRadio()
        {
            Console.WriteLine("Режим 'Radio' включён. ");
        }

        public void SetVolume(int value)
        {
            Console.WriteLine($"Выставлена громкость {value}. ");
        }
    }
}
