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
// Bu örnek üzerinde durulması gerekmektedi,Single thread olarak bir listeye sayı ataması yapılırken,
// Multi thread atama yapmak istediğimizde bu çok daha uzun bir süre almaktadır,Bunu araştırmak gerekir,
// Soru? Döngümü yanlış yazılmıştır,Yoksa thread geçişlerinde microprossesors bu geçişlerde bir uyku saniyesi vardır,
// Bu uyku saniyesinemi takılınmıştır,Bu artış bundan mı kaynaklanmaktadır??


// */
//     class Program
//     {
//         static long toplam = 0;
//         static byte[] values = new byte[50000000];
//         static void Main(string[] args)
//         {
//             System.Console.WriteLine("started progress");
//             Stopwatch asd = new Stopwatch();
//             asd.Start();
//             var rnd = new Random(100);
//             for (int i = 0; i < values.Length; i++)
//             {
//                 values[i] = (byte)rnd.Next(10);
//             }
//             System.Console.WriteLine(asd.Elapsed);
//             asd.Reset();
//             asd.Start();
//             System.Console.WriteLine("Multiple");
//             Thread[] listth = new Thread[Environment.ProcessorCount];
//             for (int t = 0; t < Environment.ProcessorCount; t++)
//             {
//                 listth[t] = new Thread(multipleprocess);
//                 listth[t].Start(t);
//             }
//             for (int tt = 0; tt < Environment.ProcessorCount; tt++)
//                 listth[tt].Join();

//             asd.Stop();
//             System.Console.WriteLine(asd.Elapsed);

//         }
//         static void multipleprocess(object portionNumber)
//         {
//             long x = 0;
//             System.Console.WriteLine(portionNumber);
//             var rnd = new Random(100);
//             for (int ii = (int)portionNumber * values.Length / Environment.ProcessorCount; ii < (int)portionNumber
//             * (values.Length / Environment.ProcessorCount) + values.Length / Environment.ProcessorCount; ii++)
//             {
//                 x += values[ii];
//             }
//             toplam += x;

//         }



//     }
// }

