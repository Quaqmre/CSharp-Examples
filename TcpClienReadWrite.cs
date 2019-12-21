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
//             Byte[] data = System.Text.Encoding.ASCII.GetBytes("selam memedim");

//             var client = new TcpClient("127.0.0.1", 9001);
//             var stream = client.GetStream();
//             stream.Write(data, 0, data.Length);
//         }

//     }

// }



// // using System;
// // using System.Collections.Generic;
// // using System.Linq;
// // using System.Net.Sockets;
// // using System.Reflection;
// // using System.Text.RegularExpressions;
// // using System.Threading;
// // using System.Threading.Tasks.Dataflow;
// // using LiteDB;
// // using MonkeyCache;
// // using MonkeyCache.FileStore;

// // using System;
// // using System.Net.Sockets;
// // using System.Net;

// // namespace C__Örneklerim
// // {
// //     /*
// //          Bu yapı ile birlikte bir tcp connectionunu dileyebilirsin,Ancak hali hazırda açık bir connection olması gerekmekte,
// //          nc -l 13000 yaparak cmd üzerinde yazdıklarını stringe dönüştürerek console üzerinde yazmaktadır,
// //      */
// //     class Program
// //     {
// //         static async System.Threading.Tasks.Task Main(string[] args)
// //         {
// //             // var client = new TcpClient("127.0.0.1", 9000);

// //             // var stream = client.GetStream();
// //             // var data = new Byte[256];
// //             // Int32 bytes = stream.Read(data, 0, 256);
// //             // // var responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
// //             // foreach (var item in data)
// //             // {
// //             //     System.Console.WriteLine(item);
// //             // }


// //             // TcpListener server = new TcpListener(IPAddress.Parse("127.0.0.1"), 9001);
// //             // server.Start();
// //             // TcpClient client = server.AcceptTcpClient();
// //             // NetworkStream stream = client.GetStream();
// //             // while (true)
// //             // {
// //             //     while (!stream.DataAvailable) ;

// //             //     Byte[] bytes = new Byte[client.Available];

// //             //     stream.Read(bytes, 0, bytes.Length);
// //             // }




// //         }

// //     }

// // }


