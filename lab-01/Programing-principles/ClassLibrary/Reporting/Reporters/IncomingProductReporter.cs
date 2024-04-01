using ClassLibrary.WarehousePart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.ReportingPart.Reporters
{
    public class IncomingProductReporter: IReporter
    {
        private readonly Warehouse _warehouse;
        private readonly List<WarehouseProduct> _incomingProducts;

        public IncomingProductReporter(Warehouse warehouse, List<WarehouseProduct> incomingProducts)
        {
            _warehouse = warehouse;
            _incomingProducts = incomingProducts;
        }

        public void Report()
        {
            foreach (var product in _incomingProducts)
            {
                var existingProduct = _warehouse.products.Find(p => p.name == product.name && p.category == product.category);
                if (existingProduct != null)
                {
                    existingProduct.quantity += product.quantity;
                    existingProduct.lastStockedDate = DateTime.Now;
                }
                else
                {
                    _warehouse.products.Add(product);
                }

                Console.WriteLine($"Product '{product.name}' in category '{product.category}' has been added to the warehouse with quantity {product.quantity}.");
            }
        }
    }
}
