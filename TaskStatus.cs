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
//     Tasklarımızın statuslerini kontrol edeviliriz,

//     */
//     class CustomData
//     {
//         public long CreationTime;
//         public int Name;
//         public int ThreadNum;
//     }

//     class Program
//     {
//         static Random rand = new Random();

//         static void Main()
//         {
//             // Wait on a single task with no timeout specified.
//             Task taskA = Task.Run(() => Thread.Sleep(2000));
//             Console.WriteLine("taskA Status: {0}", taskA.Status);
//             try
//             {
//                 taskA.Wait();
//                 //***                taskA.Wait(1000) => Burada 1000 saniye bekler ve bitip bitmediğini kontrol ederiz.
//                 //***                int index = Task.WaitAny(tasks); task burada Task.Run alan bir liste ve
//                 //***                içerisinden birtanesi bittiği anda bize biten task objesinin sırasını verir.
//                 //***                Task.WaitAll(tasks); ile bu task listesinin görevlerinin hepsinin bitmesi beklenir.
//                 Console.WriteLine("taskA Status: {0}", taskA.Status);
//             }
//             catch (AggregateException)
//             {
//                 Console.WriteLine("Exception in taskA.");
//             }
//         }
//     }
//     //     taskA Status: WaitingToRun
//     //     taskA Status: RanToCompletion
// }
