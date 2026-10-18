using System.Drawing;
using System.Xml.Linq;

namespace Linq01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Get all products from the "Seafood" category. Print each product's name and price.

            //var seafoodProducts = Source.ProductList.Where(p => p.Category == "Seafood");

            //foreach (var p in seafoodProducts)
            //{
            //    Console.WriteLine($"Name: {p.ProductName}, Price: {p.UnitPrice:C2}");
            //}

            #endregion

            #region 2. Get a list of only the product names from ProductList. Print each name.
            //// Method syntax
            //var productNames = Source.ProductList.Select(p => p.ProductName);

            //foreach (var name in productNames)
            //{
            //    Console.WriteLine(name);
            //}
            //// Query syntax
            //var productNames2 = from p in Source.ProductList
            //                    select p.ProductName;
            //foreach (var name in productNames2)
            //{
            //    Console.WriteLine(name);
            //}


            #endregion

            #region 3. Sort all products by UnitPrice (ascending). Print each product's name and price.

            //var sortedProducts = Source.ProductList.OrderBy(p => p.UnitPrice);

            //foreach (var item in sortedProducts)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region 4. Get all products where UnitPrice is between 10 and 30

            //var productsInRange = Source.ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);

            //foreach (var item in productsInRange)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 5. Get all products that are in stock (UnitsInStock > 0) and belong to the "Condiments" category.

            //var condimentsInStock = Source.ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");

            //foreach (var item in condimentsInStock)
            //{
            //    Console.WriteLine(item);
            //}
            //// Why Their is no output?.


            #endregion

            #region 6. Create a new anonymous type with three properties:
            //● Name → the product name
            //● Price → the unit price
            //● StockStatus → a string: "Available" if UnitsInStock > 0,otherwise "Out of Stock"
            //● Print the result.

            //var anonymousProductList = Source.ProductList
            //.Select(p => new { Name = p.ProductName, Price = p.UnitPrice, StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock" });

            //foreach (var item in anonymousProductList)
            //{
            //    Console.WriteLine(item);
            //}

            // Helping With Ai 

            #endregion

            #region 7. Print each product's name along with its position (1-based) in the list. Expected format: 1.Chai, 2.Chang, etc.

            //var productListWithIndex = Source.ProductList
            //    .Select((p, index) => new { Index = index + 1, ProductName = p.ProductName });

            //foreach (var item in productListWithIndex)
            //{
            //    Console.WriteLine($"{item.Index}. {item.ProductName}");
            //}

            #endregion

            #region 8. Sort ProductList by Category ascending, then within each category, sort by UnitPrice descending.

            //var sortedProductListByCategoryAndPrice = Source.ProductList
            //                                          .OrderBy(p => p.Category)
            //                                          .ThenByDescending(p => p.UnitPrice);

            //foreach (var item in sortedProductListByCategoryAndPrice)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region 9. Get all products from the "Beverages" category, sorted by UnitsInStock descending. Print name and stock.

            var beveragesInStock = Source.ProductList
                                   .Where(p => p.Category == "Beverages")
                                   .OrderByDescending(p => p.UnitsInStock);
           
            foreach (var item in beveragesInStock)
            {
                Console.WriteLine($"Name: {item.ProductName}, Stock: {item.UnitsInStock}");
            }



            #endregion
        }
    }
}
