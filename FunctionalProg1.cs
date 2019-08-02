using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace C__Örneklerim
{
    /* Githubdaki bu kodların çalışması için FunctionalProg1.cs içeriği Program.cs içerisine taşınmalıdır. 
   Bu Kod örneğinde amaç Linq içerisinde barınan Where örneğini generic type olmadan,
    Basitleştirilmiş bir şekilde denemek ve Functional Programing Mantığını kavramak,
    Bir Func tanımlanır içerisine Liste ve bir Function alır , Parametre olarak alınan,
    Bu metot liste içerisinde dönerek sayıları karşılaştırır,
    Soru? Foreach te bir metot olarak tanımlanmalımıdır??
    Hedef! List<int> olarak tanımlanan değişkenler generic olarak tanımlanmalıdır
*/
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
