using System;
using Fabric.PizzaStore;

namespace Fabric
{
    class Program
    {
        static void Main()
        {
            BenderyPizzaStore benderyPizzaStore = new BenderyPizzaStore();
            var a = benderyPizzaStore.OrderPizza("cheese");
            Console.WriteLine($"{a.Name} is ready");
        }
    }
}
