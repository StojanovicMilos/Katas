abstract class CombinedDigits
{
    protected abstract char One { get; }
    protected abstract char Five { get; }
    protected abstract char Ten { get; }

    public virtual string GetRepresentation(int digit)
    {
        if (digit == 0)
        {
            return string.Empty;
        }

        return digit switch
        {
            >= 1 and <= 3 => new string(One, digit),
            4 => $"{One}{Five}",
            >= 5 and <= 8 => Five + new string(One, digit - 5),
            9 => $"{One}{Ten}",
            _ => throw new ArgumentOutOfRangeException(nameof(digit)),
        };
    }
}