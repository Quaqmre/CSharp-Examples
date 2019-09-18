// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Reflection;
// using System.Text.RegularExpressions;
// using System.Threading;
// using System.Threading.Tasks.Dataflow;
// using LiteDB;
// using MonkeyCache;
// using MonkeyCache.FileStore;

// namespace C__Örneklerim
// {
//     /*
// Bir classı kopyalamak için kullanılmakta yeni bir instancesi oluşturularak bunun içerisindeki property ve valueleri kopyalanmakta
//      */
//     class Program
//     {
//         public static T CopyClass<T>(T obj)
//         {
//             T objcpy = (T)Activator.CreateInstance(typeof(T));
//             foreach (var prop in obj.GetType().GetProperties())
//             {
//                 var value = prop.GetValue(obj);
//                 objcpy.GetType().GetProperty(prop.Name).SetValue(objcpy, value);
//             }
//             return objcpy;
//         }
//         static void Main(string[] args)
//         {
//             var t = new deneme();
//             var y = CopyClass<deneme>(t);
//         }
//         public class deneme
//         {
//             public string isim { get; set; }
//         }
//     }

// }

