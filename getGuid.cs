// using System;
// using System.Collections;
// using System.Collections.Generic;
// using System.Diagnostics;
// using System.Linq;
// using System.Linq.Expressions;
// using System.Reflection;
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
//         static void Main(string[] args)
//         {
//             var x = string.Format("Global{0}", (object)Assembly.GetExecutingAssembly().GetType().GUID);//oluşturulan type'ın guid'si alınıyor ve hep aynı Guid veriliyor.
//             var xx = Assembly.GetExecutingAssembly().GetType();
//             int a = 0;
//             int b = 13;
//             var y = a.GetType().GUID;
//             var yy = b.GetType().GUID;
//         }

//     }
// }

