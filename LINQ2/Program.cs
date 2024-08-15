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
            #region 
            #endregion
            #region 
            #endregion
            #region 
            #endregion
            #region 
            #endregion
            #region 
            #endregion
            #region 
            #endregion
            #region 
            #endregion
            #region 
            #endregion
            #region 
            #endregion

        }
    }
}
