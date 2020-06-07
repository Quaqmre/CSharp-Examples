// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Net.Sockets;
// using System.Reflection;
// using System.Text.RegularExpressions;
// using System.Threading;
// using System.Threading.Tasks.Dataflow;
// using LiteDB;
// using MonkeyCache;
// using MonkeyCache.FileStore;

// namespace C__Örneklerim
// {
//     /*
//         Bu yapı ile dinlenmekte olan 13000 portuna bir mesaj gönderilmektedir,
//          Ve bu sekilde cmd üzerinde gönderilen mesajları okuma imkanı sunmaktadır,
//      */
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             bool complate = false;
//             var t = new Thread(
//                 () =>
//                 {
//                     bool toggle = false;
//                     while (!complate)
//                         toggle = !toggle;
//                 }
//             );
//             t.Start();
//             Thread.Sleep(1000);
//             complate = true;
//             t.Join();
//         }

//     }

// }

