// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading;
// using System.Threading.Tasks.Dataflow;

// namespace C__Örneklerim
// {
//     /*
//    Bir file yazmak için kullanılmaktadır
//      */
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             var action = new ActionBlock<int>(i =>
//                 {
//                     Thread.Sleep(1500);
//                     Console.WriteLine(i);
//                 }, new ExecutionDataflowBlockOptions
//                 {
//                     MaxDegreeOfParallelism = Environment.ProcessorCount
//                 });
//             for (int i = 0; i < 8; i++) action.Post(i);
//             Console.WriteLine("İşlem bitti");
//             Console.ReadLine();
//         }
//     }
// }
