using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            //var beveragesInStock = Source.ProductList
            //                       .Where(p => p.Category == "Beverages")
            //                       .OrderByDescending(p => p.UnitsInStock);

            //foreach (var item in beveragesInStock)
            //{
            //    Console.WriteLine($"Name: {item.ProductName}, Stock: {item.UnitsInStock}");
            //}



            #endregion

            #region 10. Using QUERY SYNTAX with a compound from clause, list all orders placed in 1997 or later showing CustomerID and OrderDate.

            //var ordersFrom1997 = from c in Source.CustomerList
            //                     from o in c.Orders
            //                     where o.OrderDate.Year >= 1997   
            //                     select new { c.CustomerID, o.OrderDate };

            //foreach (var item in ordersFrom1997)
            //{
            //    Console.WriteLine($"CustomerID: {item.CustomerID}, OrderDate: {item.OrderDate:yyyy/MM/dd}");
            //}

            #endregion

            #region 11. Show position number alongside ProductName

            //var productListWithPosition = Source.ProductList
            //    .Select((p, index) => new { Position = index + 1, ProductName = p.ProductName });

            //// Helping With Ai 

            //foreach (var item in productListWithPosition)
            //{
            //    Console.WriteLine($"{item.Position}. {item.ProductName}");
            //}

            #endregion

            #region 12. Sort first by-word length and then by a case -insensitive sort of the words in an array. String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var Array = new string[] { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sortedArr = Array.OrderBy(word => word.Length)
            //                      .ThenBy(word => word, StringComparer.OrdinalIgnoreCase);  // With Search and AI

            //foreach (var word in sortedArr)
            //{
            //    Console.WriteLine(word);
            //}


            #endregion

            #region 13. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

            var digits = new string[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine","Ten" };

            var filteredDigits = digits.Where(d => d.Length > 1 && d[1] == 'i')
                                       .Reverse();

            foreach (var digit in filteredDigits)
            {
                Console.WriteLine(digit);
            }



            #endregion

        }
    }
}
