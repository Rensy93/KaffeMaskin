using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barista3000
{
    /// <summary>
    /// Sugar container
    /// </summary>
    public class SugarContainer : Container
    {
        /// <summary>
        /// Initiates container
        /// </summary>
        /// <param name="level">Init level</param>
        public SugarContainer(int level)
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
                throw new EmptyContainerException("Not enough sugar.");
            }
        }
    }
}
