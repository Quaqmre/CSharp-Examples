// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading;
// using System.Threading.Tasks.Dataflow;

// namespace C__Örneklerim
// {
//     /*
//   Bir stringi yeniden düzenlemek için kullanmaktayız,
//   stringi parçalara ayırarak kullanıyoruz , ve eğer ilk harf dışında büyük harf varsa onun soluna alttre kouyoruz
//      */
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string a = "AliAratSelamBalım";
//             // System.Console.WriteLine(string.Concat(a.Select((x, i) => i > 0 && char.IsUpper(x) ? "_" + x.ToString() : x.ToString())));
//             // var x = a.SelectMany(gg => char.IsUpper(gg) ? "_" + gg.ToString() ? gg.ToString());
//             // a.Select((x, i) => i > 0 && char.IsUpper(x) ? "_" + x.ToString() : x.ToString());
//             var v = a.Select((x, i) => i > 0 && char.IsUpper(x) ? "_" + x.ToString() : x.ToString()).ToList();
//             var ty = string.Concat(v);
//             var xc = a.ToList();
//             var aaa = a.Select(aa => aa = 's');
//         }
//     }
// }

