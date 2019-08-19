// using System;
// using System.Collections;
// using System.Collections.Generic;
// using System.Linq;
// using System.Linq.Expressions;
// using Microsoft.EntityFrameworkCore;

// namespace asd
// {
//     public class tta
//     {
//         public static int ttt(int i)
//         {
//             return 50;
//         }
//         public static int ss(int i)
//         {
//             return i + 13;
//         }
//     }
//     public class akif
//     {
//         public Action f = () => System.Console.WriteLine("F executed");
//         public Action j = () => System.Console.WriteLine("j executed");

//     }
//     public class CurrencyModel
//     {
//         public int CurrencyId { get; set; }
//         public int CurrencyType { get; set; }
//         public DateTime? CurrencyDate { get; set; }
//         public string CurrencyName { get; set; }

//         public decimal CurrencyRate { get; set; }
//         public string CurrencyExchangeRateSource { get; set; }

//     }
//     public class CurrencyContex : DbContext
//     {

//         public DbSet<CurrencyModel> Currency { get; set; }

//     }
//     class Program
//     {

//         public Program()
//         {
//             akif akif = new akif();
//             a += akif.f;
//             a += akif.j;

//         }
//         public static int ss(int i)
//         {
//             return i + 13;
//         }
//         static Action deneme()
//         {
//             int i = 0;
//             return () => i++;



//         public Action a;


//     }
//     static void Main(string[] args)
//     {
//         Program v = new Program();

//         v.a.Invoke();
//         v.a = null;
//         Action f = () => System.Console.WriteLine("");
//         v.a += () =>
//         v.a();
//         Action x = () => System.Console.WriteLine(""); ;
//         Action a = deneme();
//         a();
//         a();
//         var x = deneme();
//         System.Console.WriteLine(x);
//         x = deneme();
//         System.Console.WriteLine(x);

//         var x = new CurrencyContex();
//         IQueryable<CurrencyModel> currency = x.Currency;
//         System.Console.WriteLine(currency);

//         var v = "Heelo here";
//         var g = String.Empty;
//         tta gc = new tta();
//         List<int> asd = new List<int>() { 1, 2, 14, 3, 4, 6 };
//         var deneme = asd.AsQueryable().Aggregate(4, (t, y) => t > y ? t : y, tta.ttt);
//         // var deneme = asd.AsQueryable().Aggregate(v, (_, f) => f > 13 ? _ : "asd", (rr) => rr.ToUpper());
//         // var deneme = asd.AsQueryable().Aggregate(v, (_, f) => f > 15 ? _ : "asd", (rr, sd) => rr.ToString());
//         System.Console.WriteLine(deneme);
//         // Expression<Action<string>> test = i => System.Console.WriteLine("asd");
//         // System.Console.WriteLine(test.Type);
//     }
//     var x = asd(12);
//     var y = f();
//     System.Console.WriteLine(x);
//             System.Console.WriteLine(y);
//         }
// static Func<int, string> asd = (int i) => "asd";
// static Func<string> f = () => "ggg";
// static string ff()
// {
//     return "ggg";
// }

// IEnumerable<int> asd = new[] { 1, 2, 3, 4, 56 };
// var s = Foo(asd);
// System.Console.WriteLine("ddddddd");
//             foreach (var hh in s)
//                 System.Console.WriteLine("ddd");
//             System.Console.WriteLine("asdasdadas");
//             goo(s);

//             // System.Console.WriteLine(s.ToList().GetType().GetProperties().ToList().Select(f => f.GetType()));
//         }
//         static IEnumerable<int> Foo(IEnumerable<int> d)
// {
//     foreach (var i in d)
//     {
//         System.Console.WriteLine("in for each");
//         yield return i;
//     }
// }
// static IEnumerable goo(IEnumerable t)
// {
//     foreach (var y in t)
//         yield return y;
// }
// Console.WriteLine("Hello World!");
//             Foo(Goo);
//         }
//         static void Foo(medelegate t)
// {
//     t.Invoke();
// }
// static void Goo() { System.Console.WriteLine("From Goo"); }
// delegate void medelegate();
//     }
// }
