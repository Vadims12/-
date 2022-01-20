using Fabric.IngredientFactory;

namespace Fabric.Pizzas
{
    class CheesePizza : Pizza
    {
        public IPizzaIngredientFactory Factory { get; }

        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.Factory = ingredientFactory;
        }
        public override void Prepare()
        {
            Name = "Cheese Pizza";
            Dough = Factory.CreateDough();
            Sauce = Factory.CreateSauce();
            Cheese = Factory.CreateCheese();
        }
    }
}
