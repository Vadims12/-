using System;
using Task3_Decorator_.Coffee;
using Task3_Decorator_.Condiments;

namespace Task3_Decorator_
{
    class Program
    {
        static void Main()
        {
            // Эспрессо с соей и двойной порцией взбитых сливок
            Beverage espresso = new Espresso();
            espresso = new Soy(espresso);
            espresso = new Whip(espresso);
            espresso = new Whip(espresso);
            Console.WriteLine($"ИТОГО: {espresso.GetDescription()} - {espresso.Cost()}");

            // Dark Roast с молоком и шоколадом
            Beverage darkRoast = new DarkRoast();
            darkRoast = new Milk(darkRoast);
            darkRoast = new Mocha(darkRoast);
            Console.WriteLine($"ИТОГО: {darkRoast.GetDescription()} - {darkRoast.Cost()}");
        }
    }
}
