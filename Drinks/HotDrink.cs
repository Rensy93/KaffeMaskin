using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barista3000
{
    /// <summary>
    /// Hot drink (partial implementation)
    /// </summary>
    public abstract class HotDrink : Drink
    {
        /// <summary>
        /// Make drink (no implementation)
        /// </summary>
        public override abstract string Make();

        /// <summary>
        /// Heats water
        /// </summary>
        /// <returns>True if heating successful, otherwise false</returns>
        protected bool HeatWater()
        {
            // Simulate successful result
            return true;
        }
    }
}
