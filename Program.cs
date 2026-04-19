namespace G_NET_33_Linq02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Product List
            var ProductList = new List<Product>
            {
                new Product { Name = "Chai", UnitPrice = 18, UnitsInStock = 39, Category = "Beverages" },
                new Product { Name = "Chang", UnitPrice = 19, UnitsInStock = 17, Category = "Beverages" },
                new Product { Name = "Aniseed Syrup", UnitPrice = 10, UnitsInStock = 13, Category = "Condiments" },
                new Product { Name = "Chef Anton's Cajun Seasoning", UnitPrice = 22, UnitsInStock = 53, Category = "Condiments" },
                new Product { Name = "Ikura", UnitPrice = 31, UnitsInStock = 20, Category = "Seafood" },
                new Product { Name = "Konbu", UnitPrice = 6, UnitsInStock = 24, Category = "Seafood" },
                new Product { Name = "Tofu", UnitPrice = 23, UnitsInStock = 0, Category = "Produce" }
            };
            #endregion

            #region Question 1 Get Top 3 Expensive Products

            //  var Top3ExpensiveProducts = ProductList
            //      .OrderByDescending(p => p.UnitPrice)
            //      .Take(3);
            //
            //  foreach (var product in Top3ExpensiveProducts)
            //  {
            //      Console.WriteLine($"Name: {product.Name}, Price: {product.UnitPrice}");
            //  }


            #endregion

            #region Question 2  Show page 2 with Page size 3
           //int pageNumber = 2;
           //int pageSize = 5;
           //
           //var result = ProductList
           //    .OrderBy(p => p.Name)
           //    .Skip((pageNumber - 1) * pageSize) 
           //    .Take(pageSize)
           //    .ToList();
           //
           //foreach (var product in result)
           //{
           //    Console.WriteLine(product.Name);
           //}

            #endregion


        }
    }
}
