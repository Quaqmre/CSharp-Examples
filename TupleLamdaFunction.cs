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
// Burada denenen mesele bir tuple değer zincirinin bir Functiona parametre geçilmesi ve bu değerlerin bir tuple olarak döndürülmesini denemek
// Soru? Acaba tüm tapıllara nokta ile erişim sağlanabilirmi
// Cevap_ Evet ulaşılabilrmektedir.

// */
//     class Program
//     {
//  (int x, int y, int z) someuntraditionalthins(int z)
//     {
//         return (1, 2, 3);
//     }
//         static void Main(string[] args)
//         {
//             var t = g;
//             System.Console.WriteLine(t((5, 6, 7)));


//         }
//         static Func<(int i, int ii, int iii), (int, int, int)> g = (t) => (t.i * 2, t.ii * 2, t.iii * 2);
//     }
// }
