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
//         static async System.Threading.Tasks.Task Main(string[] args)
//         {
//             var client = new TcpClient("localhost", 13000);

//             var stream = client.GetStream();
//              stream.Write(data, 0, data.Length);
//              Console.WriteLine("Sent: {0}", "denedim");

//         }

//     }

// }

