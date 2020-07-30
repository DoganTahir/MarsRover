using System;
using System.Collections.Generic;
using System.Text;

namespace RoverMars.Source.Exceptions
{
    public class PlateauExceptions:Exception
    {
        /// <summary>
        /// creates exception with the description message
        /// </summary>
        /// <param name="message">exception message</param>
        public PlateauExceptions(string message) : base(message)
        {

        }
    }
    }
