using System;
using GossipingBusDrivers.BL;

namespace GossipingBusDrivers.Client
{
    class Program
    {
        static void Main()
        {
            void OnSuccess(int minute) => Console.WriteLine("All bus drivers have found out all gossips after " + minute + " minutes");
            void OnFailure() => Console.WriteLine("never");

            GossipingBusDriversInputReader reader = new GossipingBusDriversInputReader();
            GossipingBusDriversAlgorithm gossipingBusDrivers = new GossipingBusDriversAlgorithm(reader);

            gossipingBusDrivers.SolveForInput("InputTextData\\Example1.txt", OnSuccess, OnFailure);
            gossipingBusDrivers.SolveForInput("InputTextData\\Example2.txt", OnSuccess, OnFailure);
            gossipingBusDrivers.SolveForInput("InputTextData\\Challenge1.txt", OnSuccess, OnFailure);
            gossipingBusDrivers.SolveForInput("InputTextData\\Challenge2.txt", OnSuccess, OnFailure);
        }
    }
}
