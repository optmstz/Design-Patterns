using ClassLibrary.MoneyPart;
using ClassLibrary.ProductPart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.WarehousePart
{
    public class WarehouseProduct: IWarehouseProduct
    {
        public string name { get; protected set; } 
        public string category { get; protected set; }
        public Money price { get; set; }
        public int quantity { get; set; } 
        public DateTime lastStockedDate { get; set; }

        public WarehouseProduct(string name, string category, Money price, int quantity, DateTime lastStockedDate)
        {
            this.name = name;
            this.category = category;
            this.price = price;
            this.quantity = quantity;
            this.lastStockedDate = lastStockedDate;
        }
    }
}
