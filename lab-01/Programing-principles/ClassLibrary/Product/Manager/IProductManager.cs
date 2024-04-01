using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.MoneyPart;
using ClassLibrary.MoneyPart.Currency;

namespace ClassLibrary.ProductPart.Manager
{
    public interface IProductManager
    {
        void ReduceProductPrice(CurrencyMoney reduceValue);
    }
}
