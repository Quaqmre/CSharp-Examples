// using System;
// using System.Collections;
// using System.Collections.Generic;
// using System.Collections.Concurrent;
// using System.Diagnostics;
// using System.Linq;
// using System.Linq.Expressions;
// using System.Threading;
// using System.Threading.Tasks;
// using System.Timers;

// class BaseClass
// {
//     public int sayi { get; set; }
//     public string name { get; set; }
//     public BaseClass(int _sayi, string _name)
//     {
//         sayi = _sayi;
//         name = _name;
//     }
// }
// class intharedenceclass : BaseClass
// {
//     public intharedenceclass() : base(1, "deneme")
//     {
//         System.Console.WriteLine(sayi);
//         System.Console.WriteLine(name);
//     }

// }
// class Program
// {
//     static void Main()
//     {
//         var a = new intharedenceclass();
//     }

// }
// //</snippet1>