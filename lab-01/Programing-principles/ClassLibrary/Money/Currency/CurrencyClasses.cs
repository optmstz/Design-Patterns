using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.MoneyPart.Currency
{
    public abstract class CurrencyMoney : ICurrency
    {
        public string currencyName { get; set; }
        public IMoney amount { get; private set; }

        protected CurrencyMoney(int wholePart, int fractionalPart, string currency)
        {
            amount = new Money(wholePart, fractionalPart);
            this.currencyName = currency;
        }

        public virtual string DisplayAmount()
        {
            return $"{amount.DisplayAmount()} {currencyName}";
        }
    }

    public class GrivnaMoney : CurrencyMoney
    {
        public GrivnaMoney(int wholePart, int fractionalPart) : base(wholePart, fractionalPart, "UAH")
        {
        }
    }

    public class DollarMoney : CurrencyMoney
    {
        public DollarMoney(int wholePart, int fractionalPart) : base(wholePart, fractionalPart, "USD")
        {
        }
    }

    public class EuroMoney : CurrencyMoney
    {
        public EuroMoney(int wholePart, int fractionalPart) : base(wholePart, fractionalPart, "EUR")
        {
        }
    }
}
