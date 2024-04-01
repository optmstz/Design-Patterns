using ClassLibrary.WarehousePart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.ReportingPart.Reporters
{
    public class OutgoingProductReporter : IReporter
    {
        private readonly Warehouse _warehouse;
        private readonly List<WarehouseProduct> _outgoingProducts;

        public OutgoingProductReporter(Warehouse warehouse, List<WarehouseProduct> outgoingProducts)
        {
            _warehouse = warehouse;
            _outgoingProducts = outgoingProducts;
        }

        public void Report()
        {
            foreach (var product in _outgoingProducts)
            {
                var existingProduct = _warehouse.products.FirstOrDefault(p => p.name == product.name && p.category == product.category);
                if (existingProduct != null)
                {
                    var shippedQuantity = product.quantity;
                    existingProduct.quantity -= shippedQuantity;
                    existingProduct.lastStockedDate = DateTime.Now;
                    if (existingProduct.quantity < 0)
                    {
                        Console.WriteLine($"Warning: Quantity of {product.name} cannot be negative.");
                        existingProduct.quantity = 0;
                    }

                    Console.WriteLine($"Product '{existingProduct.name}' in category '{existingProduct.category}' has been shipped from the warehouse with quantity {shippedQuantity}.");
                }
                else
                {
                    Console.WriteLine($"Error: Product '{product.name}' not found in the warehouse. Shipping failed.");
                }
            }
        }
    }
}
