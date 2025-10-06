using System;
using System.Globalization;
using static Day01.ListGenerators;
namespace Day01
{
    internal class Program
    {

        static void Main(string[] args)
        {

            #region 01 - Restriction Operators

            #region Q01 - Find all products that are out of stock.

            //var res = ProductList.Where(p => p.UnitsInStock == 0);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q02 - Find all products that are in stock and cost more than 3.00 per unit.

            //var res = ProductList.Where(p => p.UnitsInStock != 0).Where(p => p.UnitPrice > (decimal)3);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q03 - Returns digits whose name is shorter than their value.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var res = Arr.Where((p, i) => p.Length < i);

            //foreach (var item in res)
            //{
            //    Console.Write($"{item} ");//five six seven eight nine
            //}

            #endregion

            #endregion

            #region 02 - Element Operator

            #region Q01 - Get first Product out of Stock 

            //var res = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);
            //var res02 = ProductList.Where(p => p.UnitsInStock == 0).FirstOrDefault();

            //Console.WriteLine(res);// ProductID:5,ProductName:Chef Anton's Gumbo Mix,CategoryCondiments,UnitPrice:21.3500,UnitsInStock:0
            //Console.WriteLine(res02);// ProductID:5,ProductName:Chef Anton's Gumbo Mix,CategoryCondiments,UnitPrice:21.3500,UnitsInStock:0

            #endregion

            #region Q02 - Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var res = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);//Null

            //Console.WriteLine(res);

            #endregion

            #region Q03 - Retrieve the second number .greater than 5 

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var res = Arr.Where(n => n > 5).Skip(1).First();

            //Console.WriteLine(res);//8

            #endregion

            #endregion

            #region 03 - Set Operators

            #region Q01 - Find the unique Category names from Product List

            //var res = ProductList.UnionBy(ProductList, p => p.Category).Select(p => new { Id = p.ProductID, p.Category });

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q02 - Produce a Sequence containing the unique first letter from both product and customer names.

            //var res = ProductList.Select(p => p.ProductName[0]).Union(CustomerList.Select(c => c.CustomerID[0]));

            //foreach (var item in res)
            //{
            //    Console.Write(value: $"{item} ");//C A G U N M I Q K T P S R B J Z V F E W L O D H
            //}

            #endregion

            #region Q03 - Create one sequence that contains the common first letter from both product and customer names.

            //var res = ProductList.Select(p => p.ProductName[0]).Intersect(CustomerList.Select(c => c.CustomerID[0]));

            //foreach (var item in res)
            //{
            //    Console.Write(value: $"{item} ");//C A G N M I Q K T P S R B V F E W L O
            //}

            #endregion

            #region Q04 - Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //var res = ProductList.Select(p => p.ProductName[0]).Except(CustomerList.Select(c => c.CustomerID[0]));

            //foreach (var item in res)
            //{
            //    Console.Write(value: $"{item} ");//U J Z
            //}

            #endregion

            #region Q05 - Create one sequence that contains the last Three Characters in each names of all customers and products, including any duplicates

            //var res = ProductList.Select(p => p.ProductName.Substring(p.ProductName.Length - 3)).Concat(CustomerList.Select(c => c.CustomerID.Substring(c.CustomerID.Length - 3)));

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion

            #region 04 - Aggregate Operators

            #region Q01 - Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var res = Arr.Count(n => n % 2 == 1);
            //Console.WriteLine(res);//5

            #endregion

            #region Q02 - Return a list of customers and how many orders each has.

            //var res = CustomerList.Select(c => new { c.CustomerID, Orders = c.Orders.Length });

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q03 - Return a list of categories and how many products each has

            //var res = ProductList.GroupBy(p => p.Category).Select(g => new {Category = g.Key,Count = g.Count()});

            //foreach (var group in res)
            //{
            //    Console.WriteLine(group);
            //}

            #endregion

            #region Q04 - Get the total of the numbers in an array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var res = Arr.Count();
            //Console.WriteLine(res);//10

            #endregion

            #region Q05 - Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] words;
            //try
            //{
            //    words = File.ReadAllLines("dictionary_english.txt");
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine($"Error reading file: {ex.Message}");
            //    words = Array.Empty<string>();
            //}

            //var res = words.Sum(w => w.Length);
            //Console.WriteLine(res);//3494678

            #endregion

            #region Q06 - Get the total units in stock for each product category.

            //var res = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, UnitsInStock = g.Sum(g => g.UnitsInStock) });

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q07 - Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] words;
            //try
            //{
            //    words = File.ReadAllLines("dictionary_english.txt");
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine($"Error reading file: {ex.Message}");
            //    words = Array.Empty<string>();
            //}

