// using System;
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
//     /*
//      regex içerisinde match metodu denenmekte,
//      */
//     class Program
//     {
//         static async System.Threading.Tasks.Task Main(string[] args)
//         {
//             // const string text =
//             //            "Professional C# 6 and .NET Core 1.0 provides complete coverage " +
//             //            "of the latest updates, features, and capabilities, giving you " +
//             //            "everything you need for C#. Get expert instruction on the latest " +
//             //            "changes to Visual Studio 2015, Windows Runtime, ADO.NET, ASP.NET, " +
//             //            "Windows Store Apps, Windows Workflow Foundation, and more, with " +
//             //            "clear explanations, no-nonsense pacing, and valuable expert insight. " +
//             //            "This incredibly useful guide serves as both tutorial and desk " +
//             //            "reference, providing a professional-level review of C# architect a ure " +
//             //            "and its application in a number of areas. You'll gain a solid " +
//             //            "background in managed code and .NET constructs within the context of " +
//             //            "the 2015 release, so you can get acclimated quickly and get back to work.";
//             // const string pattern = @"\ba\s*ure\b";
//             // MatchCollection matches = Regex.Matches(text, pattern,
//             //     RegexOptions.IgnoreCase);
//             // WriteMatches(text, matches);
//             Console.WriteLine("Groups\n");
//             string line = "Hey, I've just found  123 this amazing URI at http:// what was it --oh yes https://www.wrox.com or http://www.wrox.com:8 012";

//             // string pattern = @"\b(https?)(://)([.\w]+)([\s:]([\d]{2,4})?)\b";
//             string pattern = @"^(?<deneme>.*)";
//             var r = new Regex(pattern);
//             MatchCollection mc = r.Matches(line);

//             foreach (Match m in mc)
//             {
//                 Console.WriteLine($"Match: {m}\n");
//                 foreach (Group g in m.Groups)
//                 {
//                     if (g.Success)
//                     {
//                         Console.WriteLine($"group index: {g.Index}, value: {g.Value}");
//                     }
//                 }
//                 Console.WriteLine();
//             }
//             Console.WriteLine();

//         }
//         public static void WriteMatches(string text, MatchCollection matches)
//         {
//             Console.WriteLine($"Original text was: \n\n{text}\n");
//             Console.WriteLine($"No. of matches: {matches.Count}");

//             foreach (Match nextMatch in matches)
//             {
//                 int index = nextMatch.Index;
//                 string result = nextMatch.ToString();
//                 int charsBefore = (index < 5) ? index : 5;
//                 int fromEnd = text.Length - index - result.Length;
//                 int charsAfter = (fromEnd < 5) ? fromEnd : 5;
//                 int charsToDisplay = charsBefore + charsAfter + result.Length;

//                 Console.WriteLine($"Index: {index}, \tString: {result}, \t" +
//                   $"{text.Substring(index - charsBefore, charsToDisplay)}");
//             }
//         }

//     }



// }

