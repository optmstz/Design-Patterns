# Design Principles

## I use C# to display all principles. It's consists of two part: ClassLibrary and C# project.

## Project structure

lab-01/Programing-principles
- ClassLibrary
 - Money
  - Currency
   - CurrencyClasses.cs
   - ICurrency.cs
  - IMoney.cs
  - Money.cs
 - Product
  - Manager
   - IProductManager.cs
   - ProductManager.cs
  - IProduct.cs
  - Product.cs
 - Reporting
  - Reporters
   - IncomingProductReporter.cs
   - InventoryReporter.cs
   - OutgoingProductRepoter.cs
  - IReporter.cs
  - ReportingService.cs
 - Warehouse
  - IWarehouseProduct.cs
  - Warehouse.cs
  - WarehouseProduct.cs
- Programing-principles
 - Programing-principles.sln

## Realization of principles
- DRY [click](./ClassLibrary/Money/Money.cs#L21) I use virtual method, which help don't copy method in other classes [click](./ClassLibrary/Money/CurrencyClasses.cs#L21)
- KISS Totaly i use simple decision to each task here. Simple ReducePrice() method [click](./ClassLibrary/Product/Manager/ProductManager). Clear variables.
- SOLID
 - Single All classes respond for one action for example Product : [Product](./Classlibrary/Product/Product.csL#13), ProductManager respond for reducing price of product: [ProductManager](./Classlibrary/Product/Product/Manager/ProductManager.cs#L9)
 - Open/Closed This code can be extended to add new product types, currencies, and other functionality without changing your existing code. For example we can add new product or currency : [Product](./Classlibrary/Product/IProduct.csL#13) [Currency](./Classlibrary/Money/Currency/ICurrency.csL#9)
 - Liskov Substitution We can use Dollar, Euro class insted Money. [click](./ClassLibrary/Money/CurrencyClasses.cs#L10)
 - Interface Segregation All interfaces are clearly defined purposes and minimal, specialized methods or properties. This ensures that clients are not burdened with methods they do not use [IMoney](./ClassLibrary/Money) [ICurrency](./ClassLibrary/Currency) [IProductManager](./ClassLibrary/Manager)
 - Dependency Inversion All classes use interfaces or abstractions [CurrecmyClasses](./ClassLibrary/Money/Curremcy/CurrencyClasses.cs)
- YAGNI I ensured that the program includes only necessary functionality, with all methods being actively utilized.
- Composition Over Inheritance [IMoney](./ClassLibrary/Money) [ICurrency](./ClassLibrary/Currency) [IProductManager](./ClassLibrary/Manager) [IReporter](./ClassLibrary/Reporting/IReporter.cs) [IWarehouse](./ClassLibrary/Warehouse/IWarehouse.cs)
- Program to Interfaces not Implementations Example: [ProductManager] (./ClassLibrary/Product/Manager/ProductManager.csL#9) I use IProduct insted of just Product class. It's allows to work with all objects which implemented from IProduct interface.
- Fail Fast Here few examples: [ProductManager] (./ClassLibrary/Product/Manager/ProductManager.csL#11) [Warehouse] (./ClassLibrary/Warehouse/Warehouse.csL#22) [IncomingProductReporter] (./ClassLibrary/Reporting/Reportes/IncomingProductReporter.csL#26)