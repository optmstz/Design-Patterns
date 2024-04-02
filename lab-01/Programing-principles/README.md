# Design Principles

## I use C# to display all principles. It consists of two parts: ClassLibrary and a C# project.

## Project structure

lab-01/Programing-principles
- **ClassLibrary**
  - **Money**
    - **Currency**
      - CurrencyClasses.cs
      - ICurrency.cs
    - IMoney.cs
    - Money.cs
  - **Product**
    - **Manager**
      - IProductManager.cs
      - ProductManager.cs
    - IProduct.cs
    - Product.cs
  - **Reporting**
    - **Reporters**
      - IncomingProductReporter.cs
      - InventoryReporter.cs
      - OutgoingProductReporter.cs
    - IReporter.cs
    - ReportingService.cs
  - **Warehouse**
    - IWarehouseProduct.cs
    - Warehouse.cs
    - WarehouseProduct.cs

## Realization of principles

- DRY: [click](./ClassLibrary/Money/Money.cs#L21) I use a virtual method, which helps to avoid copying methods in other classes. [click](./ClassLibrary/Money/CurrencyClasses.cs#L21)
- KISS: I use simple solutions for each task. For example, a simple ReducePrice() method. [click](./ClassLibrary/Product/Manager/ProductManager.cs)
- SOLID:
  - Single: All classes are responsible for a single action. For example, the Product class. [Product](./ClassLibrary/Product/Product.cs#L13) The ProductManager class is responsible for reducing the price of a product. [ProductManager](./ClassLibrary/Product/Product/Manager/ProductManager.cs#L9)
  - Open/Closed: This code can be extended to add new product types, currencies, and other functionality without changing existing code. For example, we can add new products or currencies. [Product](./ClassLibrary/Product/IProduct.cs#L13) [Currency](./ClassLibrary/Money/Currency/ICurrency.cs#L9)
  - Liskov Substitution: We can use Dollar and Euro classes instead of Money. [click](./ClassLibrary/Money/Currency/CurrencyClasses.cs#L10)
  - Interface Segregation: All interfaces are clearly defined with minimal, specialized methods or properties, ensuring that clients are not burdened with unused methods. [IMoney](./ClassLibrary/Money) [ICurrency](./ClassLibrary/Money/Currency) [IProductManager](./ClassLibrary/Product/Manager)
  - Dependency Inversion: All classes use interfaces or abstractions. [CurrencyClasses](./ClassLibrary/Money/Currency/CurrencyClasses.cs)
- YAGNI: I ensured that the program includes only necessary functionality, with all methods being actively utilized.
- Composition Over Inheritance: [IMoney](./ClassLibrary/Money) [ICurrency](./ClassLibrary/Money/Currency) [IProductManager](./ClassLibrary/Product/Manager) [IReporter](./ClassLibrary/Reporting/IReporter.cs) [IWarehouseProduct](./ClassLibrary/Warehouse/IWarehouseProduct.cs)
- Program to Interfaces not Implementations: For example, in the ProductManager class, I use IProduct instead of just the Product class, allowing it to work with all objects implementing the IProduct interface. [ProductManager](./ClassLibrary/Product/Manager/ProductManager.cs#L9)
- Fail Fast: Here are a few examples: [ProductManager](./ClassLibrary/Product/Manager/ProductManager.cs#L11) [Warehouse](./ClassLibrary/Warehouse/Warehouse.cs#L22) [IncomingProductReporter](./ClassLibrary/Reporting/Reporters/IncomingProductReporter.cs.cs#L26)
