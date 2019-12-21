// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading;
// using System.Threading.Tasks.Dataflow;


// namespace C__Örneklerim
// {
//     /*
//         This is hanging with props , when u have a generic class u can get your all propertis and u can handle with object
//         u can get values specsipic properties,
//         such as Human is a class and akif is a object an Human,
//         I got values of akif with specific props after get Properties Human
//      */
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // var akif = new Human { name = "akif", age = 26, burnDate = DateTime.Now };
//             // var props = typeof(Human).GetProperties();
//             // foreach (var item in props)
//             // {
//             //     var value = item.GetValue(akif);
//             //     var realvalue = akif.name;
//             //     System.Console.WriteLine(item.Name);
//             //     System.Console.WriteLine(value);
//             // }
//             // List<int> birlist = new List<int>();

//             //
//             live<string> deneme = new live<string>() { type = "ali" };
//             live<Human> suha = new live<Human>();
//             var rnd = new Random();
//             object h = default;

//             // if (rnd.Next(10) % 2 == 1)
//             // {
//             //     h = deneme;
//             // }
//             // else
//             //     h = suha;
//             h = suha;
//             if (h is live<Human>)
//             {
//                 var prps = typeof(live<Human>).GetProperties();
//                 foreach (var item in prps)
//                 {
//                     var j = item.GetValue(h);
//                     System.Console.WriteLine(j);
//                 }
//             }

//         }
//     }


//     class Human
//     {
//         public string name { get; set; }
//         public int age { get; set; }
//         public DateTime? burnDate { get; set; }
//     }
//     class live<T>
//     {
//         public T type { get; set; }
//     }


// }
