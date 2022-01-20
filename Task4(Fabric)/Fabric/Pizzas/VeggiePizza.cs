using Fabric.IngredientFactory;

namespace Fabric.Pizzas
{
    class VeggiePizza : Pizza
    {
        public IPizzaIngredientFactory Factory { get; }

        public VeggiePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.Factory = ingredientFactory;
        }
        public override void Prepare()
        {
            Name = "Veggie Pizza";
            Dough = Factory.CreateDough();
            Sauce = Factory.CreateSauce();
            Veggies = Factory.CreateVeggies();
        }
    }
}
