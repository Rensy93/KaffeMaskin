namespace Barista3000
{
    /// <summary>
    /// Represents a container used for storing
    /// coffee, water, milk etc.
    /// </summary>
   public abstract class Container
    {
        // Minimum threshold value indicating when a container is empty
        protected const int MIN_CONTAINER_THRESHOLD = 1;

        // Current container level
        protected int containerLevel;        

        /// <summary>
        /// Container level (get/set)
        /// </summary>
        public int Level
        {
            get
            {
                return containerLevel;
            }
            set
            {
                containerLevel = value;
            }
        }

        /// <summary>
        /// Returns whether the chosen container has content
        /// </summary>
        /// <returns>True if there is content, otherwise false</returns>
        public bool HasContent()
        {
            return Level > MIN_CONTAINER_THRESHOLD;
        }

        /// <summary>
        /// Get content from container (no implementation)
        /// </summary>
        public abstract void GetContent();
    }
}
