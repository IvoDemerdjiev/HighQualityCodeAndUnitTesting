using System;
using System.Collections.Generic;
using IntergalacticTravel;
using IntergalacticTravel.Contracts;

namespace IntergalacticTravel.Tests.IntergalacticTrave
{
    public class TeleportStationMock : TeleportStation
    {
        public TeleportStationMock(IBusinessOwner owner, IEnumerable<IPath> galacticMap, ILocation location) : 
            base(owner, galacticMap, location)
        {
        }
    }
}
