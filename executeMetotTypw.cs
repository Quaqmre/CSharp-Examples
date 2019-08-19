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
//         static int i;
//         static object a = new object();

//         static void Main(string[] args)
//         {
//             // SemaphoreSlim _gate = new SemaphoreSlim(1);
//             // // scheduler(_gate);
//             // Console.ReadKey();
//             var xx = new job();
//             var a = typeof(job).AssemblyQualifiedName;
//             var type = Type.GetType(a);
//             var typeInfo = type.GetTypeInfo();
//             ConstructorInfo ctor = typeInfo.GetConstructors().Single();
//             ParameterInfo[] parameters = ctor.GetParameters();
//             object jobInstance = ctor.Invoke(null);
//             switch (jobInstance)
//             {
//                 case top a:
//                     a.deneme();
//                 default:
//                     System.Console.WriteLine("");
//             }


//         }
//         static async Task scheduler(SemaphoreSlim gate)
//         {
//             await gate.WaitAsync();
//             lock (a)
//             {
//                 i++;
//             }
//             System.Console.WriteLine("scheduled" + ":" + i);
//             System.Console.WriteLine("th:" + Thread.GetCurrentProcessorId());
//             gate.Release();
//             await Task.Delay(1000);
//             await scheduler(gate);
//         }

//     }
//     class job : top
//     {
//         public void deneme()
//         {
//             System.Console.WriteLine("selam");
//         }
//     }
//     public interface top
//     {
//         void deneme();
//     }
// }
