using Fabric.IngredientFactory;

namespace Fabric.Pizzas
{
    class PepperoniPizza : Pizza
    {
        public IPizzaIngredientFactory Factory { get; }
        public PepperoniPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.Factory = ingredientFactory;
        }

        public override void Prepare()
        {
            Dough = Factory.CreateDough();
            Sauce = Factory.CreateSauce();
            Pepperoni = Factory.CreatePepperoni();
        }
    }
}
