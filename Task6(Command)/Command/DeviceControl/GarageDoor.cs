using System;

namespace Command.DeviceControl
{
    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Дверь в гараже поднята.");
        }

        public void Down()
        {
            Console.WriteLine("Дверь в гараже отпущена.");
        }

        public void Stop()
        {
            Console.WriteLine("Дверь остановлена в данном положениию.");
        }

        public void LightOn()
        {
            Console.WriteLine("Свет в гараже был включён.");
        }

        public void LightOff()
        {
            Console.WriteLine("Свет в гараже выключен.");
        }
    }
}