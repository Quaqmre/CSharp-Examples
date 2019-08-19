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
//     public class Car
//     {
//         public string Name { get; set; }
//     }
//     public class Bus
//     {
//         public string Model { get; set; }

//     }
//     class Program
//     {

//         static void Main(string[] args)
//         {
//             int[] a = { 1, 2, 3, 4, 5, 6 };
//             foreach (var x in greaterThan(a, 0))
//             {
//                 System.Console.WriteLine("I will sleep");
//                 Debug.WriteLine("Iwill slepp");
//                 Thread.Sleep(1000);
//             }
//             System.Console.WriteLine();
//             System.Console.WriteLine();
//             foreach (var item in returnmultiple())
//             {
//                 System.Console.WriteLine(item);
//             }
//         }
//         public static IEnumerable<int> greaterThan(int[] arr, int gt)
//         {
//             foreach (var item in arr)
//             {
//                 System.Console.WriteLine("I will add some data");
//                 if (item > gt) yield return item;
//             }
//         }
//         public static IEnumerable<int> returnmultiple()
//         {
//             yield return 1;
//             Thread.Sleep(1000);
//             yield return 2;
//             Thread.Sleep(1000);
//             yield return 3;
//             Thread.Sleep(1000);
//         }

//     }
// }

