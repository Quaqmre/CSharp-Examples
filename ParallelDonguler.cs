// using System;
// using System.Collections;
// using System.Collections.Generic;
// using System.Diagnostics;
// using System.Linq;
// using System.Linq.Expressions;
// using System.Threading;
// using System.Threading.Tasks;
// using System.Timers;

// namespace C__Örneklerim
// {
//     /*
// Denenmeye çalışılan şey single thread işlem kapasitesi ile multi thread işlem kapasitesini karşılaştırmak
// */
//     class Program
//     {
//         static long toplam = 0;
//         static void Main(string[] args)
//         {
//             Stopwatch y = new Stopwatch();
//             y.Start();
//             System.Console.WriteLine("started");
//             var a = Enumerable.Range(0, 500000).ToList();
//             int t = 0;
//             foreach (var i in a)
//                 t = new Random().Next(100);
//             System.Console.WriteLine(y.Elapsed);
//             y.Reset();
//             System.Console.WriteLine("solo foreachh finished");
//             y.Start();
//             Parallel.ForEach(a, (item) =>
//             {
//                 t = new Random().Next(100);
//             });
//             System.Console.WriteLine(y.Elapsed);
//             System.Console.WriteLine("multi foreach finished");
//             y.Reset();
//             y.Start();
//             Parallel.For(0, 100000, tt => { t = new Random().Next(100); });
//             System.Console.WriteLine("Ende pararlel for" + y.Elapsed);
//             y.Reset();
//             y.Start();
//             System.Console.WriteLine("İnthe paralelfor");
//             for (int i = 0; i < 100000; i++)
//             {
//                 t = new Random().Next(100);
//             }
//             System.Console.WriteLine("End single for" + y.Elapsed);

//         }
//     }
// }

