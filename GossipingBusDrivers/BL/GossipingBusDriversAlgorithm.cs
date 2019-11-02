using System;

namespace GossipingBusDrivers.BL
{
    public static class GossipingBusDriversAlgorithm
    {
        public static void SolveForInput(BusDrivers busDrivers, Action<int> onSuccess, Action onFailure)
        {
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
