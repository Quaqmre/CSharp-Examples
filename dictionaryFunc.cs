// using System;
// using System.Collections;
// using System.Collections.Generic;
// using System.Diagnostics;
// using System.Linq;
// using System.Linq.Expressions;
// using System.Threading;
// using System.Threading.Tasks;
// using System.Timers;

// namespace C__Örneklerim
// {
//     /* 

// */
//     class Program
//     {
//         private static readonly Dictionary<Type, (Func<string, object>, object)> ParserBad =
//             new Dictionary<Type, (Func<string, object>, object)>
//             {
//                 {typeof(string), (str => str, string.Empty)}
//             };
//         private static readonly Dictionary<Type, (Func<string, object> parser, object defaultValue)> Parsers =
//             new Dictionary<Type, (Func<string, object> parser, object defaultValue)>
//             {
//                 {typeof(string), (str => str, string.Empty)}
//             };
//         // private static readonly Dictionary<string, int> a = new Dictionary<string, int>

//         static void Main(string[] args)
//         {
//             Func<string, int> a = (s) =>
//             {
//                 return 2;
//             };
//             var asd = ParserBad[typeof(string)].Item1.Invoke("itemli");
//             System.Console.WriteLine(asd);

//             var t = Parsers[typeof(string)].parser.Invoke("isimli");
//             System.Console.WriteLine(t);

//         }
//     }
// }

