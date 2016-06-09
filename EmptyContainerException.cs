using System;

namespace Barista3000
{
    /// <summary>
    /// EmptyContainerException is thrown when the container 
    /// level has reached the minimum threshold value
    /// </summary>
    public class EmptyContainerException : Exception
    {
        private string message;

        public EmptyContainerException(string msgText) : base(msgText)
        {
            message = msgText;
        }
    }
}
