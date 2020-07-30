using RoverMars.Source;
using System;

namespace RoverMars
{
    class Program
    {
        static void Main(string[] args)
        {
            var plateau = new Plateu(5, 5);
            RoverPosition roverPosition = new RoverPosition();
            roverPosition.AddRover(1, 2, "N");
            roverPosition.SendCommand("LMLMLMLMM");
            roverPosition.AddRover(3, 3, "E");
            roverPosition.SendCommand("MMRMMRMRRM");
            roverPosition.GetFinalPositions();
        }
    }
}
