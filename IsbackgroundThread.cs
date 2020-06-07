// using System;
// using System.Collections;
// using System.Collections.Generic;
// using System.Diagnostics;
// using System.Linq;
// using System.Linq.Expressions;
// using System.Threading;
// using System.Threading.Tasks;
// using System.Timers;

// namespace C__Örneklerim
// {
//     /* Bu örnekte thread oluşturmalarda ilgili threadlerin ne gibi özellikler alabileceği
//     backround thread olunc main threadin bittiğinde diğer threadte çalışan codunda öldürüldüğü görüşmüştür.
// */
//     class Program
//     {
//         public static string x = "0";
//         static int i = 0;

//         static void Main(string[] args)
//         {
//             Thread t = new Thread(asd);
//             System.Console.WriteLine("1");
//             t.Start();
//             Thread tt = new Thread(asd1);
//             tt.Start();
//             System.Console.WriteLine("2");
//             Console.ReadLine();

//         }
//         static void asd()
//         {
//             while (true)
//             {
//                 x = x + "1";
//             }
//         }
//         static void asd1()
//         {
//             while (true)
//             {
//                 x = x + "2";
//             }
//         }


//     }
// }

