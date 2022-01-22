using System;

namespace Command.DeviceControl
{
    public class FaucetControl
    {
        public void Open()
        {
            Console.WriteLine("Кран открыт. Вода течет.");
        }

        public void Close()
        {
            Console.WriteLine("Кран закрыт. Вода не течет.");
        }
    }
}