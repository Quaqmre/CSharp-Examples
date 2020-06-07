// using System;
// using System.Collections;
// using System.Collections.Generic;
// using System.Diagnostics;
// using System.Linq;
// using System.Linq.Expressions;
// using System.Reflection;
// using System.Threading;
// using System.Threading.Tasks;
// using System.Timers;
// using Microsoft.Extensions.Caching.Memory;

// namespace C__Örneklerim
// {
//     /* 
//      memoryCache eğer key exist değilse exception vermemekte
// */
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             var x = new MemoryCache(new MemoryCacheOptions()
//             {

//             });
//             x.Set("mykey", "deneme");
//             try
//             {
//                 x.Remove("mykey");
//                 x.Remove("mykey");

//             }
//             catch (System.Exception)
//             {
//                 System.Console.WriteLine("dddd");

//                 throw;
//             }
//             var t = x.Get("mykey");


//         }

//     }
// }

