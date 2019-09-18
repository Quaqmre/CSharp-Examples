// using System;
// using System.Collections;
// using System.Collections.Generic;
// using System.Linq;
// using System.Linq.Expressions;
// using System.Threading;
// using System.Threading.Tasks;
// using System.Timers;

// namespace C__Örneklerim
// {
//     /* 
// */
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Akif a = new Akif();
//             while (true)
//             {
//                 a.h();
//             }
//         }

//     }
//     class Akif
//     {
//         public Akif()
//         {
//             x++;
//         }
//         static int x;
//         public Action h = () =>
//         {
//             x++;
//             t();
//         };
//         static Action t = () =>
//         {
//             if (x % 10 == 0)
//                 System.Console.WriteLine("Ticked");
//             else
//                 System.Console.WriteLine("not tickerd");

//         };
//     }
// }
