using Fabric.IngredientFactory;

namespace Fabric.Pizzas
{
    class ClamPizza : Pizza
    {
        public IPizzaIngredientFactory Factory { get; }
        public ClamPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.Factory = ingredientFactory;
        }
        public override void Prepare()
        {
            Name = "Clam Pizza";
            Dough = Factory.CreateDough();
            Sauce = Factory.CreateSauce();
            Clams = Factory.CreateClams();
        }
    }
}
