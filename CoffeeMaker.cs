using System.Collections.Generic;

namespace Barista3000
{
    /// <summary>
    /// Coffee maker 
    /// </summary>
    public class CoffeeMaker
    {
        private Dictionary<string, Container> containers;

        /// <summary>
        /// Initiates coffee maker
        /// </summary>
        public CoffeeMaker()
        {
            // Create containers
            containers = new Dictionary<string, Container>();
            containers.Add("water", new WaterContainer(15));
            containers.Add("coffee", new CoffeeContainer(20));
            containers.Add("choco", new ChocoContainer(10));
            containers.Add("milk", new MilkContainer(10));
            containers.Add("sugar", new SugarContainer(10));
        }

        /// <summary>
        /// Make drink
        /// </summary>
        /// <param name="drink">Selected drink</param>
        public string MakeDrink(Drink drink)
        {
            drink.Containers = containers;
            return drink.Make();
        }

    }
}
