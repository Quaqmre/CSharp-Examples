// using System;
// using System.Collections;
// using System.Collections.Generic;
// using System.Linq;
// using System.Linq.Expressions;
// using System.Threading.Tasks;
// using System.Timers;

// namespace C__Örneklerim
// {
//     /* 
//     Burada amaç async bir metodu tick eventine abone ettik ve async olarak 
//     metotlar başlar ve kendi başlarına devam etmekdir,
//     Version1:async kaldırılırsa olanlar,Task.Delay(1000) şeklinde denendiğinde metot started ve ended stringlerini 
//         ard arda yazmata,Ve delayı arka planda samakta ,Eğer Thread.Delay(1000) yazılırsa sanki async metodundaymış gibi delayı arka planda saymakta,
//         döngü delay satırında beklemekte 6 thread aynı anda started yazar ancak 1 saniye sonra stopped yazmaya başlar
//             eğer while(true) ya sokulursa 6 thread 0.2 ms aralıkla started yazmakta ancak bu threadler en sonunda kitlendiğinden 
//             bilgisayar cevap vermemektedir
// */
//     class Program
//     {

//         static void Main(string[] args)
//         {
//             var x = new System.Timers.Timer();
//             x.Enabled = true;
//             x.Interval = 201;
//             x.Elapsed += async (sender, e) => await ornekkod();
//             Console.ReadKey();
//         }
//         static async Task ornekkod()
//         {
//             System.Console.WriteLine("OrnekKodstarted");
//             await Task.Delay(1000);
//             System.Console.WriteLine("Ornekkod ended");

//         }
//     }
// }
