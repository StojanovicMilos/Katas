using System;

namespace ScoreKeeper
{
    public class NoPrimitivesTeamScore : ITeamScore
    {
        private INumber _hundreds;
        private INumber _tens;
        private INumber _ones;

        public NoPrimitivesTeamScore(INumber hundreds, INumber tens, INumber ones)
        {
            _hundreds = hundreds ?? throw new ArgumentNullException(nameof(hundreds));
            _tens = tens ?? throw new ArgumentNullException(nameof(tens));
            _ones = ones ?? throw new ArgumentNullException(nameof(ones));
        }

        public void Score1() => Score(_ones.AddOne);
        public void Score2() => Score(_ones.AddTwo);
        public void Score3() => Score(_ones.AddThree);

        private void Score(Func<NumberAdditionResult> onesAddition)
        {
            NumberAdditionResult onesAdditionResult = onesAddition();
            _ones = onesAdditionResult.Result;

            NumberAdditionResult tensAdditionResult = onesAdditionResult.Carry.AddNumber(_tens);
            _tens = tensAdditionResult.Result;

            NumberAdditionResult hundredsAdditionResult = tensAdditionResult.Carry.AddNumber(_hundreds);
            _hundreds = hundredsAdditionResult.Result;
        }

        public override string ToString() => _hundreds.ToString() + _tens + _ones;
    }
}