            //var res = words.Min(w => w.Length);
            //Console.WriteLine(res);//1

            ////To Get The Word
            ////string shortestWord = words.OrderBy(w => w.Length).First();
            ////int Length = shortestWord.Length;

            ////Console.WriteLine($"shortest Word = {shortestWord}\nLength = {Length}");


            #endregion

            #region Q08 - Get the cheapest price among each category's products

            //var res = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, CheapestPrice = g.Min(g => g.UnitPrice) });

            //foreach (var item in res)
            //{
            //    Console.WriteLine($"Category:{item.Category}, Cheapest Price: {item.CheapestPrice:c}");
            //}

            #endregion

            #region Q09 - Get the products with the cheapest price in each category (Use Let)

            //var res =
            //        from p in ProductList
            //        group p by p.Category into g
            //        let minPrice = g.Min(x => x.UnitPrice)
            //        from prod in g
            //        where prod.UnitPrice == minPrice
            //        select new
            //        {
            //            Category = g.Key,
            //            ProductName = prod.ProductName,
            //            Price = prod.UnitPrice
            //        };
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q10 - Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] words;
            //try
            //{
            //    words = File.ReadAllLines("dictionary_english.txt");
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine($"Error reading file: {ex.Message}");
            //    words = Array.Empty<string>();
            //}

            ////Length
            //var res = words.Max(w => w.Length);
            //Console.WriteLine(res);//31

            ////Word
            //var word = words.OrderByDescending(w => w.Length).First();
            //Console.WriteLine(word);//dichlorodiphenyltrichloroethane


            #endregion

            #region Q11 - Get the most expensive price among each category's products.

            //var res = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, expensivePrice = g.Max(p => p.UnitPrice) });

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q12 - Get the products with the most expensive price in each category.

            #region 01 - Query Suntax

            //var result = from p in ProductList
            //             group p by p.Category into g
            //             let maxPrice = g.Max(p => p.UnitPrice)
            //             from product in g
            //             where product.UnitPrice == maxPrice
            //             select new
            //             {
            //                 Category = g.Key,
            //                 ProductName = product.ProductName,
            //                 Price = product.UnitPrice
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Category: {item.Category} - ProductName: {item.ProductName} - Price: {item.Price:c}");
            //} 

            #endregion

            #region 02 - Fluent Syntax

            //var res = ProductList.GroupBy(p => p.Category)
            //                     .SelectMany(g =>
            //                     {
            //                         var minPrice = g.Min(x => x.UnitPrice);
            //                         return g.Where(p => p.UnitPrice == minPrice)
            //                                 .Select(p => new
            //                                 {
            //                                     Category = g.Key,
            //                                     ProductName = p.ProductName,
            //                                     Price = p.UnitPrice
            //                                 });
            //                     });

            //foreach (var item in res)
            //{
            //    Console.WriteLine($"Category: {item.Category} - ProductName: {item.ProductName} - Price: {item.Price:c}");
            //} 

            #endregion

            #endregion

            #region Q13 - Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] words;
            //try
            //{
            //    words = File.ReadAllLines("dictionary_english.txt");
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine($"Error reading file: {ex.Message}");
            //    words = Array.Empty<string>();
            //}

            //var res = words.Average(w => w.Length);
            //Console.WriteLine($"{res:F2}");//9.44


            #endregion

            #region Q14 - Get the average price of each category's products.

