using RoverMars.Source;
using RoverMars.Source.Exceptions;
using RoverMars.Source.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoverMars
{
    public class Plateu
    {
        public int XMin{ get; set; }
        public int XMax { get; set; }
        public int YMin{ get; set; }
        public int YMax { get; set; }
        public List<string> Results { get; set; }


        public Plateu(int xMax, int yMax)
        {
            XMin = 0;
            XMin = 0;
            XMax = xMax;
            YMax = yMax;
            if(XMax<0||YMax<0)
            {
                throw new PlateauExceptions("x and y must be greater than zero");
            }
        }
        public Plateu()
        {
            Results = new List<string>();
        }

    }
}
