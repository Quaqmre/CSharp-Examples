// // using System;
// // using System.Collections.Generic;
// // using System.IO;
// // using System.Linq;
// // using System.Net;
// // using System.Net.Http;
// // using System.Net.Mail;
// // using System.Net.Sockets;
// // using System.Reflection;
// // using System.Text;
// // using System.Text.RegularExpressions;
// // using System.Threading;
// // using System.Threading.Tasks;
// // using System.Threading.Tasks.Dataflow;
// // using LiteDB;
// // using MonkeyCache;
// // using MonkeyCache.FileStore;

// // namespace C__Örneklerim
// // {
// //     /*
// //         Bu örnekte question mark syntax'ı anlamaya çalıştık
// //      */
// //     class Program
// //     {
// //         static async Task Main(string[] args)
// //         {
// //             var from = new MailAddress("mailSender", "Konu");
// //             var to = new MailAddress("mailRecever");
// //             using (var smtpServer = new SmtpClient("Which Smtp Service", 587))
// //             using (var mail = new MailMessage(from, to))
// //             {
// //                 smtpServer.EnableSsl = true;
// //                 smtpServer.UseDefaultCredentials = false;
// //                 smtpServer.Credentials = new NetworkCredential("IdYaz", "Sifre");
// //                 mail.Subject = "subject";
// //                 mail.Body = "MailBody";
// //                 mail.IsBodyHtml = true;
// //                 try
// //                 {
// //                     await smtpServer.SendMailAsync(mail);
// //                 }
// //                 catch (Exception e)
// //                 {
// //                     throw;
// //                 }
// //             }
// //         }
// //     }

// // }

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