            //var res = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, AvgPrice = g.Average(x => x.UnitPrice) });

            //foreach (var item in res)
            //{
            //    Console.WriteLine($"Category = {item.Category} - AvgPrice = {item.AvgPrice:c2}");
            //}

            #endregion

            #endregion

            #region 05 - Ordering Operators

            #region Q01 - Sort a list of products by name

            //var res = ProductList.OrderBy(p => p.ProductName);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q02 - Uses a custom comparer to do a case-insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var res = Arr.OrderBy(str => str, new StringComparer());
            //foreach (var item in res)
            //{
            //    Console.Write($"{item} ");//AbAcUs aPPLE BlUeBeRrY bRaNcH cHeRry ClOvEr
            //}

            #endregion

            #region Q03 - Sort a list of products by units in stock from highest to lowest.

            //var res = ProductList.OrderByDescending(p => p.UnitPrice);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q04 - Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var res = Arr.OrderBy(str => str.Length).ThenBy(str => str);

            //foreach (var item in res)
            //{
            //    Console.Write($"{item} ");//one six two five four nine zero eight seven three
            //}

            #endregion

            #region Q05 - Sort first by word length and then by a case-insensitive sort of the words in an array.

            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var res = words.OrderBy(str => str.Length).ThenBy(str => str, new StringComparer());

            //foreach (var item in res)
            //{
            //    Console.Write($"{item} ");//aPPLE AbAcUs bRaNcH cHeRry ClOvEr BlUeBeRrY
            //}

            #endregion

            #region Q06 - Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var res = ProductList.OrderByDescending(p => p.Category).ThenByDescending(p => p.UnitPrice);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q07 - Sort first by word length and then by a case-insensitive descending sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var res = Arr.OrderByDescending(str => str.Length).ThenByDescending(str => str);

            //foreach (var item in res)
            //{
            //    Console.Write($"{item} ");//BlUeBeRrY ClOvEr cHeRry bRaNcH AbAcUs aPPLE
            //}

            #endregion

            #region Q08 - Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var res = Arr.Reverse().Where(str => str[1] == 'i');

            //foreach (var item in res)
            //{
            //    Console.Write($"{item} ");//nine eight six five
            //}

            #endregion

            #endregion

            #region 06 - Partitioning Operators

            #region Q01 - Get the first 3 orders from customers in Washington

            //var res = CustomerList.Where(c => c.Country == "Mexico").SelectMany(c => c.Orders).Take(3);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q02 - Get all but the first 2 orders from customers in Washington.

            //var res = CustomerList.Where(c => c.Country == "Mexico").GroupBy(c => c.CustomerID).Select(g => new { Customer = g.Key, Orders = g.SelectMany(c => c.Orders.Take(2)) });

            //foreach (var item in res)
            //{
            //    Console.WriteLine($"{item.Customer}:");
            //    foreach (var order in item.Orders)
            //    {
            //        Console.WriteLine($"- {order}");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Q03 - Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = numbers.TakeWhile((n, i) => n >= i);

            //foreach (var item in res)
            //{
            //    Console.Write($"{item} ");
            //}

            #endregion

            #region Q04 - Get the elements of the array starting from the first element divisible by 3.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = numbers.SkipWhile(n => n % 3 != 0);

            //foreach (var item in res)
            //{
            //    Console.Write($"{item} ");//3 9 8 6 7 2 0
            //}

            #endregion

            #region Q05 - Get the elements of the array starting from the first element less than its position.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = numbers.SkipWhile((n, i) => n > i);

            //foreach (var item in res)
            //{
            //    Console.Write($"{item} ");//1 3 9 8 6 7 2 0
            //}

            #endregion

            #endregion

            #region 07 - Projection Operators

            #region Q01 - Return a sequence of just the names of a list of products.

            //var res = ProductList.Select(p => p.ProductName);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q02 - Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).

            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var res = words.Select(w => new { Lower = w.ToLower(), Upper = w.ToUpper() });

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q03 - Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

