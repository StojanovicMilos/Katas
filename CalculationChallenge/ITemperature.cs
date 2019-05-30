namespace CalculationChallenge
{
    //challenge: https://www.iamtimcorey.com/courses/c-weekly-challenges/lectures/10414088
    //text: https://www.filepicker.io/api/file/qKRfgG1SRCGTd2V8MV2w

    public interface ITemperature
    {
        int Min { get; }
        int Max { get; }
        double Avg { get; }

        void Insert(int newElement);

    }
}