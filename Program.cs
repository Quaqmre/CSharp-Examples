using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace C__Örneklerim
{
    class Program
    {

        static void Main(string[] args)
        {
            Func<int, bool> g = (x) => x > 5;
            var list = Enumerable.Range(1, 30).ToList();
            var hh = WWhere((t) => t > 15, list);
            hh.ForEach((i) => System.Console.WriteLine(i));
        }
        static Func<Func<int, bool>, List<int>, List<int>> WWhere = (t, f) =>
         {
             List<int> List = new List<int>();
             foreach (var u in f)
             {
                 if (t(u))
                     List.Add(u);
             }
             return List;
         };


    }

}
