// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading;
// using System.Threading.Tasks.Dataflow;
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
//             var cachePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData); // burada appId adında bir klasör açar ve içine atar
//             Barrel.ApplicationId = "appId";
//             Barrel.Current.Add("URLİM", "[1]", new TimeSpan(100000000));
//             Barrel.Current.Add("URLİM1", "A lot of data in there", new TimeSpan(100000000));
//             Barrel.Current.Add("a", "A lot of data in there", new TimeSpan(100000000));
//             var x = Barrel.Current.Get<string>(key: "URLİM");
//             System.Console.WriteLine(x);
//             System.Console.WriteLine(Barrel.Current.Get<string>(key: "URLİM1"));
//         }

//         // // Bu alanda ise generic olan gelen bir tipin typesinin string mi değilmi bu kontrol edilmektedir
//         // internal static bool IsString<T>(T item)
//         // {
//         //     var typeOf = typeof(T);
//         //     if (typeOf.IsGenericType && typeOf.GetGenericTypeDefinition() == typeof(Nullable<>))
//         //     {
//         //         typeOf = Nullable.GetUnderlyingType(typeOf);
//         //     }
//         //     var typeCode = Type.GetTypeCode(typeOf);
//         //     return typeCode == TypeCode.String;
//         // }
//     }

// }

