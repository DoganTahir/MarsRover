using System;
using System.Collections.Generic;
using System.Text;

namespace RoverMars.Source.Exceptions
{
    public class RoverExceptions:Exception
    {

        /// <summary>
        /// creates exception with the description message
        /// </summary>
        /// <param name="message">exception message</param>
        public RoverExceptions(string message) : base(message)
        {

        }
    }
}
