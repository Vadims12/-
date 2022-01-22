using System;

namespace Command.DeviceControl
{
    public class SecurityControl
    {
        public void Arm()
        {
            Console.WriteLine("Security control: armed.");
        }

        public void Disarm()
        {
            Console.WriteLine("Security control: disarmed.");
        }
    }
}