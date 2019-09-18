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
// Parallel.Invoke() ile istediğimiz Action metotları farklı çekirdeklerde
// koşturabiliriz,eğer müsaitse ilk metot current threadte çalışıyor diğeri farklı bir threade aktarılarak
// execute ediliyor.


// */
//     class Program
//     {
//         static object c = null;

//         static Action a = () => { System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId); };
//         static void Main(string[] args)
//         {

//             Parallel.Invoke(() =>
//             {
//                 while (true) System.Console.WriteLine("Metot1---" + Thread.CurrentThread.ManagedThreadId);


//             }, () => { while (true) System.Console.WriteLine("Metot2---" + Thread.CurrentThread.ManagedThreadId); });
//         }



//     }
// }
