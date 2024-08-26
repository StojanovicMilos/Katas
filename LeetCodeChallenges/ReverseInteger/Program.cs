//https://leetcode.com/problems/reverse-integer/
Console.WriteLine("Hello, World!");

Console.WriteLine(Reverse(int.MaxValue));

const int PositiveSign = 1;
const int NegativeSign = -1;

int Reverse(int x)
{
    var sign = GetSign(x);
    var result = 0;

    while (x != 0)
    {
        var lastDigit = x % 10;
        x = x / 10;
        var nextResult = result * 10 + lastDigit;
        if ((nextResult - lastDigit) / 10 != result) //overflow
        {
            return 0;
        }

        result = nextResult;
    }

    return GetSign(result) == sign ? result : 0;
}


int GetSign(int value) => value > 0 ? PositiveSign : NegativeSign;