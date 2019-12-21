

// using System;
// using System.Collections;
// using System.Collections.Generic;
// using System.Collections.Concurrent;
// using System.Diagnostics;
// using System.Linq;
// using System.Linq.Expressions;
// using System.Threading;
// using System.Threading.Tasks;
// using System.Timers;
// using System.IO;
// using System.Runtime.InteropServices;
// using System.Net.Sockets;
// using System.Net;
// namespace a
// {

//     class Program
//     {
//         /*
//         Generic typelara kısıtlama getirilebilmektedir,
//         Where T : new () şeklinde yazılarak sadece bu clasın değer almayan constaructörü olan
//         class lara kalıtılabileceği anlatılmak istenmiştir.
//         */
//         static void Main()
//         {
//             emptyCons<withoutCons> deneme = new emptyCons<withoutCons>();
//             deneme.denemeGeneric.strCons = "akif";
//             // emptyCons<withCons> denemeWithcons = new emptyCons<withCons>(); // Hata alır çünkü withCons parametreli bir constractörü var boş ayrıca bir constractör olsaydı hata alınmazdı
//         }
//     }
//     public class withCons
//     {
//         public withCons(string st)
//         {
//             str = st;
//         }
//         public string str { get; set; }
//     }
//     public class withoutCons
//     {
//         public string strCons { get; set; }
//     }

//     public class emptyCons<T> where T : new()
//     {
//         public T denemeGeneric { get; set; }
//     }
// }

