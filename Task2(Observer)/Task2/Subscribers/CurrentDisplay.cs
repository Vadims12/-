using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Publisher;

namespace Task2.Subscribers
{
    public class CurrentDisplay : ISubscriber
    {
        public CurrentDisplay(IPublisher publisher)
        {
            publisher.Notify += this.GetNotify;
        }

        public void GetNotify(double t, double p, double h)
        {
            Console.WriteLine("-----АКТУАЛЬНАЯ ИНФОРМАЦИЯ:-----");
            Console.WriteLine($"Температура: {t} град. Цельсия");
            Console.WriteLine($"Давление: {p} мм.рт.ст");
            Console.WriteLine($"Влажность воздуха: {h} %");
        }
    }
}
