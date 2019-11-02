using System;

namespace CoinChangeChallenge.Money
{
    public class Banknote
    {
        public int Amount { get; }
        public string Currency { get; }

        public Banknote(int amount, string currency)
        {
            if (amount < 0) throw new ArgumentOutOfRangeException(nameof(amount));
            Amount = amount;
            Currency = currency ?? throw new ArgumentNullException(nameof(currency));
        }

        public override string ToString() => Amount + " " + Currency;
    }
}
