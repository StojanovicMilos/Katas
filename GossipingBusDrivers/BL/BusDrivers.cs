﻿using System;
using System.Linq;

namespace GossipingBusDrivers.BL
{
    public class BusDrivers
    {
        private readonly BusDriver[] _busDrivers;

        public BusDrivers(BusDriver[] busDrivers)
        {
            _busDrivers = busDrivers ?? throw new ArgumentNullException(nameof(busDrivers));
        }

        public void Drive()
        {
            foreach (var busDriver in _busDrivers)
            {
                busDriver.Drive();
            }
        }

        public bool EveryoneKnowsAllGossips() => _busDrivers.All(bd => bd.GossipsCount == _busDrivers.Length);

        public void Gossip()
        {
            foreach (var busDriversInSameStation in _busDrivers.GroupBy(b => b.CurrentStation))
            {
                foreach (var busDriver in busDriversInSameStation)
                {
                    busDriver.Gossip(busDriversInSameStation);
                }
            }
        }
    }
}