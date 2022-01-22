using System;
using System.IO.Compression;

namespace PatternMethod
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Добавить молока");
            string answer = Console.ReadLine();
            bool userChoice;
            if (answer.ToLower().StartsWith(""))
            {
                userChoice = true;
            }
            else
            {
                userChoice = false;
            }

            Coffee coffee = new Coffee(userChoice);
            Tea tea = new Tea();

            coffee.PrepareRecipe();
            tea.PrepareRecipe();
        }
    }
}
