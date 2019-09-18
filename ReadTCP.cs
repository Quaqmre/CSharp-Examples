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
//          Bu yapı ile birlikte bir tcp connectionunu dileyebilirsin,Ancak hali hazırda açık bir connection olması gerekmekte,
//          nc -l 13000 yaparak cmd üzerinde yazdıklarını stringe dönüştürerek console üzerinde yazmaktadır,
//      */
//     class Program
//     {
//         static async System.Threading.Tasks.Task Main(string[] args)
//         {
//             var client = new TcpClient("localhost", 13000);

//             var stream = client.GetStream();
//             var data = new Byte[256];
//             Int32 bytes = stream.Read(data, 0, 256);
//             var responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
//             System.Console.WriteLine(responseData);
//         }

//     }

// }

