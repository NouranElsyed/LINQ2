using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using static LINQ2.ListGenerators;

namespace LINQ2

{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Filteration operators
            //where
            //fluent syntax
            /*var Result =  ProductList.Where(P=>P.UnitsInStock==0);*/
            // Query syntax
            /*Result = from P in ProductList
                     where P.UnitsInStock == 0
                     select P;*/

            /* var Result = ProductList.Where(P => P.Category == "Meat/Poultry" && P.UnitsInStock > 0);
             Result = from P in ProductList
                     where P.UnitsInStock > 0&& P.Category == "Meat/Poultry"
                      select P;*/

            //indexed where // only valid in fluent syntax
            //var Result = ProductList.Where((P, I) => P.UnitsInStock == 0 && I < 20);
            //var Result = ProductList.Where((P, I) => I < 5 & P.UnitsInStock > 0);
            //foreach (var Unit in Result)
            //{
            //    Console.WriteLine(Unit);
            //}
            #endregion

            #region Transformation Operators 
            //var Result = ProductList.Select(p => p.ProductName);
            //var Result = ProductList.Select(P =>  new { P.ProductID,P.ProductName } );
            //var Result = from P in ProductList
            //             select P.ProductName;
            //var Result = from P in ProductList
            //             select new { P.ProductID, P.ProductName };
            //var Result = CustomerList.SelectMany(C => C.Orders);

            //var Result = from C in CustomerList
            //             from O in C.Orders
            //             select O;

            //var Result = ProductList.Where(P => P.UnitsInStock > 0).Select(P =>
            //new
            //{
            //    P.ProductID,
            //    P.ProductName,
            //    NewPrice = P.UnitPrice * 0.9M
            //}
            //);
            //var Result = ProductList.Select((P, I) => new { IndexBeginWith1=I+1, P.ProductName });
            //foreach (var item in Result ) 
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Ordering Operators
            //var Result = ProductList.OrderBy(P => P.UnitPrice);
            //var Result = from P in ProductList 
            //             orderby P.UnitPrice ascending
            //             select P;
            //var Result = ProductList.Select(P => new { P.ProductName,P.UnitsInStock,P.UnitPrice})
            //.OrderBy(P =>P.UnitsInStock )
            //.ThenBy(P=>P.UnitPrice).ToList();
            //var Result = from P in ProductList
            //             orderby P.UnitsInStock, P, P.UnitPrice
            //             select new
            //             {
            //                 P.ProductName,
            //                 P.UnitsInStock,
            //                 P.UnitPrice
            //             };

            //var Result = ProductList.Reverse<Product>();

            //foreach (var Item in Result)
            //{
            //    Console.WriteLine(Item);
            //}
            #endregion

            #region Element Operators 

            //var Result = ProductList.First();
            //var Result = ProductList.Last();

            //var Result = ProductList.FirstOrDefault(); // default for empty null

            //var Result = ProductList.LastOrDefault();
            //var Result = ProductList.FirstOrDefault(P=>P.UnitsInStock==1000,new Product (){ProductName="default" } );

            //var Result = ProductList.ElementAt(1);// my throw exception
            //var Result = ProductList.ElementAtOrDefault(1);

            //var Result = ProductList.Single(); // may throw exception if there is zero or more than one element.

            //var Result = ProductList.SingleOrDefault();  // my throw execption if there are more than one element

            //var Result = ProductList.Single(P=>P.UnitPrice==1500);

            // var Result = ProductList.DefaultIfEmpty(new Product() {ProductName="empty" });
            //Console.WriteLine(Result);

            #endregion

            #region Aggregate Operators 
            //var Result = ProductList.Count();
            //var Result = ProductList.Count(P=>P.UnitsInStock==0);


            //var Result = ProductList.Sum(P=>P.UnitPrice);

            //var Result = ProductList.Average(P=>P.UnitPrice);

            //var Result = ProductList.Max(P=>P.UnitPrice);
            //var Result = ProductList.Max(new compareProductBsedonNameLength() );
            //var Result = ProductList.Max(new compareProductBsedonUnitPrice());
            //var Result = ProductList.Max();
            //var Result = ProductList.MaxBy(P => P.UnitPrice);
            //List<string> Names = new List<string>() { "Ahmed","Ali","Omar","Mohamed"};

            //var Result = Names.Aggregate((str01, str02) => $"{str01} {str02}");
            //Console.WriteLine(Result);

            #endregion

            #region  Casting Operators 
            //List<Product>Result=ProductList.Where(P => P.UnitsInStock == 0).ToList();
            //Product[]Result=ProductList.Where(P => P.UnitsInStock == 0).ToArray();
            //Dictionary<long,Product> Result = ProductList.Where(P => P.UnitsInStock == 0).ToDictionary(P=>P.ProductID);
            //HashSet<Product> Result = ProductList.Where(P => P.UnitsInStock == 0).ToHashSet();

