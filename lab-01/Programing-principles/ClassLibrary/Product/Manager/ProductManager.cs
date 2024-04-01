using ClassLibrary.MoneyPart;
using ClassLibrary.MoneyPart.Currency;

namespace ClassLibrary.ProductPart.Manager
{
    public class ProductManager
    {

        public void ReduceProductPrice(IProduct productInfo, CurrencyMoney reductionAmount)
        {
            if (productInfo.currency.amount.wholePart > reductionAmount.amount.wholePart ||
                productInfo.currency.amount.wholePart == reductionAmount.amount.wholePart && productInfo.currency.amount.fractionalPart >= reductionAmount.amount.fractionalPart)
            {
                productInfo.currency.amount.wholePart -= reductionAmount.amount.wholePart;
                productInfo.currency.amount.fractionalPart -= reductionAmount.amount.fractionalPart;

                if (productInfo.currency.amount.fractionalPart < 0)
                {
                    productInfo.currency.amount.wholePart--;
                    productInfo.currency.amount.fractionalPart += 100;
                }
            }
            else
            {
                Console.WriteLine("Error: reduce price more than current one.");
            }
        }
    }
}
