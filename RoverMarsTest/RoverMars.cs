using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoverMars;
using RoverMars.Source;

namespace RoverMarsTest
{
    [TestClass]
    public class RoverMars
    {
        Plateu plateu = new Plateu(5, 5);
        RoverPosition roverPosition = new RoverPosition();

        [TestMethod]
        public void TestMethodRoverLocation()
        {
            roverPosition.AddRover(1, 2, "N");
            Assert.AreEqual(roverPosition.roverX, 1);
            Assert.AreEqual(roverPosition.roverY, 2);
        }

        [TestMethod]
        public void TestMethodRoverMove()
        {
            roverPosition.AddRover(1, 2, "N");
            roverPosition.SendCommand("LMLMLMLMM");
            Assert.AreEqual(roverPosition.roverX, 1);
            Assert.AreEqual(roverPosition.roverY, 3);
        }
    }
}
