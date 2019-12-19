
// using System;
// using System.Collections;
// using System.Collections.Generic;
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
//        Select sonrası alınan model içerisinde dönerek bir keyvalue obje oluşturabilmekteyiz,
//      */
//     class Program
//     {
//         static async System.Threading.Tasks.Task Main(string[] args)
//         {
//             var list = new List<okul> { new okul { name = "a", id = "t" }, new okul { name = "b", id = "w" } };
//             var t = list.Select(q => new { Id = q.id, Name = q.name, Checced = q.checeed }).ToDictionary(d => d.Id, d => (d.Name, d.Checced));



//             var okulismi = suha();


//         }
//         static okul suha()
//         {
//             return new okul() { name = "suha", id = "55" };
//         }

//     }

// }