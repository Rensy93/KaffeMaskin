using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barista3000
{
    /// <summary>
    /// Hot water
    /// </summary>
    public class HotWater : HotDrink
    {
        /// <summary>
        /// Make drink
        /// </summary>
        public override string Make()
        {
            containers["water"].GetContent();
            HeatWater();
            return String.Format("Hot water coming up... Putti putti putt... Beep!");
        }
    }
}
