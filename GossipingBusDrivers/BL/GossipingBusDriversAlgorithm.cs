using System;

namespace GossipingBusDrivers.BL
{
    public class GossipingBusDriversAlgorithm
    {
        private readonly GossipingBusDriversInputReader _gossipingBusDriversInputReader;

        public GossipingBusDriversAlgorithm(GossipingBusDriversInputReader gossipingBusDriversInputReader)
        {
            _gossipingBusDriversInputReader = gossipingBusDriversInputReader ?? throw new ArgumentNullException(nameof(gossipingBusDriversInputReader));
        }

        public void SolveForInput(string fileName, Action<int> onSuccess, Action onFailure)
        {
            var busDrivers = _gossipingBusDriversInputReader.ReadFromInput(fileName);

            for (int minute = Constants.ShiftStart; minute <= Constants.ShiftEnd; minute++)
            {
                busDrivers.Gossip();
                busDrivers.Drive();

                if (busDrivers.EveryoneKnowsAllGossips())
                {
                    onSuccess(minute);
                    return;
                }
            }

            onFailure();
        }
    }
}
