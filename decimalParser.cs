// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Linq.Expressions;
// using System.Net.Http;
// using System.Threading;
// using System.Threading.Tasks.Dataflow;

// // Demonstrates how to create a basic dataflow pipeline.
// // This program downloads the book "The Iliad of Homer" by Homer from the Web 
// // and finds all reversed words that appear in that book.
// static class DataflowReversedWords
// {
//     static void Main()
//     {
//         // decimal x = 3.53123m;
//         // System.Console.WriteLine(x.ToString("0.00"));
//         // System.Console.WriteLine(x);
//         Expression<Func<sinif, string>> a = (q => q.name);
//         MemberExpression memeberExpression = a.Body as MemberExpression;
//         string getValueWithName = memeberExpression.Member.Name;

//         var value = new List<sinif>() { new sinif { name = "akif", yas = 123 }, new sinif { name = "dsf", yas = 44 } };
//         foreach (var item in value)
//         {
//             var y = typeof(sinif).GetProperty(getValueWithName);
//             var ay = typeof(sinif).GetProperties();
//             var xx = y.GetValue(item);
//         }



//     }
//     public class sinif
//     {
//         public string name { get; set; }
//         public int yas { get; set; }
//     }
// }
