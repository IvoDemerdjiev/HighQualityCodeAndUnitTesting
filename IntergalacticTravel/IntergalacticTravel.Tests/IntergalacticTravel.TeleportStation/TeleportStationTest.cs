namespace IntergalacticTravel.Tests.IntergalacticTravel.TeleportStation
{
    using System;

    using NUnit.Framework;
    using Moq;
    using IntergalacticTravel;
    using IntergalacticTrave;

    public class TeleportStationTest
    {
        public void ConstructorWorkingCorrectly()
        {
            var Teleportstation = new TeleportStationMock(); 
            Assert.IsNotNull(Teleportstation);
        }
    }
}
