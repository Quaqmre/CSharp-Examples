
// using System;
// using System.Collections;
// using System.Collections.Generic;
// using System.Linq;
// using System.Net.Sockets;
// using System.Net.WebSockets;
// using System.Reflection;
// using System.Text.RegularExpressions;
// using System.Threading;
// using System.Threading.Tasks.Dataflow;
// using LiteDB;
// using MonkeyCache;
// using MonkeyCache.FileStore;
// using Websocket.Client;

// namespace C__Örneklerim
// {
//     class Program
//     {
//         static async System.Threading.Tasks.Task Main(string[] args)
//         {
//             var url = new Uri("ws://localhost:8080/deneme");
//             var exitEvent = new ManualResetEvent(false);

//             using (var client = new WebsocketClient(url))
//             {
//                 client.MessageReceived.Subscribe(msg => Console.WriteLine($"Message: {msg}"));
//                 await client.Start();

//                 await client.Send("Echo");

//                 exitEvent.WaitOne();
//             }

//             Console.ReadLine();
//         }
//     }
// }