            #endregion

            #region Generation Operators
            //var Result = Enumerable.Range(10, 50);

            //var Result = Enumerable.Repeat(new Product() { ProductName = "Repeated Product" }, 100);

            //var Result = Enumerable.Empty<Product>();

            //foreach (var item in Result) 
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Set Operators
            //var Seq001 = Enumerable.Range(0,100);
            //var Seq002 = Enumerable.Range(50, 100);
            //var Result = Seq001.Union(Seq002);
            //var Result = Seq001.Concat(Seq002);
            //var Result = Seq002.Intersect(Seq001);
            //var Result = Seq002.Except(Seq001);


            // foreach (var item in Result)
            //{
            //  Console.WriteLine(item);
            //}
            #endregion

            #region Quantifier Operators 
            // ProductList = new List<Product>();
            // var Result = ProductList.Any(P=>P.UnitsInStock>100);
            //var Result = ProductList.All(P=>P.UnitPrice>0);

            //var Seq001 = Enumerable.Range(0,100);
            //var Seq002 = Enumerable.Range(0, 100);
            //var Result = Seq001.SequenceEqual(Seq002);

            //var Result = Seq001.Contains(2);

            //Console.WriteLine(Result);
            #endregion

            #region Zip Operator
            //List<string> Words = new List<string>() { "Ten","Twenty","Thirty"};
            //List<int> Numbers = new List<int>() { 10, 20, 30 };
            //var Result  = Words.Zip(Numbers,(W,N)=>$"{W}=>{N}");
            //foreach (var i in Result) 
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Grouping Operators
            //var Result  = ProductList.GroupBy(P => P.Category);
            //Result = from P in ProductList
            //         group P by P.Category;
            //foreach (var ResultItem in Result)
            //{
            //    Console.WriteLine(ResultItem.Key);
            //    foreach (var  i in ResultItem)
            //    {
            //    Console.WriteLine(i);

            //    }
            //}

            //var Result = from P in ProductList
            //             where P.UnitsInStock > 0
            //             group P by P.Category;

            //foreach (var ResultItem in Result)
            //{
            //    Console.WriteLine(ResultItem.Key);
            //    foreach (var i in ResultItem)
            //    {
            //        Console.WriteLine(i);

            //    }
            //}

            //var Result = from P in ProductList
            //             where P.UnitsInStock > 0
            //             group P by P.Category
            //             into Category
            //             where Category.Count()>10
            //             select new { CategoryName=Category.Key,CountCategory = Category.Count() };


            //var Result = ProductList.Where(P => P.UnitsInStock > 0)
            //                        .GroupBy(P => P.Category)
            //                        .Where(C => C.Count() > 5)
            //                        .Select(C=>new{ CategoryName = C.Key, CountCategory = C.Count() });

            //foreach (var ResultItem in Result)
            //{

            //        Console.WriteLine(ResultItem);


            //}


            #endregion

            #region Partitioning Operators
            //var Result = ProductList.Take(5);
            //var Result = ProductList.Where(P=>P.UnitsInStock>0).Take(5);

            //var Result = ProductList.Where(P=>P.UnitsInStock>0).TakeLast(5);

            //var Result = ProductList.Where(P => P.UnitsInStock > 0).Skip(5);

            //var Result = ProductList.Where(P => P.UnitsInStock > 0).SkipLast(5);

            //var Result = ProductList.Where(P => P.UnitsInStock > 0).Skip(15).Take(5);


           // int[] Numbers = { 8, 4, 1, 3, 7, 5 };
            //var Result = Numbers.TakeWhile((N) => N % 3 == 0);
            //var Result = Numbers.TakeWhile((N, I) => N > I);


            //foreach (var item in Result)
            //{
             //   Console.WriteLine(item);
            //}
                #endregion

            #region Let and Into
            //List<string> Nmes = new List<string>() { "Nouran","Samar","Aliaa","Mai","Hala"};
            //var Result = Regex.Replace("Aliaa", "[aeoiuEOIU]", string.Empty);
            //Console.WriteLine(Result);
            //var Result = from Name in Nmes
            //             select Regex.Replace(Name, "[aeoiuEOIU]", string.Empty)
            //             into NoVolNames
            //             where NoVolNames.Length > 3
            //             select NoVolNames;


            //var Result = from Name in Nmes
            //             let Regex.Replace(Name, "[aeoiuEOIU]", string.Empty)
            //             where NoVolNames.Length > 3
            //             select NoVolNames;


             //foreach (var N in Nmes)
            //{
            //    Console.WriteLine(N);
            //}
            #endregion
        }
    }
}
