using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barista3000
{
    /// <summary>
    /// Café au lait
    /// </summary>
    class CafeAuLait : HotDrink
    {
        /// <summary>
        /// Make café au lait
        /// </summary>
        public override string Make()
        {
            containers["coffee"].GetContent();
            containers["water"].GetContent();
            HeatWater();
            containers["milk"].GetContent();
            return String.Format("Café au lait coming up... Putti putti putt... Beep!");
        }
    }
}
