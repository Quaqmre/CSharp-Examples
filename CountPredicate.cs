using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace C__Örneklerim
{
    /*
Bu örnek üzerinde durulması gerekmektedi,Single thread olarak bir listeye sayı ataması yapılırken,
Multi thread atama yapmak istediğimizde bu çok daha uzun bir süre almaktadır,Bunu araştırmak gerekir,
Soru? Döngümü yanlış yazılmıştır,Yoksa thread geçişlerinde microprossesors bu geçişlerde bir uyku saniyesi vardır,
Bu uyku saniyesinemi takılınmıştır,Bu artış bundan mı kaynaklanmaktadır??


*/
    public class Car
    {
        public string Name { get; set; }
    }
    public class Bus
    {
        public string Model { get; set; }

    }
    class Program
    {

        static void Main(string[] args)
        {
            // int a = 10;
            // int v;
            // if (a is int t)
            // {
            // System.Console.WriteLine(t);

            // }
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Func<int, bool> grederthen3 = x =>
             {
                 Func<int, int> xkare = c => { return c * c; };
                 Func<int, int> xcift = v => { return v % 2; };
                 var result = xkare(x);
                 var result1 = xcift(result);
                 return result1 == 0;
             };
            System.Console.WriteLine(a.Count(grederthen3));


        }
    }
}

