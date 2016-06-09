using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barista3000
{
    /// <summary>
    /// Sparkling water
    /// </summary>
    public class SparklingWater : ColdDrink
    {
        /// <summary>
        /// Make drink
        /// </summary>
        public override string Make()
        {
            containers["water"].GetContent();
            MakeFizzy();
            return String.Format("Sparkling water coming up... Fizz fizz fizz... Beep!");
        }

        /// <summary>
        /// Makes water fizzy
        /// </summary>
        /// <returns>True if fizzing successful, otherwise false</returns>
        protected bool MakeFizzy()
        {
            // Simulate successful result
            return true;
        }
    }
}
