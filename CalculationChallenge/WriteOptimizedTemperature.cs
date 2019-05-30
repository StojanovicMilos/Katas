using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculationChallenge
{
    public class WriteOptimizedTemperature : ITemperature
    {
        private readonly List<int> _temperatures;

        public WriteOptimizedTemperature(List<int> temperatures)
        {
            _temperatures = temperatures ?? throw new ArgumentNullException(nameof(temperatures));
        }

        public int Min => _temperatures.Min();

        public int Max => _temperatures.Max();

        public double Avg => _temperatures.Average();

        public void Insert(int newElement) => _temperatures.Add(newElement);
    }
}