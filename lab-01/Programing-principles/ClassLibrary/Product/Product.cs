using ClassLibrary.MoneyPart;
using ClassLibrary.MoneyPart.Currency;

namespace ClassLibrary.ProductPart
{
    public class Product : IProduct
    {
        public string name { get; protected set; }
        public string category { get; protected set; }

        public CurrencyMoney currency { get; protected set; }

        public Product(string name, string category, CurrencyMoney price)
        {
            this.name = name;
            this.category = category;
            this.currency = price;
        }

    }
}
