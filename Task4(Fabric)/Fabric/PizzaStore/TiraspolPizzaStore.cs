using Fabric.Pizzas;
using System;
using Fabric.IngredientFactory;

namespace Fabric.PizzaStore
{
    public class TiraspolPizzaStore : PizzaStore
    {
        public IPizzaIngredientFactory IngredientFactory { get; set; } = new TiraspolPizzaIngredientFactory();

        public override Pizza CreatePizza(string type)
        {
            if (type == "cheese" || type == "Cheese")
            {
                return new CheesePizza(IngredientFactory);
            }
            else if (type == "clam" || type == "Clam")
            {
                return new ClamPizza(IngredientFactory);
            }
            else if (type == "pepperoni" || type == "Pepperoni")
            {
                return new PepperoniPizza(IngredientFactory);
            }
            else if (type == "veggie" || type == "Veggie")
            {
                return new VeggiePizza(IngredientFactory);
            }
            else return null;
        }
    }
}
