using System;

namespace GossipingBusDrivers.BL
{
    public sealed class Gossip : IEquatable<Gossip>
    {
        private static int _maxId;

        private readonly int _id;

        public Gossip()
        {
            _id = _maxId++;
        }

        public override bool Equals(object obj) => Equals(obj as Gossip);

        public bool Equals(Gossip other) => _id == other?._id;

        public static bool operator ==(Gossip oneGossip, Gossip otherGossip) => oneGossip?.Equals(otherGossip) == true;

        public static bool operator !=(Gossip oneGossip, Gossip otherGossip) => !(oneGossip == otherGossip);

        public override int GetHashCode() => _id;
    }
}
