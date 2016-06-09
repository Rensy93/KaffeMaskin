using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barista3000
{
    /// <summary>
    /// Choco container
    /// </summary>
    public class ChocoContainer : Container
    {
        /// <summary>
        /// Initiates container
        /// </summary>
        /// <param name="level">Init level</param>
        public ChocoContainer(int level)
        {
            base.Level = level;
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
                throw new EmptyContainerException("Not enough choco.");
            }
        }
    }
}
