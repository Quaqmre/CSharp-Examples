// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Reflection;
// using System.Threading;
// using System.Threading.Tasks;
// using System.Threading.Tasks.Dataflow;


// namespace C__Örneklerim
// {

//     class Program
//     {
//         static async Task Main()
//         {
//             var throwIfNegative = new ActionBlock<int>(n =>
//             {
//                 Console.WriteLine("n = {0}", n);
//             });
//             throwIfNegative.Post(0);
//             throwIfNegative.Post(2);
//             throwIfNegative.Post(3);

//             await ForAsync(0, 10, async (index) =>
//             {
//                 System.Console.WriteLine(index);
//                 while (true)
//                 {

//                 }
//             }, 2);
//             System.Console.WriteLine("cıktık");
//             Console.ReadLine();
//         }
//         public static Task ForAsync(
//         long fromInclusive,
//         long toExclusive,
//         Func<long, Task> body,
//         int maxDegreeOfParallelism = DataflowBlockOptions.Unbounded
//               )
//         {
//             var options = new ExecutionDataflowBlockOptions()
//             {
//                 MaxDegreeOfParallelism = maxDegreeOfParallelism
//             };

//             var block = new ActionBlock<long>(body, options);

//             for (long index = fromInclusive; index < toExclusive; ++index)
//             {
//                 block.Post(index);
//             }

//             block.Complete();
//             return block.Completion;
//         }

//     }
// }
