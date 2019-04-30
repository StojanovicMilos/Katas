using System;

namespace GossipingBusDrivers.BL
{
    public class BusRoute
    {
        private readonly Station[] _stations;
        private int _currentStation;

        public Station CurrentStation => _stations[_currentStation];

        public BusRoute(Station[] stations)
        {
            _stations = stations ?? throw new ArgumentNullException(nameof(stations));
            if (stations.Length == 0) throw new ArgumentException("Value cannot be an empty collection.", nameof(stations));
            _currentStation = 0;
        }
        
        public void MoveNext() => _currentStation = (_currentStation + 1) % _stations.Length;
    }
}
