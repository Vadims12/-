using System;
using Task2.Publisher;
using Task2.Subscribers;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            EventWeatherData eventWeatherData = new EventWeatherData();
            CurrentDisplay display1 = new CurrentDisplay(eventWeatherData);
            StatisticsDisplay display2 = new StatisticsDisplay(eventWeatherData);
            eventWeatherData.NotifySubs();
        }
    }
}
