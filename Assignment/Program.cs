using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Versioning;
using System.Text.RegularExpressions;
using static Assignment.ListGenerators;
using static System.Net.Mime.MediaTypeNames;
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
            // 1. Get first Product out of Stock 
            //var firstOutOfStockProduct =ProductList.FirstOrDefault(p => p.UnitsInStock == 0);
            #endregion
            #region Q2 
            //2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var expensiveProduct = ProductList.FirstOrDefault(p => p.UnitPrice > 1000M);
            #endregion
            #region Q3
            //3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var secondGreaterThanFive = Arr.Where(n => n > 5)
            //                                .Skip(1)
            //                                .FirstOrDefault();
            #endregion
            #endregion

            #region LINQ - Aggregate Operators
            #region Q1
            //1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var oddNumbersCount = Arr.Count(n => n % 2 != 0);
            #endregion
            #region Q2 
            //2. Return a list of customers and how many orders each has.
            //var customersOrdersCount = CustomerList .Select(c => new { c.CustomerName, OrdersCount = c.Orders.Length }).ToList();
            #endregion
            #region Q3
            //3. Return a list of categories and how many products each has
            //var categoryProductCount = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, ProductCount = g.Count() }) .ToList();
            #endregion
            #region Q4
            //4.Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var totalSum = Arr.Sum();
            #endregion
            #region Q5
            //5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            string[] dictionaryWords = File.ReadAllLines("dictionary_english.txt");


            //int totalCharacters = dictionaryWords.Sum(word => word.Length);


            //Console.WriteLine(totalCharacters);


            #endregion
            #region Q6
            //6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            var shortestWordLength = dictionaryWords.Min(word => word.Length);
            //Console.WriteLine(shortestWordLength);
            #endregion
            #region Q7
            //7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var longestWordLength = dictionaryWords.Max(word => word.Length);
            //Console.WriteLine(longestWordLength);
            #endregion
            #region Q8
            //8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var averageWordLength = dictionaryWords.Average(word => word.Length);
            //Console.WriteLine(averageWordLength);
            #endregion
            #region Q9
            //9. Get the total units in stock for each product category.
            //var totalUnitsInStockByCategory = ProductList .GroupBy(p => p.Category)
            //                                              .Select(g => new { Category = g.Key, TotalUnitsInStock = g.Sum(p => p.UnitsInStock) })
            //                                              .ToList();
            #endregion
            #region Q10
            //10. Get the cheapest price among each category's products
            //var cheapestPriceByCategory = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, CheapestPrice = g.Min(p => p.UnitPrice) }).ToList();
            #endregion
            #region Q11
            //11. Get the products with the cheapest price in each category (Use Let)
            //var cheapestProductsByCategory = from product in ProductList
            //                                 group product by product.Category into productGroup
            //                                 let minPrice = productGroup.Min(p => p.UnitPrice)
            //                                 select new
            //                                 {
            //                                     Category = productGroup.Key,
            //                                     CheapestProduct = productGroup.First(p => p.UnitPrice == minPrice)
            //                                 };

            //foreach (var item in cheapestProductsByCategory)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Cheapest Product: {item.CheapestProduct.ProductName}, Price: {item.CheapestProduct.UnitPrice:C}");
            //}
            #endregion
            #region Q12
            //12. Get the most expensive price among each category's products.
            //var mostExpensivePriceByCategory = from product in ProductList
            //                                   group product by product.Category into productGroup
            //                                   select new { Category = productGroup.Key, MostExpensivePrice = productGroup.Max(p => p.UnitPrice) };

            //foreach (var category in mostExpensivePriceByCategory)
            //{
            //    Console.WriteLine($"{category.Category} has the most expensive price: {category.MostExpensivePrice:C}");
            //}
            #endregion
            #region Q13
            //13. Get the products with the most expensive price in each category.
            //var mostExpensiveProductsByCategory = from product in ProductList
            //                                      group product by product.Category into productGroup
            //                                      let maxPrice = productGroup.Max(p => p.UnitPrice)
            //                                      select new
            //                                      {
            //                                          Category = productGroup.Key,
            //                                          MostExpensiveProduct = productGroup.First(p => p.UnitPrice == maxPrice)
            //                                      };

            //foreach (var item in mostExpensiveProductsByCategory)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Most Expensive Product: {item.MostExpensiveProduct.ProductName}, Price: {item.MostExpensiveProduct.UnitPrice:C}");
            //}
            #endregion
            #region Q14
            //14. Get the average price of each category's products.
            //var averagePriceByCategory = from product in ProductList
            //                             group product by product.Category into productGroup
            //                             select new { Category = productGroup.Key, AveragePrice = productGroup.Average(p => p.UnitPrice) };

            //foreach (var category in averagePriceByCategory)
            //{
            //    Console.WriteLine($"{category.Category} has an average price of: {category.AveragePrice:C}");
            //}
            #endregion
            #endregion

            #region LINQ - Ordering Operators
            #region Q1
            //1. Sort a list of products by name
            //var productsSortedByName = ProductList.OrderBy(p => p.ProductName).ToList();
            #endregion
            #region Q2 
            //2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var caseInsensitiveSortedWords = Arr.OrderBy(w => w, StringComparer.OrdinalIgnoreCase).ToList();
            #endregion
            #region Q3
            //3. Sort a list of products by units in stock from highest to lowest.
            //var productsSortedByStock = ProductList.OrderByDescending(p => p.UnitsInStock).ToList();
            #endregion
            #region Q4
            //4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var sortedDigits = Arr.OrderBy(d => d.Length).ThenBy(d => d) .ToList();
            #endregion
            #region Q5
            //5. Sort first by-word length and then by a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortedWords = Arr.OrderBy(w => w.Length).ThenBy(w => w, StringComparer.OrdinalIgnoreCase) .ToList();
            #endregion
            #region Q6
            //6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var productsSortedByCategoryAndPrice = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice).ToList();
            #endregion
            #region Q7
            //7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortedWordsDescending = Arr.OrderBy(w => w.Length).ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase) .ToList();
            #endregion
            #region Q8
            //8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var digitsWithSecondLetterI = Arr.Where(d => d.Length > 1 && d[1] == 'i').Reverse().ToList();


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
            /***/
            //var lastThreeCharacters = ProductList.Select(p => p.ProductName.Length >= 3 ? p.ProductName[^3..] : p.ProductName)
            //.Concat(CustomerList.Select(c => c.CustomerName.Length >= 3 ? c.CustomerName[^3..] : c.CustomerName)).ToList();
            #endregion
            #endregion

            #region LINQ - Partitioning Operators
            #region Q1
            //1. Get the first 3 orders from customers in Washington
            //var firstThreeOrdersWA = CustomerList.Where(c => c.Region == "WA").SelectMany(c => c.Orders).Take(3).ToList();
            #endregion
            #region Q2
            //2. Get all but the first 2 orders from customers in Washington.
            // var ordersAfterFirstTwoWA = CustomerList.Where(c => c.Region == "WA").SelectMany(c => c.Orders).Skip(2).ToList();

            #endregion
            #region Q3
            //3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var untilLessThanPosition = numbers.TakeWhile((number, index) => number >= index).ToList();
            #endregion
            #region Q4
            //4.Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var fromFirstDivisibleByThree = numbers.SkipWhile(n => n % 3 != 0).ToList();
            #endregion
            #region Q5
            //5. Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var fromFirstLessThanPosition = numbers.SkipWhile((number, index) => number >= index).ToList();
            #endregion
            #endregion

            #region LINQ - Quantifiers
            #region Q1
            //1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            //var containsEi = dictionaryWords.Any(word => word.Contains("ei"));
            #endregion
            #region Q2 
            //2. Return a grouped a list of products only for categories that have at least one product that is out of stock.
            //var categoriesWithOutOfStockProducts = ProductList.GroupBy(p => p.Category).Where(g => g.Any(p => p.UnitsInStock == 0)).ToList();
            #endregion
            #region Q3
            //3. Return a grouped a list of products only for categories that have all of their products in stock.
            //var categoriesWithAllInStock = ProductList.GroupBy(p => p.Category).Where(g => g.All(p => p.UnitsInStock > 0)).ToList();
            #endregion
            #endregion

            #region LINQ – Grouping Operators
            #region Q1
            //1.	Use group by to partition a list of numbers by their remainder when divided by 5
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var groupedByRemainder = numbers.GroupBy(n => n % 5) .ToList();
            #endregion
            #region Q2 
            //2.	Uses group by to partition a list of words by their first letter.  Use dictionary_english.txt for Input
            //var wordsGroupedByFirstLetter = dictionaryWords .GroupBy(word => word[0]) .ToList();
            #endregion
            #region Q3
            //3.	Consider this Array as an Input // Use Group By with a custom comparer that matches words that are consists of the same Characters Together
            //string[] Arr = { "from", "salt", "earn", " last", "near", "form" };
     
            //var groupedByCharacters = Arr.GroupBy(word => String.Concat(word.OrderBy(c => c))) .ToList();

            #endregion
            #endregion
        }
    }
}
