using System.Collections.Generic;
using Fabric.Cheese;
using Fabric.Clams;
using Fabric.Dough;
using Fabric.Pepperoni;
using Fabric.Sauce;
using Fabric.Veggies;

namespace Fabric.IngredientFactory
{
    class TiraspolPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public IClams CreateClams()
        {
            return new FrozenClams();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public List<IVeggie> CreateVeggies()
        {
            return new List<IVeggie>() {new Cucumber(), new Garlic()};
        }
    }
}
