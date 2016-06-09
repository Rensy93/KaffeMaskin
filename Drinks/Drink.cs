using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barista3000
{
    /// <summary>
    /// Drink (partial implementation)
    /// </summary>
    public abstract class Drink
    {
        // Ingredients
        protected Dictionary<string, Container> containers;

        // Property for setting the containers reference
        public Dictionary<string, Container> Containers
        {
            set
            {
                containers = value;
            }
        }

        /// <summary>
        /// Make drink (no implementation)
        /// </summary>
        public abstract string Make();
    }
}
