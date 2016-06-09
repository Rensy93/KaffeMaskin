using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barista3000
{
    /// <summary>
    /// Water container
    /// </summary>
    public class WaterContainer : Container
    {
        /// <summary>
        /// Initiates container
        /// </summary>
        /// <param name="level">Init level</param>
        public WaterContainer(int level)
        {
            Level = level;
        }

        /// <summary>
        /// Get content from container
        /// </summary>
        public override void GetContent()
        {
            if (HasContent())
            {
                Level -= 1;
            }
            else
            {
                if (FillUpWater() == false)
                {
                    throw new EmptyContainerException("Not enough water.");
                }
                else
                {
                    Level -= 1;
                }
            }
        }

        /// <summary>
        /// Attempts to fill up the container with water from the tap
        /// </summary>
        /// <returns>True if the operation was successful, otherwise false</returns>
        protected bool FillUpWater()
        {
            WaterTap tap = new WaterTap();

            if (tap.FillUpContainer())
            {
                Level = 5;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
