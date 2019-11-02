using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GossipingBusDrivers.BL
{
    public static class GossipingBusDriversInputReader
    {
        public static BusDrivers ReadDriversFrom(string fileName)
        {
            if (fileName == null) throw new ArgumentNullException(nameof(fileName));
            return new BusDrivers(
                (from line in File.ReadAllLines(fileName)
                    select line.Split(' ').Where(s => !string.IsNullOrWhiteSpace(s))
                    into stationIds
                    select new BusDriver(
                        new Gossips(new HashSet<Gossip>(new List<Gossip> {new Gossip()})),
                        new BusRoute(stationIds.Select(id => Station.CreateStation(int.Parse(id))).ToArray()))
                ).ToArray());
        }
    }
}
