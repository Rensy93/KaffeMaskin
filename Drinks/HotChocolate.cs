using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barista3000
{
    /// <summary>
    /// Hot chocolate
    /// </summary>
    public class HotChocolate : HotDrink
    {
        /// <summary>
        /// Make drink
        /// </summary>
        public override string Make()
        {
            containers["choco"].GetContent();
            containers["water"].GetContent();
            HeatWater();
            return String.Format("Hot chocolate coming up... Putti putti putt... Beep!");
        }
    }
}
