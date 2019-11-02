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
            string[] fileNames = {"InputTextData\\Example1.txt", "InputTextData\\Example2.txt", "InputTextData\\Challenge1.txt", "InputTextData\\Challenge2.txt"};

            foreach (var fileName in fileNames)
            {
                BusDrivers busDrivers = GossipingBusDriversInputReader.ReadDriversFrom(fileName);
                GossipingBusDriversAlgorithm.SolveForInput(busDrivers, OnSuccess, OnFailure);
            }
        }
    }
}
