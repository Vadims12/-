using System.Collections.Generic;
using Fabric.Cheese;
using Fabric.Clams;
using Fabric.Dough;
using Fabric.Pepperoni;
using Fabric.Sauce;
using Fabric.Veggies;

namespace Fabric.IngredientFactory
{
    class BenderyPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public ICheese CreateCheese()
        {
            return new MozarellaCheese();
        }

        public IClams CreateClams()
        {
            return new FreshClams();
        }
        public IPepperoni CreatePepperoni()
        {
            return new NonSlicedPepperoni();
        }

        public List<IVeggie> CreateVeggies()
        {
            return new List<IVeggie>() {new BellPeper(), new Onion()};
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }
    }
}
