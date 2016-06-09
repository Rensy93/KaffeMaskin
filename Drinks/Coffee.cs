using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barista3000
{
    /// <summary>
    /// Coffee
    /// </summary>
    public class Coffee : HotDrink
    {
        private bool milk;
        private bool sugar;

        /// <summary>
        /// Coffee without milk and sugar by default
        /// </summary>
        public Coffee()
        {
            this.milk = false;
            this.sugar = false;
        }

        /// <summary>
        /// Coffee with milk and/or sugar
        /// </summary>
        /// <param name="milk">Whether to add milk</param>
        /// <param name="sugar">Whether to add sugar</param>
        public Coffee(bool milk, bool sugar)
        {
            this.milk = milk;
            this.sugar = sugar;
        }

        /// <summary>
        /// Make coffee
        /// </summary>
        public override string Make()
        {
            string message = "Coffee ";

            containers["coffee"].GetContent();
            containers["water"].GetContent();
            HeatWater();

            if (milk)
            {
                containers["milk"].GetContent();
                message += "with milk ";
            }

            if (sugar)
            {
                containers["sugar"].GetContent();
                message += "with sugar ";
            }

            message += "coming up... Putti putti putt... Beep!";

            return message;
        }
    }
}
