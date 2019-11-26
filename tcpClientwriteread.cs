// using System;
// using System.Collections.Generic;
// using System.IO;
// using System.Linq;
// using System.Net.Sockets;
// using System.Reflection;
// using System.Text;
// using System.Text.RegularExpressions;
// using System.Threading;
// using System.Threading.Tasks.Dataflow;
// namespace C__Örneklerim
// {
//     /*
//         Bu yapı ile dinlenmekte olan 13000 portuna bir mesaj gönderilmektedir,
//          Ve bu sekilde cmd üzerinde gönderilen mesajları okuma imkanı sunmaktadır,
//      */
//     class Program
//     {
//         TcpClient tcpclnt = new TcpClient();
//         static async System.Threading.Tasks.Task Main(string[] args)
//         {
//             TcpClient tcpclnt = new TcpClient();
//             tcpclnt.Connect("18.184.120.195", 9001);

//             // use the ipaddress as in the server program

//             // okuma kısmı read 'de gelince blocklnır okuyana kadar

//             Thread thread = new Thread(() => multipleprocess(tcpclnt));
//             thread.Start();
//             while (true)
//             {
//                 Console.WriteLine("Iam in the while");
//                 Thread.Sleep(2000);
//             }


//             //     var client = new TcpClient("localhost", 9081);

//             //     var stream = client.GetStream();
//             //     var data = new Byte[256];
//             //     while (true)
//             //     {
//             //         Int32 bytes = stream.Read(data, 0, 256);
//             //         var responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
//             //         System.Console.WriteLine(responseData);
//             //     }
//             // }

//         }
//         static void multipleprocess(TcpClient client)
//         {

//             Stream stm = client.GetStream();
//             byte[] bb = new byte[100];
//             int k = stm.Read(bb, 0, 100);

//             for (int i = 0; i < k; i++)
//                 Console.Write(Convert.ToChar(bb[i]));
//         }
//     }
// }