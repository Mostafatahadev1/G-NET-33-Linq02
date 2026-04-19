namespace G_NET_33_Linq02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Product List
            var ProductList = new List<Product>
{
                new Product { ProductID = 1, Name = "Chai", UnitPrice = 18, UnitsInStock = 39, Category = "Beverages" },
                new Product { ProductID = 2, Name = "Chang", UnitPrice = 19, UnitsInStock = 17, Category = "Beverages" },
                new Product { ProductID = 3, Name = "Aniseed Syrup", UnitPrice = 10, UnitsInStock = 13, Category = "Condiments" },
                new Product { ProductID = 4, Name = "Chef Anton", UnitPrice = 22, UnitsInStock = 53, Category = "Condiments" },
                new Product { ProductID = 5, Name = "Ikura", UnitPrice = 31, UnitsInStock = 20, Category = "Seafood" },
                new Product { ProductID = 6, Name = "Konbu", UnitPrice = 6, UnitsInStock = 24, Category = "Seafood" },
                new Product { ProductID = 7, Name = "Tofu", UnitPrice = 23, UnitsInStock = 0, Category = "Produce" },
                new Product { ProductID = 8, Name = "Pavlova", UnitPrice = 45, UnitsInStock = 10, Category = "Desserts" },
                new Product { ProductID = 9, Name = "Alice Mutton", UnitPrice = 39, UnitsInStock = 0, Category = "Meat" },
                new Product { ProductID = 10, Name = "Carnarvon Tigers", UnitPrice = 62, UnitsInStock = 42, Category = "Seafood" },
                new Product { ProductID = 11, Name = "Teatime Chocolate", UnitPrice = 9, UnitsInStock = 25, Category = "Desserts" },
                new Product { ProductID = 12, Name = "Sir Rodney", UnitPrice = 81, UnitsInStock = 5, Category = "Confections" },
                new Product { ProductID = 13, Name = "Gnocchi", UnitPrice = 38, UnitsInStock = 21, Category = "Grains" },
                new Product { ProductID = 18, Name = "Maxilaku", UnitPrice = 20, UnitsInStock = 15, Category = "Confections" }
};
            #endregion

            #region Costumers List
            var CustomerList = new List<Customer>
                {
                    new Customer { CompanyName = "A Co", Country = "Germany", TotalOrderValue = 1000 },
                    new Customer { CompanyName = "B Co", Country = "France", TotalOrderValue = 2000 },
                    new Customer { CompanyName = "C Co", Country = "UK", TotalOrderValue = 1500 },
                    new Customer { CompanyName = "D Co", Country = "Germany", TotalOrderValue = 700 },
                    new Customer { CompanyName = "E Co", Country = "France", TotalOrderValue = 1200 }
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

            #region Question 3 
            //   var result = ProductList
            //        .OrderBy(p => p.UnitPrice)
            //        .TakeWhile(p => p.UnitPrice < 25)
            //        .ToList();
            //
            //   foreach (var product in result)
            //   {
            //       Console.WriteLine($"Name: {product.Name}, Price: {product.UnitPrice}");
            //   }
            #endregion

            #region Question 4
            // bool allInStock = ProductList
            //        .Where(p => p.Category == "Seafood")
            //        .All(p => p.UnitsInStock > 0);
            //
            // Console.WriteLine(allInStock);
            #endregion

            #region Question 5

            // int[] ids = { 3, 9, 13, 18 };
            // 
            //    var hashSet = ids.ToHashSet();
            // 
            //    var result = ProductList
            //            .Where(p => hashSet.Contains(p.ProductID))
            //            .ToList();



            // anather answer

            // bool exists = ids.Contains(9);
            //
            // Console.WriteLine(exists);

            #endregion

            #region Question 6
            // var GroupedProduct = ProductList
            //  .GroupBy(p => p.Category)
            //  .Select(g => new
            //         {
            //             Category = g.Key,
            //             Count = g.Count()
            //         });
            //
            // foreach (var item in GroupedProduct)
            // {
            //     Console.WriteLine($"Category: {item.Category} - Count: {item.Count}");
            // }
            //
            #endregion

            #region Question 7
            //  var GroupByName = ProductList
            //       .GroupBy(p => p.Category)
            //       .Select(g => new
            //           {
            //               Category = g.Key,
            //               Names = g.Select(p => p.Name)
            //           });
            //
            //  foreach (var group in GroupByName)
            //  {
            //      Console.WriteLine($"Category: {group.Category}");
            //
            //      foreach (var name in group.Names)
            //      {
            //          Console.WriteLine($"   - {name}");
            //      }
            //  }
            #endregion


            #region Question 8

            //  var GroupByFilter = ProductList
            //       .GroupBy(p => p.Category)
            //       .Where(g => g.Count() > 3)
            //       .Select(g => g.Key);
            //  foreach (var category in GroupByFilter)
            //  {
            //      Console.WriteLine(category);
            //  }

            #endregion


            #region Question 9

            // var GroupByCountryToTalOrder =
            //      from c in CustomerList
            //      group c by c.Country into g
            //      select new
            //      {
            //          Country = g.Key,
            //          Count = g.Count(),
            //          TotalOrderValue = g.Sum(x => x.TotalOrderValue)
            //      };
            //
            // foreach (var item in GroupByCountryToTalOrder)
            // {
            //     Console.WriteLine($"Country: {item.Country} | Count: {item.Count} | Total: {item.TotalOrderValue}");
            // }
            #endregion

            #region Question 10

            //  var TotalNumberOfUnitOfStock = ProductList
            //      .Sum(p => p.UnitsInStock);
            //
            //  Console.WriteLine($"Total Units In Stock = {TotalNumberOfUnitOfStock}");

            #endregion

            #region Question 11
            // var MinPrice = ProductList
            //     .Min(p => p.UnitPrice);
            // var MaxPrice = ProductList .Max(p=> p.UnitPrice);
            //
            // Console.WriteLine($"Cheapest Price = {MinPrice}");
            // Console.WriteLine($"Most Expensive Price = {MaxPrice}");

            #endregion

            #region Question 12
            // var DistinctList = ProductList
            //     .Select(p => p.Category)
            //     .Distinct()
            //     .ToList();
            //
            //
            // foreach  (var category in DistinctList)
            // {
            //     Console.WriteLine(category);
            // }
            #endregion

            #region Question 13
            // int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            // int[] setB = { 3, 6, 9, 12, 15, 13 };
            //
            // var AnotB = setA.Except(setB);
            //
            // foreach (var item in AnotB)
            // {
            //     Console.WriteLine(item);
            // }

            #endregion


            #region Question 14
          // string[] list1 = { "Germany", "France", "UK", "Spain" };
          // string[] list2 = { "france", "SPAIN", "Italy" };
          //
          //
          // var q14 = list1.Where(c =>
          //     !list2.Any(x => x.Equals(c, StringComparison.OrdinalIgnoreCase)));
          //
          // foreach (var country in q14)
          // {
          //     Console.WriteLine(country);
          // }

            #endregion

        }
    }
}
