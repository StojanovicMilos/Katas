using System.Collections.Generic;

namespace CoinChangeChallenge.Money
{
    public static class CurrencyRepository
    {
        private static readonly Dictionary<string, IEnumerable<Banknote>> Currencies = new Dictionary<string, IEnumerable<Banknote>>
        {
            {SerbianBanknotes.SerbianCurrency, SerbianBanknotes.AllBanknotesDescending()}
        };

        public static IEnumerable<Banknote> GetAllBanknotesDescendingFor(string currency) => Currencies[currency];
    }
}
