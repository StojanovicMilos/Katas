using System;
using System.Collections.Generic;
using System.Linq;

namespace GossipingBusDrivers.BL
{
    public sealed class Station : IEquatable<Station>
    {
        private readonly int _id;

        private static readonly HashSet<Station> AllStations = new HashSet<Station>();

        public static Station CreateStation(int id)
        {
            if (id < 0) throw new ArgumentOutOfRangeException(nameof(id));
            var newStation = new Station(id);
            if (AllStations.Contains(newStation))
                return AllStations.First(s => s.Equals(newStation));
            AllStations.Add(newStation);
            return newStation;
        }

        private Station(int id)
        {
            if (id < 0) throw new ArgumentOutOfRangeException(nameof(id));
            _id = id;
        }

        public override bool Equals(object obj) => Equals(obj as Station);

        public bool Equals(Station other) => _id == other?._id;

        public static bool operator ==(Station oneStation, Station otherStation) => oneStation?.Equals(otherStation) == true;

        public static bool operator !=(Station oneStation, Station otherStation) => !(oneStation == otherStation);

        public override int GetHashCode() => _id;
    }
}