namespace Linq01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Get all products from the "Seafood" category. Print each product's name and price.

            var seafoodProducts = Source.ProductList.Where(p => p.Category == "Seafood");

            foreach (var p in seafoodProducts)
            {
                Console.WriteLine($"Name: {p.ProductName}, Price: {p.UnitPrice:C2}");
            }
        }
    }
}
