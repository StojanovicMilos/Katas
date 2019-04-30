using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GossipingBusDrivers.BL
{
    public class Gossips : IEnumerable<Gossip>
    {
        private readonly HashSet<Gossip> _gossips;

        public Gossips(HashSet<Gossip> gossips)
        {
            _gossips = gossips ?? throw new ArgumentNullException(nameof(gossips));
        }

        public void Add(Gossips gossips)
        {
            if (gossips == null) throw new ArgumentNullException(nameof(gossips));
            foreach (var gossip in gossips.Where(g => !_gossips.Contains(g)))
            {
                _gossips.Add(gossip);
            }
        }

        public IEnumerator<Gossip> GetEnumerator() => _gossips.GetEnumerator();
        
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
