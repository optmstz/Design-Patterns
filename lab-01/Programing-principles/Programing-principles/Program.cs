using ClassLibrary.ProductPart;
using ClassLibrary.ProductPart.Manager;
using ClassLibrary.WarehousePart;
using ClassLibrary.ReportingPart;
using ClassLibrary.ReportingPart.Reporters;
using ClassLibrary.MoneyPart.Currency;
using ClassLibrary.MoneyPart;

namespace CheckTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            CurrencyTest();
            ProductTest();

            var warehouse = WarehouseTest();
            ReportingTest(warehouse);
          
        }

        public static void CurrencyTest()
        {
            CurrencyMoney[] currencyArray = {
                new GrivnaMoney(2390, 232),
                new DollarMoney(30, 20),
                new EuroMoney(329, 23)
            };


            foreach (var currency in currencyArray)
            {
                Console.WriteLine(currency.DisplayAmount());
            }
        }


        public static void ProductTest()
        {
            var productManager = new ProductManager();
            var testProduct = new Product("Coca-Cola", "Sweet water", new GrivnaMoney(30, 12));
            var testReducePrice = new GrivnaMoney(10, 3);

            Console.WriteLine($"Product name: \"{testProduct.name}\"\n\tcategory: {testProduct.category}\n\tprice: {testProduct.currency.DisplayAmount()}\n");

            productManager.ReduceProductPrice(testProduct, testReducePrice);
            Console.WriteLine($"Reduce value: {testReducePrice.DisplayAmount()}\nPrice after reducing: {testProduct.currency.DisplayAmount()}\n");
        }

        public static Warehouse WarehouseTest()
        {
            var testProdList = new List<WarehouseProduct>();
            var testWarehouse = new Warehouse(testProdList);

            for (int i = 0; i < 10; i++)
            {
                testProdList.Add(new WarehouseProduct($"test{i}", $"{i}", new GrivnaMoney(i * 10, 90), i * 9, DateTime.Now));
            }

            testWarehouse.DisplayAllProducts();
            Console.WriteLine();

            return testWarehouse;
        }

        public static void ReportingTest(Warehouse warehouse)
        {
            var productsToAdd = new List<WarehouseProduct> {
                new WarehouseProduct("test0", "0", new GrivnaMoney(100, 10), 10, DateTime.Now),
                new WarehouseProduct("Product2", "Category2", new GrivnaMoney(200, 10), 20, DateTime.Now)
            };

            ReportingService reportingService = new ReportingService(warehouse);

            IReporter incomingReporter = new IncomingProductReporter(warehouse, productsToAdd);
            reportingService.RegisterReport(incomingReporter);
            Console.WriteLine();

            IReporter inventoryReport = new InventoryReporter(warehouse);
            reportingService.RegisterReport(inventoryReport);
            Console.WriteLine();

            IReporter outgoingReporter = new OutgoingProductReporter(warehouse, productsToAdd);
            reportingService.RegisterReport(outgoingReporter);
        }
    }
}