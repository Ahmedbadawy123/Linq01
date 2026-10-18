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

            var sortedProducts = Source.ProductList.OrderBy(p => p.UnitPrice);
            
            foreach (var item in sortedProducts)
            {
                Console.WriteLine(item);
            }


            #endregion
        }
    }
}
