// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Net.Http;
// using System.Threading;
// using System.Threading.Tasks;
// using System.Threading.Tasks.Dataflow;

// // Select ile Bir string listesinin içerisindeki itemleri çekebilmekteyim ancak
// // SelectMany ile Liste içerisindeki itemlerin yani bir stringin char char içerisinde gezmekteyim,
// // Bu yüzden select bana allli döndürürken,SelectMany 3 tane l döndürmektedir,
// static class DataflowReversedWords
// {
//     static async Task Main()
//     {
//         List<(string a, string b)> a = new List<(string a, string b)> { ("allli", "arat") };
//         // var x = Enumerable.Range(0, 100).ToList();
//         var Select = a.Select(s => s.a).AsQueryable().Where(x => x == "allli").ToList();
//         var SelectMany = a.SelectMany(s => s.a).AsQueryable().Where(v => v == 'l').ToList();

//     }
// }