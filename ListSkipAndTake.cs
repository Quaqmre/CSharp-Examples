// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text.RegularExpressions;
// using System.Threading;
// using System.Threading.Tasks.Dataflow;
// using LiteDB;
// using MonkeyCache;
// using MonkeyCache.FileStore;

// namespace C__Örneklerim
// {
//     class Program
//     {

//         static void Main(string[] args)
//         {
//             //3.sayfada bulunması gereken sayıları almak istemekteyim yani (9 ila 15 arasındaki sayıları alacağım,current page 2 de bulunmaktayız
//             //sonraki sayfa olan 3 ü alacağım.
//             var pageSize = 5;
//             var pageIndex = 2;
//             var totalPage = 20;
//             var t = Enumerable.Range(0, 100).ToList();
//             List<int> ucuncuSayfa = t.Skip(pageIndex * pageSize).Take(pageSize).ToList();
//             ucuncuSayfa.ForEach(x => System.Console.WriteLine(x));//tam olarak 9 ile 15 arasını almış bulumaktayız

//         }
//     }

// }

