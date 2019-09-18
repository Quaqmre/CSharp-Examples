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
//     /*
//   Bir stringi yeniden düzenlemek için kullanmaktayız,
//   stringi parçalara ayırarak kullanıyoruz , ve eğer ilk harf dışında büyük harf varsa onun soluna alttre kouyoruz
//      */
//     class Program
//     {

//         static void Main(string[] args)
//         {
//             checkDateFormat("asd");
//         }
//         static bool checkDateFormat(string date)
//         {
//             // string rx = @"^((0\d)|(1[012])).(([012]\d)|3[01]).\d{4}$";
//             // var match = Regex.Match("11-10-2019", rx);
//             string rx = @"^*(date|Date)\z";
//             var match = Regex.Match("asdateas", rx);

//             return match.Success;
//         }
//     }
// }

