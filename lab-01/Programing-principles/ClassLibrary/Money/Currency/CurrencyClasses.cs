using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.MoneyPart.Currency
{
    public class GrivnaMoney : Money, ICurrency
    {
        public string currency { get; set; } = "UAH";

        public GrivnaMoney(int wholePart, int fractionalPart) : base(wholePart, fractionalPart)
        {

        }
        public override string DisplayAmount()
        {
            return $"{wholePart}.{fractionalPart} {currency}";
        }
    }

    public class DollarMoney : Money, ICurrency
    {
        public string currency { get; set; } = "USD";

        public DollarMoney(int wholePart, int fractionalPart) : base(wholePart, fractionalPart)
        {

        }
        public override string DisplayAmount()
        {
            return $"{wholePart}.{fractionalPart} {currency}";
        }
    }

    public class EuroMoney : Money, ICurrency
    {
        public string currency { get; set; } = "EUR";

        public EuroMoney(int wholePart, int fractionalPart) : base(wholePart, fractionalPart)
        {

        }
        public override string DisplayAmount()
        {
            return $"{wholePart}.{fractionalPart} {currency}";
        }
    }

    public class NoCurrencyMoney : Money
    {
        public NoCurrencyMoney(int wholePart, int fractionalPart) : base(wholePart, fractionalPart)
        {

        }
    }
}
