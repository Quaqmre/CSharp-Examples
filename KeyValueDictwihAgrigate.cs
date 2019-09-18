// using System;
// using System.Collections;
// using System.Collections.Generic;
// using System.Collections.Concurrent;
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
//         static void Main(string[] args)
//         {
//             List<int> a = new List<int>() { 1, 1, 2, 2, 3, 3, 4, 4, 4 };
//             var dict = new ConcurrentDictionary<int, int>();
//             foreach (var item in a)
//             {
//                 dict.AddOrUpdate(item, 1, (key, currenvalue) => ++currenvalue);
//             }

//             var u = dict.Aggregate((x, y) => x.Value > y.Value ? x : y);
//             System.Console.WriteLine(u.Key);
//         }
//     }
// }

