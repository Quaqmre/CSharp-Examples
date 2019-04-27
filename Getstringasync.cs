// using System;
// using System.Collections;
// using System.Collections.Generic;
// using System.Diagnostics;
// using System.Linq;
// using System.Linq.Expressions;
// using System.Net.Http;
// using System.Threading;
// using System.Threading.Tasks;
// using System.Timers;

// namespace C__Örneklerim
// {
//     /* 
//     Httpclient classının içerisindeki getstringasync metodunu kullandık ve bu metodu async deneme metodumuzuda
//      beklememize raümen  main metodumuz içerisinde beklediğimiz için cevabını beklemeden lenghti 0 olarak yazıldı.

// */
//     class Program
//     {
//         static string a = String.Empty;
//         static async Task Main(string[] args)
//         {
//             deneme();
//             System.Console.WriteLine("Akif");
//             System.Console.WriteLine(a.Length);
//             Console.ReadKey();
//         }
//         static async Task deneme()
//         {
//             HttpClient asd = new HttpClient();
//             a = await asd.GetStringAsync("https://www.google.com/");
//             System.Console.WriteLine(a.Length);

//         }

//     }
// }

