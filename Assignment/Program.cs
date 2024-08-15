using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Runtime.Versioning;
using static Assignment.ListGenerators;
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  LINQ - Restriction Operators
            #region Q1
            //1. Find all products that are out of stock.
            //var OutOfStock = ProductList.Where(P => P.UnitsInStock == 0);
            //foreach (var Product in OutOfStock)
            //{
            //    Console.WriteLine(Product);
            //}
            #endregion
            #region Q2
            //2. Find all products that are in stock and cost more than 3.00 per unit.
            //var ProuductInStockCostMoreThan3 = from P in ProductList
            //                                   where P.UnitsInStock>0 && P.UnitPrice>3
            //                                   select P;
            //foreach (var Product in ProuductInStockCostMoreThan3)
            //{
            //    Console.WriteLine(Product);
            //}
            #endregion
            #region Q3 
            //3. Returns digits whose name is shorter than their value.
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var DigitsNameShorterThnTheirValue = Arr.Where((D,I)=>D.Length< I );
            //foreach (var digit in DigitsNameShorterThnTheirValue) 
            //{
            //    Console.WriteLine(digit);
            //}
            #endregion
            #endregion
            #region LINQ - Element Operators
            #region Q1
            #endregion
            #region Q2 
            #endregion
            #region Q3
            #endregion
            #endregion
            #region LINQ - Aggregate Operators
            #region Q1
            #endregion
            #region Q2 
            #endregion
            #region Q3
            #endregion
            #region Q4
            #endregion
            #region Q5
            #endregion
            #region Q6
            #endregion
            #region Q7
            #endregion
            #region Q8
            #endregion
            #region Q9
            #endregion
            #region Q10
            #endregion
            #region Q11
            #endregion
            #region Q12
            #endregion
            #region Q13
            #endregion
            #region Q14
            #endregion
            #endregion
            #region LINQ - Ordering Operators
            #region Q1
            #endregion
            #region Q2 
            #endregion
            #region Q3
            #endregion
            #region Q4
            #endregion
            #region Q5
            #endregion
            #region Q6
            #endregion
            #region Q7
            #endregion
            #region Q8
            #endregion
            #endregion
            #region LINQ – Transformation Operators
            #region Q1
            //1. Return a sequence of just the names of a list of products.
            //var ProductName = ProductList.Select(P => P.ProductName);
            //foreach (var Product in ProductName)
            //{
            //    Console.WriteLine(Product);
            //}
            #endregion
            #region Q2 
            //2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var UpperAndLowerCase = from w in words
            //                        select new
            //                        {
            //                            LowerCase = w.ToLower(),

            //                            UpperCase = w.ToUpper(),

            //                        };
            //foreach (var w in UpperAndLowerCase)
            //{
            //    Console.WriteLine(w);
            //}

            #endregion
            #region Q3
            //3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //var Product = ProductList.Select(P => new { P.ProductName , P.Category , Price = P.UnitPrice , P.UnitsInStock});
            //foreach (var product in Product) 
            //{
            //    Console.WriteLine(product);
            //}
            #endregion
            #region Q4
            //4. Determine if the value of int in an array match their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var matchingPositions = Arr.Where((number, I) => number == I).ToList();
            //Console.WriteLine("Number: in Place?");
            //foreach (var number in Arr)
            //{
            //    if(matchingPositions.Contains(number)) 
            //        Console.WriteLine($"{number}: {true}"); 
            //    else 
            //        Console.WriteLine($"{number}: {false}");
            //}
            #endregion
            #region Q5
            //5.Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            // int[] numbersB = { 1, 3, 5, 7, 8 };
            // var numberPairs = numbersA.SelectMany(a => numbersB, (a, b) => new { a, b }).Where(pair => pair.a < pair.b).ToList();
            // Console.WriteLine("Pairs where a < b:");
            // foreach (var pair in numberPairs)
            // {
            //     Console.WriteLine($"{pair.a} is Less Than {pair.b}");
            // }
            #endregion
            #region Q6
            //6. Select all orders where the order total is less than 500.00.

            //var smallOrders = from C in CustomerList
            //                  from O in C.Orders
            //                  where O.Total < 500
            //                  select O;
            //foreach (var c in smallOrders)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion
            #region Q7
            //7. Select all orders where the order was made in 1998 or later.
            //var recentOrders = CustomerList.SelectMany(C=>C.Orders).Where(order => order.OrderDate.Year >= 1998).ToList();
            //foreach (var order in recentOrders)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion
            #endregion
            #region LINQ - Set Operators
            #region Q1
            //1. Find the unique Category names from Product List
            //var uniqueCategories = ProductList.Select(p => p.Category).Distinct().ToList();
            //foreach (var category in uniqueCategories)
            //{
            //    Console.WriteLine(category);
            //}
            #endregion
            #region Q2 
            //2. Produce a Sequence containing the unique first letter from both product and customer names.
            //var uniqueFirstLetters = ProductList.Select(p => p.ProductName[0]).Union(CustomerList.Select(c => c.CustomerName[0])).Distinct().ToList();
            //foreach (var name in uniqueFirstLetters) {
            //    Console.WriteLine(name);
            //}
            #endregion
            #region Q3
            //3. Create one sequence that contains the common first letter from both product and customer names.
            //var commonFirstLetters = ProductList.Select(p => p.ProductName[0]).Intersect(CustomerList.Select(c => c.CustomerName[0])).ToList();
            //foreach (var c in commonFirstLetters)
            //{
            //    Console.WriteLine(c);
            //}
            #endregion
            #region Q4
            //4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var exclusiveProductFirstLetters = ProductList.Select(p => p.ProductName[0]).Except(CustomerList.Select(c => c.CustomerName[0])).ToList();
            //foreach (var product in exclusiveProductFirstLetters) 
            //{
            //    Console.WriteLine(product);
            //}
            #endregion
            #region Q5
            //5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates.
            /***/var lastThreeCharacters = ProductList.Select(p => p.ProductName.Length >= 3 ? p.ProductName[^3..] : p.ProductName)
                                     .Concat(CustomerList.Select(c => c.CustomerName.Length >= 3 ? c.CustomerName[^3..] : c.CustomerName)).ToList();
            #endregion
            #endregion
            #region LINQ - Partitioning Operators
            #region Q1
            #endregion
            #region Q2 
            #endregion
            #region Q3
            #endregion
            #region Q4
            #endregion
            #region Q5
            #endregion
            #endregion
            #region LINQ - Quantifiers
            #region Q1
            #endregion
            #region Q2 
            #endregion
            #region Q3
            #endregion
            #endregion
            #region LINQ – Grouping Operators
            #region Q1
            #endregion
            #region Q2 
            #endregion
            #region Q3
            #endregion
            #endregion
        }
    }
}
