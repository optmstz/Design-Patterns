using ClassLibrary.MoneyPart;
using ClassLibrary.MoneyPart.Currency;
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
        public CurrencyMoney currency { get; set; }
        public int quantity { get; set; } 
        public DateTime lastStockedDate { get; set; }

        public WarehouseProduct(string name, string category, CurrencyMoney currency, int quantity, DateTime lastStockedDate)
        {
            this.name = name;
            this.category = category;
            this.currency = currency;
            this.quantity = quantity;
            this.lastStockedDate = lastStockedDate;
        }
    }
}