            //var res = ProductList.Select(p => new { Name = p.ProductName, Price = p.UnitPrice });

            //foreach (var item in res)
            //{
            //    Console.WriteLine($"Name:{item.Name}, Price:{item.Price:c}");
            //}

            #endregion

            #region Q04 - Determine if the value of ints in an array match their position in the array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var res = Arr.Select((n, i) => new { num = n, InPlace = (n == i) });

            //Console.WriteLine("Number:In-Place?");
            //foreach (var item in res)
            //{
            //    Console.WriteLine($"{item.num}:{item.InPlace}");
            //}

            #endregion

            #region Q05 - Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var res = numbersA.SelectMany(a => numbersB, (a, b) => new { a, b }).Where(pair => pair.a < pair.b);

            //Console.WriteLine("Pairs Where a < b:");
            //foreach (var item in res)
            //{
            //    Console.WriteLine($"{item.a} is less than {item.b}");
            //}

            #endregion

            #region Q06 - Select all orders where the order total is less than 500.00.

            //var res = CustomerList.SelectMany(c => c.Orders).Where(c => c.Total < 500);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q07 - Select all orders where the order was made in 1998 or later.

            //var res = CustomerList.SelectMany(c => c.Orders).Where(o => o.OrderDate.Year >= 1998);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion

            #region 08 - Quantifiers Operators

            #region Q01 - Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.

            //string[] words;
            //try
            //{
            //    words = File.ReadAllLines("dictionary_english.txt");
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine($"Error reading file: {ex.Message}");
            //    words = Array.Empty<string>();
            //}

            //var res = words.Any(str => str.Contains("ei"));

            //Console.WriteLine(res);//True

            #endregion

            #region Q02 - Return a grouped a list of products only for categories that have at least one product that is out of stock.

            //var res = ProductList.GroupBy(p => p.Category).Where(g => g.Any(p => p.UnitsInStock == 0)).Select(g => new { Category = g.Key, Products = g });

            //foreach (var item in res)
            //{
            //    Console.WriteLine($"{item.Category}:");
            //    foreach (var p in item.Products)
            //    {
            //        Console.WriteLine($"  ProductName:{p.ProductName} - Stock:{p.UnitsInStock}");
            //    }
            //}

            #endregion

            #region Q03 - Return a grouped a list of products only for categories that have all of their products in stock.

            //var res = ProductList.GroupBy(p => p.Category).Where(g => g.All(p => p.UnitsInStock != 0)).Select(g => new { Category = g.Key, Products = g });

            //foreach (var item in res)
            //{
            //    Console.WriteLine($"{item.Category}:");
            //    foreach (var p in item.Products)
            //    {
            //        Console.WriteLine($"  ProductName:{p.ProductName} - Stock:{p.UnitsInStock}");
            //    }
            //}

            #endregion

