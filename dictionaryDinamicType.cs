
// using System;
// using System.Collections;
// using System.Collections.Generic;
// using System.Globalization;
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
//     class okul
//     {
//         public string name { get; set; }
//         public string id { get; set; }
//         public bool checeed { get; set; }
//     }
//     /*
//        dinamik gelen değişken tiplerini dönüştürmek için kullanılmaktadır, dictionary delen string type bilgisine göre 
//        ilgili keyin valusu bu değişkeni gelen type dönüştürerek geriye değer döner bir çok yerde kullanılabilir.
//      */
//     class Program
//     {
//         static async System.Threading.Tasks.Task Main(string[] args)
//         {
//             var name = typeof(Program);
//             var x = name.GetType();

//             Dictionary<Type, (Func<string, object> func, object tup2)> deneme = new Dictionary<Type, (Func<string, object>, object)>() {
//                 {typeof(string),((i)=>(int)double.Parse(i, CultureInfo.InvariantCulture),2)},
//                 {typeof(float), ((i) => float.Parse(i, CultureInfo.InvariantCulture),5)},

//     };
//         }
//     }

// }