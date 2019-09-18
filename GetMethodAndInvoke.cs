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
//   Bir stringi yeniden düzenlemek için kullanmaktayız,
//   stringi parçalara ayırarak kullanıyoruz , ve eğer ilk harf dışında büyük harf varsa onun soluna alttre kouyoruz
//      */
//     class AttributesSample
//     {
//         public void Mymethod(int int1m, out string str2m, ref string str3m)
//         {
//             str2m = "in Mymethod";
//         }

//         public static int Main(string[] args)
//         {
//             Console.WriteLine("Reflection.MethodBase.Attributes Sample");

//             // Get the type.
//             Type MyType = Type.GetType("AttributesSample");

//             // Get the method Mymethod on the type.
//             MethodBase Mymethodbase = MyType.GetMethod("Mymethod");

//             // Display the method name.
//             Console.WriteLine("Mymethodbase = " + Mymethodbase);

//             // Get the MethodAttribute enumerated value.
//             MethodAttributes Myattributes = Mymethodbase.Attributes;

//             // Display the flags that are set.
//             PrintAttributes(typeof(System.Reflection.MethodAttributes), (int)Myattributes);
//             return 0;
//         }


//         public static void PrintAttributes(Type attribType, int iAttribValue)
//         {
//             if (!attribType.IsEnum)
//             {
//                 Console.WriteLine("This type is not an enum.");
//                 return;
//             }

//             FieldInfo[] fields = attribType.GetFields(BindingFlags.Public | BindingFlags.Static);
//             for (int i = 0; i < fields.Length; i++)
//             {
//                 int fieldvalue = (Int32)fields[i].GetValue(null);
//                 if ((fieldvalue & iAttribValue) == fieldvalue)
//                 {
//                     Console.WriteLine(fields[i].Name);
//                 }
//             }
//         }
//     }

// }

