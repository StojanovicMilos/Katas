using System;
using CoinChangeChallenge.Money;

namespace CoinChangeChallenge
{
    public static class Program
    {
        public static void Main()
        {
            const string currency = SerbianBanknotes.SerbianCurrency;
            const int change = 1234;
            var changeCalculator = new ChangeCalculator(currency);
            var result = changeCalculator.GetBanknotesFor(change);
            if (result.Success)
            {
                Console.WriteLine("Change for " + change + " in " + currency + " currency is:");
                foreach (var banknote in result.Banknotes)
                {
                    Console.WriteLine(banknote);
                }
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }
        }
    }
}
