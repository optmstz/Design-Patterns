using ClassLibrary.MoneyPart;

namespace ClassLibrary.ProductPart.Manager
{
    public class ProductManager
    {

        public void ReduceProductPrice(IProduct productInfo, Money reductionAmount)
        {
            if (productInfo.price.wholePart > reductionAmount.wholePart ||
                productInfo.price.wholePart == reductionAmount.wholePart && productInfo.price.fractionalPart >= reductionAmount.fractionalPart)
            {
                productInfo.price.wholePart -= reductionAmount.wholePart;
                productInfo.price.fractionalPart -= reductionAmount.fractionalPart;

                if (productInfo.price.fractionalPart < 0)
                {
                    productInfo.price.wholePart--;
                    productInfo.price.fractionalPart += 100;
                }
            }
            else
            {
                Console.WriteLine("Error: reduce price more than current one.");
            }
        }
    }
}
