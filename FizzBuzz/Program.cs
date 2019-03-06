using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        static void Main()
        {
            var mappingStrategies = new IMappingStrategy[]
            {
                new DividableByThreeMappingStrategy(),
                new DividableByFiveMappingStrategy()
            };
            IMappingStrategy mappingStrategy = new CompositeMappingStrategy(mappingStrategies);

            const int minimum = 1;
            const int maximum = 100;
            for (var number = minimum; number <= maximum; number++)
            {
                Console.WriteLine(number + " => " + mappingStrategy.Map(number));
            }
        }
    }

    public interface IMappingStrategy
    {
        string Map(int number);
    }

    public class DividableByThreeMappingStrategy : IMappingStrategy
    {
        public string Map(int number) => number % 3 == 0 ? "Fizz" : string.Empty;
    }

    public class DividableByFiveMappingStrategy : IMappingStrategy
    {
        public string Map(int number) => number % 5 == 0 ? "Buzz" : string.Empty;
    }

    public class CompositeMappingStrategy : IMappingStrategy
    {
        private readonly IEnumerable<IMappingStrategy> _mappingStrategies;

        public CompositeMappingStrategy(IEnumerable<IMappingStrategy> mappingStrategies)
        {
            _mappingStrategies = mappingStrategies ?? throw new ArgumentNullException(nameof(mappingStrategies));
        }

        public string Map(int number)
        {
            var result = _mappingStrategies.Aggregate(string.Empty, (current, mappingStrategy) => current + mappingStrategy?.Map(number));
            if (result == string.Empty)
                result = number.ToString();
            return result;
        }
    }
}
