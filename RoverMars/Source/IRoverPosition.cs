using System;
using System.Collections.Generic;
using System.Text;

namespace RoverMars.Source
{
    public interface IRoverPosition
    {
        void AddRover(int x, int y, string direction);
        void SendCommand(string roverDirections);
    }
}