            #endregion

        }

        static void Demo(string[] args)
        {

            #region Products Out Of Stock

            //01 - Fluent Syntax
            //var PoutOfStock01 = ProductList.Where(p => p.UnitsInStock == 0);

            //foreach (var product in PoutOfStock01)
            //{
            //    Console.WriteLine(product);
            //}

            ////02 - Query Syntax
            //var PoutOfStock02 = from p in ProductList
            //                  where p.UnitsInStock == 0
            //                  select p;

            //foreach (var product in PoutOfStock02)
            //{
            //    Console.WriteLine(product);
            //}

            ////03 - Static Method
            //var PoutOfStock03 = Enumerable.Where(ProductList, p => p.UnitsInStock == 0);

            //foreach (var product in PoutOfStock03)
            //{
            //    Console.WriteLine(product);
            //}

            #endregion

            #region Select() - Projection (Select)-> Transform the result returned into new Form.

            //var result = ProductList.Where(p => p.UnitsInStock == 0)
            //                        .Select(p => new { Name = p.ProductName, Price =  p.UnitPrice});

            //foreach (var product in result)
            //{
            //    Console.WriteLine(product);
            //} 

            #endregion

            #region Ordering Operators => OrderBy() - OrderByDescending() - ThenBy()

            #region OrderBy()

            //var result = ProductList.Where(p => p.UnitsInStock == 0)
            //                        .OrderBy(p => p.UnitPrice)
            //                        .Select(p => new { Name = p.ProductName, Price = p.UnitPrice });

            //foreach (var product in result)
            //{
            //    Console.WriteLine(product);
            //} 

            #endregion

            #region OrderByDescending()

            //var result = ProductList.Where(p => p.UnitsInStock == 0)
            //                        .OrderByDescending(p => p.UnitPrice)
            //                        .Select(p => new { Name = p.ProductName, Price = p.UnitPrice });

            //foreach (var product in result)
            //{
            //    Console.WriteLine(product);
            //} 

            #endregion

            #region OrderBy().ThenBy()

            //var result = ProductList
            //                        //.Where(p => p.UnitsInStock == 0)
            //                        .OrderBy(p => p.UnitPrice)
            //                        .ThenByDescending(p => p.ProductName)//Mean That If 2 products with same price, then order Descending(Z -> A) based on the name.
            //                        .Select(p => new { Name = p.ProductName, Price = p.UnitPrice });

            //foreach (var product in result)
            //{
            //    Console.WriteLine(product);
            //} 

            ////Query Syntax
            //var result = from p in ProductList
            //             orderby p.UnitPrice,
            //             p.ProductName descending
            //             select new { p.ProductName, p.UnitPrice };

            //foreach (var product in result)
            //{
            //    Console.WriteLine(product);
            //}

            #endregion

            #endregion

            #region Generator Operators => Range() - Repeat() - Empty()

            #region Range()

            //var numbers = Enumerable.Range(1, 10);

            //foreach (var item in numbers)
            //{
            //    Console.Write($"{item} ");//1 2 3 4 5 6 7 8 9 10
            //} 

            #endregion

            #region Repeat()

            //var result = Enumerable.Repeat(ProductList[0], 5);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.ProductName} - {item.UnitPrice}");
            //}
            ////Chai - 18.0000
            ////Chai - 18.0000
            ////Chai - 18.0000
            ////Chai - 18.0000  

            #endregion

            #region Empty()

            //var res = Enumerable.Empty<Product>();
            ////res is an empty IEnumerable<Product>

            #endregion

            #endregion

            #region Take()

            ////Fluent Syntax
            //var result = ProductList.Where(p => p.UnitsInStock == 0).Take(1);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);//ProductID:5,ProductName:Chef Anton's Gumbo Mix,CategoryCondiments,UnitPrice:21.3500,UnitsInStock:0
            //}

            ////Query Syntax
            //var result02 = (from p in ProductList
            //                where p.UnitsInStock == 0
            //                select p).Take(1);

            //foreach (var item in result02)
            //{
            //    Console.WriteLine(item);//ProductID:5,ProductName:Chef Anton's Gumbo Mix,CategoryCondiments,UnitPrice:21.3500,UnitsInStock:0
            //}  

            #endregion

            #region TakeWhile()

            //var res = ProductList.TakeWhile(p => p.UnitsInStock != 0);
            ////Mean That Take The Products that p.UnitsInStock!=0
            ////Until found product that p.UnitsInStock == 0 => STOP.

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            ////ProductID:1,ProductName:Chai,CategoryBeverages,UnitPrice:18.0000,UnitsInStock:39
            ////ProductID:2,ProductName:Chang,CategoryBeverages,UnitPrice:19.0000,UnitsInStock:17
            ////ProductID:3,ProductName:Aniseed Syrup,CategoryCondiments,UnitPrice:10.0000,UnitsInStock:13
            ////ProductID:4,ProductName:Chef Anton's Cajun Seasoning,CategoryCondiments,UnitPrice:22.0000,UnitsInStock:53

            #endregion

            #region Skip()

            //var res = ProductList.Skip(2);
            ////Res will contain all products except first 2 products.

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region SkipWhile()

            //var res = ProductList.SkipWhile(p => p.UnitsInStock != 0);
            ////Mean That Skip The Products that p.UnitsInStock!=0
            ////Until found product that p.UnitsInStock == 0 => STOP Skipping And Take Rest Of Products.
            ////Containing the product which stop on.

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Pagination using Skip() & Take() to view Products 10 by ten on console Instead Of View It Once.

            //int numberOfProductsPages = ProductList.Count / 10;//7.7

            ////i -> Represent The Page number.
            //for (int i = 0; i < numberOfProductsPages + 1/*to view the last page (8)*/; i++)
            //{
            //    var res = ProductList.Skip(i * 10).Take(10);
            //    foreach (var item in res)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    Console.ReadLine();//Wait To Enter Any Thing
            //    Console.Clear();
            //} 

            #endregion

            #region Single Element Operators => First() - FirstOrDefault() - Single() - SingleOrDefault() - ElementAt() - ElementAtOrDefault() -> Immediate Execution

            #region First() -> Return One Element (Immediate Execution)&(Can't use with Query Syntax)

            //var result = ProductList.First(p => p.UnitsInStock == 0);
            ////Return First Product Which Has p.UnitsInStock = 0.
            ////Exception if there are no products that p.UnitsInStock = 0.

            //Console.WriteLine(result);//ProductID:5,ProductName:Chef Anton's Gumbo Mix,CategoryCondiments,UnitPrice:21.3500,UnitsInStock:0

            ////If there are more than one product meet the condition 
            ////Return the first one only.
            ////Not Exception

            #endregion

            #region FirstOrDefault()

            //var result = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);
            ////Return First Product Which Has p.UnitsInStock = 0.
            ////Return The Default Value Of Type if no elements match condition
            ////In this case Return Null if there are no products that p.UnitsInStock = 0.
            //if(result != null)
            //    Console.WriteLine(result);//ProductID:5,ProductName:Chef Anton's Gumbo Mix,CategoryCondiments,UnitPrice:21.3500,UnitsInStock:0
            //else
            //    Console.WriteLine("No Products Out Of Stock!");

            ////If there are more than one product meet the condition 
            ////Return the first one only.
            ////Not Exception

            #endregion

            #region Single() -> Return One Element (Immediate Execution)&(Can't use with Query Syntax) => Used To Check PK not repeated because it throw exception if there are many elements meet the condition (if the condition is on the PK).

            //var result = ProductList.Single(p => p.UnitsInStock == 0);
            ////Return First Product Which Has p.UnitsInStock = 0.
            ////Exception if no elements match the condition.
            ////Exception if there are many products with the same p.UnitsInStock = 0.

            //Console.WriteLine(result);//System.InvalidOperationException: Sequence contains more than one matching element

            #endregion

            #region SingleOrDefault()

            //var result = ProductList.SingleOrDefault(p => p.UnitsInStock == 0);
            ////Return First Product Which Has p.UnitsInStock = 0.
            ////Return The Default Value Of Type if no element match condition
            ////In this case Return Null if there are no products that p.UnitsInStock = 0.
            ////Exception if there are more than one product match the condition.

            //if (result != null)
            //    Console.WriteLine(result);// System.InvalidOperationException: Sequence contains more than one matching element
            //else
            //    Console.WriteLine("No Products Out Of Stock!");

            #endregion

            #region ElementAt()

            //var res = ProductList.ElementAt(3);
            //Console.WriteLine(res);//ProductID:4,ProductName:Chef Anton's Cajun Seasoning,CategoryCondiments,UnitPrice:22.0000,UnitsInStock:53

            //res = ProductList.ElementAt(170);
            //Console.WriteLine(res);//System.ArgumentOutOfRangeException: Index was out of range. Must be non-negative and less than the size of the collection. (Parameter 'index')

            #endregion

            #region ElementAtOrDefault()

            //var res = ProductList.ElementAtOrDefault(150);//return null (Default Of Reference Types)

            //Console.WriteLine(res);

            #endregion

            #endregion

            #region Aggregate Operators =>  Count() - Min() - MinBy() - Max() - MaxBy() - Average() -> Immediate Execution

            #region Count()

            ////Number Of Products out of stock
            ////01
            //var res = ProductList.Where(p => p.UnitsInStock == 0).Count();
            //Console.WriteLine(res);//5

            //02
            //var res02 = ProductList.Count(p => p.UnitsInStock == 0);
            //Console.WriteLine(res02);//5

            #endregion

            #region Min()

            ////Minimum Product Price
            //var res = ProductList.Min(p => p.UnitPrice);

            //Console.WriteLine($"{res:c}");//$2.50 

            #endregion

            #region MinBy()

            //var res = ProductList.MinBy(p => p.UnitPrice);
            ////Return The Min Product base On Unit Price
            //Console.WriteLine(res);//ProductID:33,ProductName:Geitost,CategoryDairy Products,UnitPrice:2.5000,UnitsInStock:112

            #endregion

            #region Max()

            ////Maximum Product Price
            //var res = ProductList.Max(p => p.UnitPrice);

            //Console.WriteLine($"{res:c}");//$263.50

            #endregion

            #region MaxBy()

            //var res = ProductList.MaxBy(p => p.UnitPrice);
            ////Return The Max Product base On Unit Price
            //Console.WriteLine(res);//ProductID:38,ProductName:Côte de Blaye,CategoryBeverages,UnitPrice:263.5000,UnitsInStock:17

            #endregion

            #region Average()

            //var res = ProductList.Average(p => p.UnitPrice);
            //Console.WriteLine($"{res:C2}");//$28.87 

            #endregion


            //var result = ProductList.Max();//Work Only If Class Product Implement IComparable<Product> to provide implementation to Compare() method to know what will compare based on to get the max product and min product.
            //Console.WriteLine(result);

            #endregion

            #region Set Operators => Concat() - Union() - UnionBy() - Intersect() - IntersectBy() - Except() - ExceptBy()

            //var l1 = Enumerable.Range(1, 10);
            //var l2 = Enumerable.Range(5, 10);

            //Console.WriteLine("=========== L1 ==========");
            //foreach (var item in l1)
            //{
            //    Console.Write($"{item} ");//1 2 3 4 5 6 7 8 9 10
            //}
            //Console.WriteLine("\n=========== L2 ==========");
            //foreach (var item in l2)
            //{
            //    Console.Write($"{item} ");//5 6 7 8 9 10 11 12 13 14
            //}

            #region Union() -> Without Repeat

            //var res = l1.Union(l2);
            //Console.WriteLine("\n=========== Union ==========");
            //foreach (var item in res)
            //{
            //    Console.Write($"{item} ");//1 2 3 4 5 6 7 8 9 10 11 12 13 14
            //}

            #endregion

            #region Concat() -> Concat 2 sequences with Repeat

            //Console.WriteLine("\n========= l1 Concat l2 ==============");
            //var result = l1.Concat(l2);

            //foreach (var item in result)
            //{
            //    Console.Write($"{item} ");//1 2 3 4 5 6 7 8 9 10 5 6 7 8 9 10 11 12 13 14
            //}

            #endregion

            #region UnionBy() -> If The Elements Of The Sequence are objects

            #endregion

            #region Intersect()

            //var res = l1.Intersect(l2);
            //Console.WriteLine("\n=========== Intersect ==========");
            //foreach (var item in res)
            //{
            //    Console.Write($"{item} ");//5 6 7 8 9 10
            //}

            #endregion

            #region IntersectBy()

            #endregion

            #region Except()

            //var res = l1.Except(l2);
            ////Elements in l1 but not in l2
            //Console.WriteLine("\n=========== L1 Except L2 ==========");
            //foreach (var item in res)
            //{
            //    Console.Write($"{item} ");//1 2 3 4
            //}

            #endregion

            #region ExceptBy()

            #endregion

            #endregion


            //Search => GroupBy() - Let() - Zip() - Quantifiers Operators(True/False) -> Any() & All() - Casting Operators (Immediate Execution).

        }
    }
}
