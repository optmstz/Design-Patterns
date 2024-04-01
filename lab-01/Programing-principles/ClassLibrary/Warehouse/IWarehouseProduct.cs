using ClassLibrary.ProductPart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.WarehousePart
{
    public interface IWarehouseProduct : IProduct
    {
        int quantity { get; set; }
        DateTime lastStockedDate { get; set; }
    }
}
