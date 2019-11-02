using System.Collections.Generic;

namespace CoinChangeChallenge.Money
{
    public static class SerbianBanknotes
    {
        public const string SerbianCurrency = "RSD";
        public static Banknote FiveThousand = new Banknote(5000, SerbianCurrency);
        public static Banknote TwoThousand = new Banknote(2000, SerbianCurrency);
        public static Banknote OneThousand = new Banknote(1000, SerbianCurrency);
        public static Banknote FiveHundred = new Banknote(500, SerbianCurrency);
        public static Banknote TwoHundred = new Banknote(200, SerbianCurrency);
        public static Banknote OneHundred = new Banknote(100, SerbianCurrency);
        public static Banknote Fifty = new Banknote(50, SerbianCurrency);
        public static Banknote Twenty = new Banknote(20, SerbianCurrency);
        public static Banknote Ten = new Banknote(10, SerbianCurrency);
        public static Banknote Five = new Banknote(5, SerbianCurrency);
        public static Banknote Two = new Banknote(2, SerbianCurrency);
        public static Banknote One = new Banknote(1, SerbianCurrency);

        public static IEnumerable<Banknote> AllBanknotesDescending() => new[] {FiveThousand, TwoThousand, OneThousand, FiveHundred, TwoHundred, OneHundred, Fifty, Twenty, Ten, Five, Two, One };
    }
}