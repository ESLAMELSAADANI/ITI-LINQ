using static ConsoleApp1.ListGenerator;
using ConsoleApp1;
using System.Runtime.ExceptionServices;
#region set operators
//groupby , let , zip
var l1=Enumerable.Range(1, 10);
var l2=Enumerable.Range(5, 10);
Console.WriteLine("============l1==========");

foreach (var item in l1)
{
    Console.Write(item+" ");
}
Console.WriteLine();
Console.WriteLine("============l2=========="); 
foreach (var item in l2)
{
    Console.Write(item + " ");
}
var res=l1.Intersect(l2);
Console.WriteLine();
Console.WriteLine("===========interseect");
foreach (var item in res)
{
    Console.Write(item + " ");
}
var res2 = l1.Union(l2);
Console.WriteLine();
Console.WriteLine("===========union");
foreach (var item in res2)
{
    Console.Write(item + " ");
}
var res3 = l1.Concat(l2);
Console.WriteLine();
Console.WriteLine("===========concat");
foreach (var item in res3)
{
    Console.Write(item + " ");
}
#endregion

#region aggrgate operators
//var res= ProductList.Count();
//var res = ProductList.Where(s=>s.UnitsInStock==0).Count();
//var res = ProductList.Count(s=>s.UnitsInStock==0);
//var res = ProductList.MaxBy(s => s.UnitPrice);
//var res = ProductList.Max(s => s.UnitPrice);
//var res = ProductList.Min(s => s.UnitPrice);
//var res = ProductList.MinBy(s => s.UnitPrice);
//var res = ProductList.Max();

//Console.WriteLine(res);
#endregion
#region single element operators first , firstordefault , single , singleordefault , elementat , elementatordefault
//var res = ProductList.First(s=>s.UnitsInStock==1);
//var res = ProductList.FirstOrDefault(s => s.UnitsInStock == 0);
//var res = ProductList.Single(s => s.ProductID == 577);
//var res = ProductList.SingleOrDefault(s => s.ProductID == 5);
//var res =ProductList.ElementAtOrDefault(100);
//Console.WriteLine(res);
#endregion
#region natural order operators take takewhile skip skipwhile   
//var res = ProductList.Where(p=>p.UnitsInStock==0).Take(2);
//var res= ProductList.TakeWhile(p=>p.UnitsInStock!=0);
//var res = (from p in ProductList
//           where p.UnitsInStock == 0
//           select p).Take(2);
//var res = ProductList.Skip(5);
//var res= ProductList.SkipWhile(p => p.UnitsInStock != 0);
//pagination
//int n = ProductList.Count / 10;
//for(int i = 0; i < n + 1; i++)
//{
//    var res = ProductList.Skip(i * 10).Take(10);
//    foreach (var item in res)
//    {
//        Console.WriteLine(item);
//    }
//    Console.ReadLine();
//    Console.Clear();
//}
#endregion
//foreach (var item in res)
//{
//    Console.WriteLine(item);
//}






#region where select orderby
//var res = ProductList //method syntax fluent syntax valid for all operators
//              .Where(p => p.UnitsInStock == 0)
//    .OrderBy(p => p.UnitPrice)
//    .ThenByDescending(p => p.ProductName);
//   // .Select(p=>new { Name=p.ProductName,price=p.UnitPrice});
//var res1=from p in ProductList//query syntax valid only 12 operators
//         //where p.UnitsInStock==0
//         orderby p.UnitPrice descending, p.ProductName descending
//         select p;
//var res2=Enumerable.Where(ProductList,a=>a.UnitsInStock==0);//static syntax , valid for all operators

//foreach (var item in res1)
//{
//    Console.WriteLine(item);
//}
#endregion



#region WHERE operator
//List<int> numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15 };
//static syntax , valid for all operators
//var res =Enumerable.Where(numbers, a => a % 2 == 0);
//Method syntax , valid for all operators fluent syntax
//where is deferred execution
// tolist() , toarray() , todictionary() are immediate execution
//var res = numbers
//    .Where(a => a % 2 == 1).ToList();
//query syntax , valid only 12 operators
//var res = (from n in numbers
//           where n % 2 == 0
//           select n).ToList();

//numbers.Add(16);
//numbers.Add(17);
//numbers.Add(18);
//numbers.Add(19);



//foreach (var item in res)
//{
//    Console.WriteLine(item);
//}
//numbers.Add(20);
//numbers.Add(21);
//Console.WriteLine("============");
//foreach (var item in res)
//{
//    Console.WriteLine(item);
//}
#endregion
#region extension methods
// extension methods are static methods defined in static classes
// the first parameter of an extension method specifies the type it extends and is prefixed with the this keyword
//int x = 30;
//x.Print();
//IntExtension.Print(x);
//Employee e = new Employee() { Id = 6, Name = "sara", Salary = 3000 };
//e.Print();
#endregion
#region anonymous types
/// anonymous types are reference types
/// immutable conatins read only properties
/// overrides ToString(), Equals(), GetHashCode()
/// created using new keyword and object initializer syntax
//var s1 = new { Id = 5, Name = "aly" };
//var s2 = new { Id = 50, Name = "aly" };
//var s3 = new { Id = 5, Name = "aly" ,Age=30};

//Console.WriteLine(s1.GetType());
//Console.WriteLine(s2.GetType());
//Console.WriteLine(s3.GetType());



//Console.WriteLine(s1);

//if(s1.Equals(s2))
//{
//    Console.WriteLine("Equal");
//}
//else
//{
//    Console.WriteLine("Not Equal");
//}

//Employee e=new Employee() { Id=1,Name="John",Salary=50000};
//Console.WriteLine(e);
#endregion
#region var keyword
//var keyword is used to declare implicitly typed local variables
//var cannot be used for class level variables, method parameters, return types
//var x = 10; // int
//var y = "Hello"; // string
#endregion