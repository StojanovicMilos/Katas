using System;
using System.Collections.Generic;
using System.Linq;

namespace GossipingBusDrivers.BL
{
    public class BusDriver
    {
        private readonly Gossips _gossips;
        private readonly BusRoute _busRoute;

        public BusDriver(Gossips gossips, BusRoute busRoute)
        {
            _gossips = gossips ?? throw new ArgumentNullException(nameof(gossips));
            _busRoute = busRoute ?? throw new ArgumentNullException(nameof(busRoute));
        }

        public Station CurrentStation => _busRoute.CurrentStation;

        public void Drive() => _busRoute.MoveNext();

        public int GossipsCount => _gossips.Count();

        public void Gossip(IEnumerable<BusDriver> busDrivers)
        {
            if (busDrivers == null) throw new ArgumentNullException(nameof(busDrivers));
            foreach (var otherBusDriver in busDrivers)
            {
                GossipToDriver(otherBusDriver);
            }
        }

        private void GossipToDriver(BusDriver otherBusDriver)
        {
            if (otherBusDriver == null) throw new ArgumentNullException(nameof(otherBusDriver));
            otherBusDriver._gossips.Add(_gossips);
        }
    }
}
