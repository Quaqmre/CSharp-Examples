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
//     /* 


//     */

//     public class akif
//     {
//         public string name { get; set; }
//     }

//     class Program
//     {

//         public static void Main()
//         {
//             akif Akif = new akif() { name = "Ttar" };
//             Random rnd = new Random();
//             if (rnd.Next(0, 100) % 2 == 0)
//             {
//                 Akif = null;

//             }
//             var x = Akif?.name ?? "Not newed";
//             System.Console.WriteLine(x);
//         }
//     }
// }
