using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barista3000
{
    public class CoffeeStrengthEstimator
    {
        /// <summary>
        /// Estimates the strength of the coffee (how many beans to use) depending on the button pressed
        /// </summary>
        /// <param name="buttonPressed"> The numeral position of the button pressed</param>
        /// <returns>An enum value indicating the estimated coffee strength</returns>
        public CoffeeStrength EstimateCoffeeStrength(int buttonPressed) {
            if (buttonPressed == 1) {
                return CoffeeStrength.Light;
            }
            else if (buttonPressed == 2)
            {
                return CoffeeStrength.Medium;
            }
            else if (buttonPressed == 3)
            {
                return CoffeeStrength.Strong;
            }
            else {
                throw new ArgumentException("Ogiltig knappinmatning, var god försök igen");
            }
        } 
    }

    public enum CoffeeStrength{
        Light,
        Medium,
        Strong
    }
}
