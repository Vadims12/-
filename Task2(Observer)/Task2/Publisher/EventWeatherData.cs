using System;
using System.Collections.Generic;
using System.Text;
using Task2.Subscribers;

namespace Task2.Publisher
{
    public delegate void WeatherPublisherHandler(double temp, double humidity, double pressure);
    class EventWeatherData : IPublisher
    {
        private readonly Random rand = new Random();

        public event WeatherPublisherHandler Notify;

        public void NotifySubs()
        {
            Notify.Invoke(GetTemperature(), GetPressure(), GetHumidity());
        }

        public double GetTemperature()
        {
            double t = rand.Next(0, 40);
            return t;
        }

        public double GetPressure()
        {
            double p = rand.Next(600, 800); // среднее значение давления
            return p;
        }

        public double GetHumidity()
        {
            double h = rand.Next(30, 60); // средняя влажность воздуха в процентах
            return h;
        }
    }
}
