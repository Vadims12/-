using System;
using Task1.Swim;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            var mallardDuck = new MallardDuck();
            var rubberDuck = new RubberDuck();
            var woodDuck = new WoodDuck();

            Console.WriteLine("Рыжая уточка:");
            mallardDuck.Display();
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Резиновая уточка:");
            rubberDuck.Display();
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Деревянная уточка:");
            woodDuck.Display();
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Попытка убить неубиваемую уточку:");
            rubberDuck.Dead();
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Попытка убить живую уточку:");
            mallardDuck.Dead();
            mallardDuck.Fly();
            mallardDuck.Quack();
            mallardDuck.Swim();
        }
    }
}
