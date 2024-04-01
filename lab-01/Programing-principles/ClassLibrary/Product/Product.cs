using ClassLibrary.MoneyPart;

namespace ClassLibrary.ProductPart
{
    public class Product : IProduct
    {
        public string name { get; protected set; }
        public string category { get; protected set; }

        public Money price { get; protected set; }

        public Product(string name, string category, Money price)
        {
            this.name = name;
            this.category = category;
            this.price = price;
        }

    }
}
