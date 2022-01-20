using System.Collections.Generic;
using Fabric.Cheese;
using Fabric.Dough;
using Fabric.Clams;
using Fabric.Pepperoni;
using Fabric.Sauce;
using Fabric.Veggies;

namespace Fabric.IngredientFactory
{
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ICheese CreateCheese();
        IClams CreateClams();
        ISauce CreateSauce();
        IPepperoni CreatePepperoni();
        List<IVeggie> CreateVeggies();
    }
}
