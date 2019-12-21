

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
// using System.IO;
// using System.Runtime.InteropServices;
// using System.Net.Sockets;
// using System.Net;
// class Program
// {
//     /*Aggrigate amacı orderlanmış listede arada kalmış sayıları bulmaktır.
// Ordarlar ve sırayla 'n+1' den n'i çıkarırım eğer birden büyükse n'i alır bir ile toplar
// aradaki n ile 'n+1' arasındaki sayıyı bulurum.*/
//     static void Main()
//     {
//         List<int> a = new List<int>() { 1 };
//         a = a.OrderBy(q => q).ToList();
//         foreach (var item in a)
//             System.Console.Write(item);
//         System.Console.WriteLine("-----");
//         var yy = a.Aggregate((x, y) =>
//         {
//             System.Console.WriteLine($"x:{x}");
//             System.Console.WriteLine($"y:{y}");
//             return (y - x > 1 ? x : y);
//         });
//         System.Console.WriteLine(yy);

//     }


// }