namespace ScoreKeeper
{
    public interface INumber
    {
        NumberAdditionResult AddOne();
        NumberAdditionResult AddTwo();
        NumberAdditionResult AddThree();
    }

    public interface ICarry
    {
        NumberAdditionResult AddNumber(INumber number);
    }

    public class NumberAdditionResult
    {
        public INumber Result { get; }
        public ICarry Carry { get; }

        public static NumberAdditionResult NoCarryResult(INumber result) => new NumberAdditionResult(result, new Number0());
        public static NumberAdditionResult CarryResult(INumber result) => new NumberAdditionResult(result, new Number1());

        private NumberAdditionResult(INumber result, ICarry carry)
        {
            Result = result;
            Carry = carry;
        }
    }

    public class Number0 : INumber, ICarry
    {
        public NumberAdditionResult AddOne() => NumberAdditionResult.NoCarryResult(new Number1());
        public NumberAdditionResult AddTwo() => NumberAdditionResult.NoCarryResult(new Number2());
        public NumberAdditionResult AddThree() => NumberAdditionResult.NoCarryResult(new Number3());

        public NumberAdditionResult AddNumber(INumber number) => NumberAdditionResult.NoCarryResult(number);

        public override string ToString() => "0";
    }

    public class Number1 : INumber, ICarry
    {
        public NumberAdditionResult AddOne() => NumberAdditionResult.NoCarryResult(new Number2());
        public NumberAdditionResult AddTwo() => NumberAdditionResult.NoCarryResult(new Number3());
        public NumberAdditionResult AddThree() => NumberAdditionResult.NoCarryResult(new Number4());

        public NumberAdditionResult AddNumber(INumber number) => number.AddOne();

        public override string ToString() => "1";
    }

    public class Number2 : INumber
    {
        public NumberAdditionResult AddOne() => NumberAdditionResult.NoCarryResult(new Number3());
        public NumberAdditionResult AddTwo() => NumberAdditionResult.NoCarryResult(new Number4());
        public NumberAdditionResult AddThree() => NumberAdditionResult.NoCarryResult(new Number5());

        public override string ToString() => "2";
    }

    public class Number3 : INumber
    {
        public NumberAdditionResult AddOne() => NumberAdditionResult.NoCarryResult(new Number4());
        public NumberAdditionResult AddTwo() => NumberAdditionResult.NoCarryResult(new Number5());
        public NumberAdditionResult AddThree() => NumberAdditionResult.NoCarryResult(new Number6());

        public override string ToString() => "3";
    }

    public class Number4 : INumber
    {
        public NumberAdditionResult AddOne() => NumberAdditionResult.NoCarryResult(new Number5());
        public NumberAdditionResult AddTwo() => NumberAdditionResult.NoCarryResult(new Number6());
        public NumberAdditionResult AddThree() => NumberAdditionResult.NoCarryResult(new Number7());

        public override string ToString() => "4";
    }

    public class Number5 : INumber
    {
        public NumberAdditionResult AddOne() => NumberAdditionResult.NoCarryResult(new Number6());
        public NumberAdditionResult AddTwo() => NumberAdditionResult.NoCarryResult(new Number7());
        public NumberAdditionResult AddThree() => NumberAdditionResult.NoCarryResult(new Number8());

        public override string ToString() => "5";
    }

    public class Number6 : INumber
    {
        public NumberAdditionResult AddOne() => NumberAdditionResult.NoCarryResult(new Number7());
        public NumberAdditionResult AddTwo() => NumberAdditionResult.NoCarryResult(new Number8());
        public NumberAdditionResult AddThree() => NumberAdditionResult.NoCarryResult(new Number9());

        public override string ToString() => "6";
    }

    public class Number7 : INumber
    {
        public NumberAdditionResult AddOne() => NumberAdditionResult.NoCarryResult(new Number8());
        public NumberAdditionResult AddTwo() => NumberAdditionResult.NoCarryResult(new Number9());
        public NumberAdditionResult AddThree() => NumberAdditionResult.CarryResult(new Number0());

        public override string ToString() => "7";
    }

    public class Number8 : INumber
    {
        public NumberAdditionResult AddOne() => NumberAdditionResult.NoCarryResult(new Number9());
        public NumberAdditionResult AddTwo() => NumberAdditionResult.CarryResult(new Number0());
        public NumberAdditionResult AddThree() => NumberAdditionResult.CarryResult(new Number1());

        public override string ToString() => "8";
    }

    public class Number9 : INumber
    {
        public NumberAdditionResult AddOne() => NumberAdditionResult.CarryResult(new Number0());
        public NumberAdditionResult AddTwo() => NumberAdditionResult.CarryResult(new Number1());
        public NumberAdditionResult AddThree() => NumberAdditionResult.CarryResult(new Number2());

        public override string ToString() => "9";
    }
}