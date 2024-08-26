
static class RomanConverter
{
    private static readonly CombinedDigits[] _combinedDigits = [new SingleDigit(), new Tens(), new Hundreds()];

    public static string ConvertToRoman(int value) //value can be from 1 to 3999, so no need to check for 0 or negative values
    {
        string result = string.Empty;
        foreach(var combinedDigit in _combinedDigits)
        {
            var digit = GetLastDigit(value);
            var romanDigit = combinedDigit.GetRepresentation(digit);
            result = $"{romanDigit}{result}";
            value = ShiftRight(value);
        }

        var thousandsDigitRoman = Thousands.GetRepresentation(value);
        return $"{thousandsDigitRoman}{result}";
    }

    private static int GetLastDigit(int value) => value % 10;

    private static int ShiftRight(int value) => value / 10;
}
