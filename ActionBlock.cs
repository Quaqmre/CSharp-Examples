// using System;
// using System.Runtime.InteropServices;
// using System.Security.Cryptography;
// using System.Text;
// using System.Diagnostics;
// using System.Threading;
// using System.Threading.Tasks.Dataflow;

// namespace C__Örneklerim
// {


//     // Demonstrates how to specify the maximum degree of parallelism 
//     // when using dataflow.
//     class Program
//     {
//         // Performs several computations by using dataflow and returns the elapsed
//         // time required to perform the computations.
//         static TimeSpan TimeDataflowComputations(int maxDegreeOfParallelism,
//            int messageCount)
//         {
//             // Create an ActionBlock<int> that performs some work.
//             var workerBlock = new ActionBlock<int>(
//                // Simulate work by suspending the current thread.
//                millisecondsTimeout => Thread.Sleep(millisecondsTimeout),
//                // Specify a maximum degree of parallelism.
//                new ExecutionDataflowBlockOptions
//                {
//                    MaxDegreeOfParallelism = maxDegreeOfParallelism
//                });

//             // Compute the time that it takes for several messages to 
//             // flow through the dataflow block.

//             Stopwatch stopwatch = new Stopwatch();
//             stopwatch.Start();

//             for (int i = 0; i < messageCount; i++)
//             {
//                 workerBlock.Post(1000);
//             }
//             workerBlock.Complete();

//             // Wait for all messages to propagate through the network.
//             workerBlock.Completion.Wait();

//             // Stop the timer and return the elapsed number of milliseconds.
//             stopwatch.Stop();
//             return stopwatch.Elapsed;
//         }
//         static void Main(string[] args)
//         {
//             int processorCount = Environment.ProcessorCount;
//             int messageCount = processorCount;

//             // Print the number of processors on this computer.
//             Console.WriteLine("Processor count = {0}.", processorCount);

//             TimeSpan elapsed;

//             // Perform two dataflow computations and print the elapsed
//             // time required for each.

//             // This call specifies a maximum degree of parallelism of 1.
//             // This causes the dataflow block to process messages serially.
//             elapsed = TimeDataflowComputations(1, messageCount);
//             Console.WriteLine("Degree of parallelism = {0}; message count = {1}; " +
//                "elapsed time = {2}ms.", 1, messageCount, (int)elapsed.TotalMilliseconds);

//             // Perform the computations again. This time, specify the number of 
//             // processors as the maximum degree of parallelism. This causes
//             // multiple messages to be processed in parallel.
//             elapsed = TimeDataflowComputations(processorCount, messageCount);
//             Console.WriteLine("Degree of parallelism = {0}; message count = {1}; " +
//                "elapsed time = {2}ms.", processorCount, messageCount, (int)elapsed.TotalMilliseconds);
//         }
//     }

//     /* Sample output:
//     Processor count = 4.
//     Degree of parallelism = 1; message count = 4; elapsed time = 4032ms.
//     Degree of parallelism = 4; message count = 4; elapsed time = 1001ms.
//     */
// }
// // class Program
// // {
// //     [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
// //     static string a;

// //     static void Main(string[] args)
// //     {
// //         //   byte[] data = Encoding.ASCII.GetBytes("deneme");
// //         // System.Console.WriteLine(Encoding.ASCII.GetString(data));

// //         // a = "deneme";
// //         // int size = a.Length;
// //         // byte[] data = Encoding.ASCII.GetBytes("deneme");
// //         // byte[] data1 = new byte[size];
// //         // IntPtr ptr = Marshal.AllocHGlobal(size);
// //         // Marshal.Copy(ptr, data1, 0, size);
// //         // for (int i = 0; i < size; i++)
// //         // {
// //         //     Marshal.WriteByte(ptr, i * 1, data[i]);
// //         // }
// //         // for (int i = 0; i < 6; i++)
// //         // {
// //         //     Console.WriteLine(Marshal.ReadByte(ptr, i * 1));
// //         // }
// //         // string hash = String.Empty;

// //         // using (MD5 md5 = MD5.Create())
// //         // {
// //         //     byte[] hashData = md5.ComputeHash(data);
// //         //     foreach (byte value in hashData)
// //         //     {
// //         //         hash += value.ToString("X2");
// //         //     }
// //         // }
// //         System.Console.WriteLine();
// //         System.Console.WriteLine(Environment.ProcessorCount);

// //     }
// // }
