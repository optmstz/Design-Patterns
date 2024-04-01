using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.MoneyPart;
using ClassLibrary.ProductPart;

namespace ClassLibrary.WarehousePart
{
    public class Warehouse
    {
        public List<WarehouseProduct> products { get; set; }

        public Warehouse(List<WarehouseProduct> products) 
        {
            this.products = products;
        }

        public void DisplayAllProducts()
        {
            if (products != null && products.Count > 0)
            {
                Console.WriteLine("Products in Warehouse:");
                foreach (var product in products)
                {
                    Console.WriteLine($"Name: {product.name}, Category: {product.category}," +
                        $" Price: {product.price.DisplayAmount()}, Quantity: {product.quantity}," +
                        $" Last Stocked Date: {product.lastStockedDate}");
                }
            }
            else
            {
                Console.WriteLine("No products in Warehouse.");
            }
        }
    }
}
