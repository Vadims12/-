using System;

namespace Singleton
{
    class Program
    {
        static void Main()
        {
            ChocolateBoiler chocolateBoiler = ChocolateBoiler.GetBoiler();
            chocolateBoiler.Fill();
            chocolateBoiler.Boil();
            chocolateBoiler.Drain();
        }
    }
}
