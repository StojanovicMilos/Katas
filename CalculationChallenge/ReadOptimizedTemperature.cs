namespace CalculationChallenge
{
    public class ReadOptimizedTemperature : ITemperature
    {
        private int _elementCount;
        private int _sum;

        public int Min { get; private set; } = int.MaxValue;

        public int Max { get; private set; } = int.MinValue;

        public double Avg { get; private set; }

        public void Insert(int newElement)
        {
            UpdateMinimum(newElement);
            UpdateMaximum(newElement);
            UpdateAverage(newElement);
        }

        private void UpdateMinimum(int newElement)
        {
            if (_elementCount == 0 || newElement < Min)
                Min = newElement;
        }

        private void UpdateMaximum(int newElement)
        {
            if (_elementCount == 0 || newElement > Max)
                Max = newElement;
        }

        private void UpdateAverage(int newElement)
        {
            _sum += newElement;
            _elementCount++;
            Avg = (double) _sum / _elementCount;
        }
    }
}
