// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace C__Örneklerim
// {
//     /*
//     Bu örnekte IEnumerable bir Liste içerisinde atama Linq Sorgusu ile yapılmaktadır,Buda Modelin Lazy bir şekilde oluşturulmasına neden oluyor
//     Ve bu şekilde oluşturulan model içerisinde foreach ile dönüldüğünde dönülen model içerisine atama yapılamamaktadır.
//     Bu sorunu ortadan kaldırmak için Lazy olarak oluşturulan modeli toList yarımı ile Lazy modelden Belirtilen Modele döndürülür
//     Ve bu şekilde Model içerisinde foreach ile dönülerek atama yapılabilmektedir.
//      */
//     public class akif
//     {
//         public IEnumerable<enum1> item { get; set; }
//     }
//     public class enum1
//     {
//         public string sayi { get; set; }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             akif deneme = new akif() { item = new List<enum1>() { new enum1() { sayi = "1" }, new enum1() { sayi = "2" } }.Select(x => new enum1() { sayi = x.sayi }) };
//             foreach (var item in deneme.item)
//             {
//                 System.Console.WriteLine(item.sayi);
//                 item.sayi = "5";
//             }
//             foreach (var item in deneme.item)
//                 System.Console.WriteLine(item.sayi);
//         }
//     }
// }
