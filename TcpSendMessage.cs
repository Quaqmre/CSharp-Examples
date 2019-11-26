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
//             Byte[] data = System.Text.Encoding.ASCII.GetBytes("https://rpmfind.net/linux/centos/7.7.1908/os/x86_64/Packages/glibc-2.17-292.el7.x86_64.rpm\n");

//             var client = new TcpClient("192.168.56.102", 3000);
//             var stream = client.GetStream();
//             stream.Write(data, 0, data.Length);

//         }

//     }

// }



