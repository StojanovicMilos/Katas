using System;
using System.Collections.Generic;
using System.Linq;
using CoinChangeChallenge.Money;

namespace CoinChangeChallenge
{
    public class ChangeCalculator
    {
        private readonly IEnumerable<Banknote> _banknotes;

        public ChangeCalculator(string currency)
        {
            if (currency == null) throw new ArgumentNullException(nameof(currency));
            _banknotes = CurrencyRepository.GetAllBanknotesDescendingFor(currency);
        }

        public GetBanknotesResult GetBanknotesFor(int change) => GetBanknotesFor(change, _banknotes);

        private GetBanknotesResult GetBanknotesFor(int change, IEnumerable<Banknote> remainingBanknotes)
        {
            if (change < 0) throw new ArgumentOutOfRangeException(nameof(change));
            if (change == 0) return GetBanknotesResult.SuccessfulResult(Enumerable.Empty<Banknote>());

            List<Banknote> returnBanknotes = new List<Banknote>();

            var usableBanknotes = remainingBanknotes.Where(b => b.Amount <= change).ToList();
            var maxBanknote = usableBanknotes.FirstOrDefault();

            if (maxBanknote == null)
            {
                return GetBanknotesResult.FailedResult("Not enough banknotes to calculate the change");
            }

            change -= maxBanknote.Amount;
            usableBanknotes.Remove(maxBanknote);
            returnBanknotes.Add(maxBanknote);

            var result = GetBanknotesFor(change, usableBanknotes);
            if (result.Success)
            {
                returnBanknotes.AddRange(result.Banknotes);
                return GetBanknotesResult.SuccessfulResult(returnBanknotes);
            }

            returnBanknotes.Remove(maxBanknote);
            change += maxBanknote.Amount;
            result = GetBanknotesFor(change, usableBanknotes);
            if (result.Success)
            {
                returnBanknotes.AddRange(result.Banknotes);
                return GetBanknotesResult.SuccessfulResult(returnBanknotes);
            }

            return GetBanknotesResult.FailedResult("Cannot return change");
        }
    }

    public class GetBanknotesResult
    {
        public string ErrorMessage { get; }
        public IEnumerable<Banknote> Banknotes { get; }
        public bool Success { get; }

        public static GetBanknotesResult FailedResult(string errorMessage) => new GetBanknotesResult(false, errorMessage, Enumerable.Empty<Banknote>());
        public static GetBanknotesResult SuccessfulResult(IEnumerable<Banknote> banknotes) => new GetBanknotesResult(true, string.Empty, banknotes);

        private GetBanknotesResult(bool success, string errorMessage, IEnumerable<Banknote> banknotes)
        {
            Success = success;
            ErrorMessage = errorMessage;
            Banknotes = banknotes ?? throw new ArgumentNullException(nameof(banknotes));
        }
    }
}
