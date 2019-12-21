// using System;
// using System.Collections.Generic;
// using System.IO;
// using System.Linq;
// using System.Net.Http;
// using System.Net.Sockets;
// using System.Reflection;
// using System.Text;
// using System.Text.RegularExpressions;
// using System.Threading;
// using System.Threading.Tasks.Dataflow;
// using LiteDB;
// using MonkeyCache;
// using MonkeyCache.FileStore;

// namespace C__Örneklerim
// {
//     /*
//         Bu örnekte question mark syntax'ı anlamaya çalıştık
//      */
//     class Program
//     {
//         static async System.Threading.Tasks.Task Main(string[] args)
//         {
//             Func<deneme, string> act = (den) => den?.sinf?.isim;//Objelerde null check yapmak için kullanılır eğer ilk değer nullsa null döner değilse . notationdan aramaya devam eder
//             // Func<deneme, int> act1 = (den) => den?.sinf.isim; // hata verecektir,? ile null check yaparken return type null olabileceğini belirtiyoruz ancak int türü null olamaz
//             // Func<deneme, int?> act2 = (den) => den?.sinf.isim;//int türünde bir değişken dönmemiz gerekiyorsa nullable int olarak dönüş türünü belirtirsek hata alınmamaktadır.
//             var t = act(null);//t=null
//             var r = act(new deneme());//r="asd"
//             decimal x = 3.5m;
//             System.Console.WriteLine(x);
//         }
//         class deneme
//         {
//             public sinif sinf { get; set; } = new sinif();
//         }
//         class sinif
//         {
//             public string isim { get; set; } = "qwe";
//         }
//     }

// }

