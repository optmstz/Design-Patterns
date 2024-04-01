using ClassLibrary.WarehousePart;
using System;
using System.Collections.Generic;

namespace ClassLibrary.ReportingPart.Reporters
{
    public class InventoryReporter : IReporter
    {
        private readonly Warehouse _warehouse;

        public InventoryReporter(Warehouse warehouse)
        {
            _warehouse = warehouse;
        }

        public void Report()
        {
            Console.WriteLine("Inventory Report:");
            foreach (var product in _warehouse.products)
            {
                Console.WriteLine($"Name: {product.name}, " +
                                  $"Category: {product.category}," +
                                  $" Quantity: {product.quantity}," +
                                  $" Last Stocked Date: {product.lastStockedDate}");
            }
        }
    }
}
