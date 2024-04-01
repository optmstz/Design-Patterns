using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.MoneyPart;

namespace ClassLibrary.ProductPart.Manager
{
    public interface IProductManager
    {
        void ReduceProductPrice(Money reduceValue);
    }
}
