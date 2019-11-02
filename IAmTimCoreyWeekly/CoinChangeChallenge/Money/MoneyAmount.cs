using System;
using System.Collections.Generic;
using System.Linq;

namespace CoinChangeChallenge.Money
{
    public class MoneyAmount
    {
        private readonly IEnumerable<Banknote> _banknotes;

        public MoneyAmount(IEnumerable<Banknote> banknotes)
        {
            _banknotes = banknotes ?? throw new ArgumentNullException(nameof(banknotes));
        }

        public int TotalAmount => _banknotes.Sum(b => b.Amount);
    }
}