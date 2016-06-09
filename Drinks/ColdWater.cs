using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barista3000
{
    /// <summary>
    /// Cold water
    /// </summary>
    class ColdWater : ColdDrink
    {
        /// <summary>
        /// Make drink
        /// </summary>
        public override string Make()
        {
            containers["water"].GetContent();
            return String.Format("Cold water coming up... Drop drip drop... Beep!");
        }
    }
}
