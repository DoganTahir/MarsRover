using RoverMars.Source.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;


namespace RoverMars.Source
{
    public class RoverPosition : IRoverPosition
    {
        Plateu plateu = new Plateu();
        public int roverX { get; set; }
        public int roverY { get; set; }
        public Directions roverDirection { get; set; }

        public enum Directions
        {
            N,
            S,
            E,
            W
        }


        public void AddRover(int x, int y, string direction)
        {        
            roverX = x;
            roverY = y;
            roverDirection = (Directions)Enum.Parse(typeof(Directions), direction);
        }

        private void TurnLeft()
        {
            switch (roverDirection)
            {
                case Directions.N:
                    roverDirection = Directions.W;
                    break;
                case Directions.S:
                    roverDirection = Directions.E;
                    break;
                case Directions.E:
                    roverDirection = Directions.N;
                    break;
                case Directions.W:
                    roverDirection = Directions.S;
                    break;
                default:
                    break;
            }
        }
        private void TurnRight()
        {
            switch (roverDirection)
            {
                case Directions.N:
                    roverDirection = Directions.E;
                    break;
                case Directions.S:
                    roverDirection = Directions.W;
                    break;
                case Directions.E:
                    roverDirection = Directions.S;
                    break;
                case Directions.W:
                    roverDirection = Directions.N;
                    break;
                default:
                    break;
            }
        }
        private void Forward()
        {
            switch (roverDirection)
            {
                case Directions.N:
                    this.roverY += 1;
                    break;
                case Directions.S:
                    this.roverY -= 1;
                    break;
                case Directions.E:
                    this.roverX += 1;
                    break;
                case Directions.W:
                    this.roverX -= 1;
                    break;
                default:
                    break;
            }
        }

        public void SendCommand(string roverDirections)
        {         
            char[] directions = roverDirections.ToCharArray();
            var result = string.Format("{0} {1} {2}", roverX, roverY, roverDirection);
            foreach (var direction in directions)
            {
                switch (direction)
                {
                    case 'M':
                        this.Forward();
                        break;
                    case 'R':
                        this.TurnRight();
                        break;
                    case 'L':
                        this.TurnLeft();
                        break;
                    default:
                        break;
                }
                result = string.Format("{0} {1} {2}", roverX, roverY, roverDirection);
                if (roverX < 0 || roverY< 0 )
                {
                    throw new RoverExceptions("roveX and roverY must be greater than zero");
                }
            }
            plateu.Results.Add(result);
        }
        public void GetFinalPositions()
        {
            foreach (var result in plateu.Results)
            {
                Console.WriteLine(result);
            }
        }
    }
}

