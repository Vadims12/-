using System;
using Task3_Decorator_.Coffee;
using Task3_Decorator_.Condiments;

namespace Task3_Decorator_
{
    class Program
    {
        static void Main()
        {
         
            Beverage darkRoast = new DarkRoast();
            darkRoast = new Milk(darkRoast);
            darkRoast = new Whip(darkRoast);
            Console.WriteLine($"{darkRoast.GetDescription()}:{darkRoast.Cost()}");
           
            Beverage houseBlend = new HouseBlend();
            houseBlend = new Milk(houseBlend);
            houseBlend = new Mocha(houseBlend);
            Console.WriteLine($"{houseBlend.GetDescription()}:{houseBlend.Cost()}");
      
            Beverage espresso = new Espresso();
            espresso = new Soy(espresso);
            espresso = new Whip(espresso);
            Console.WriteLine($"{espresso.GetDescription()}:{espresso.Cost()}");
            Console.ReadLine();
        }
    }
}
