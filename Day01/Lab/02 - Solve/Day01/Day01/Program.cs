using System;
using System.Globalization;
using static Day01.ListGenerators;
namespace Day01
{
    internal class Program
    {

        static void Main(string[] args)
        {

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
