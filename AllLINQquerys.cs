using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks.Dataflow;

namespace C__Örneklerim
{
    /*
   Bir file yazmak için kullanılmaktadır
     */
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>() { 1, 2, 3, 4, 5, 6 };

            var y = lst.Where(w => w > 2)
            .AsNoTracking()                        //Linq Database sorguları için modeli trackler ki ve sonunda aynı model savechanges yapalım diye
            .OrderBy(c => c)            //Testinden sıralama istedik,
            .Take(1)                             //Sadece 1 örneği almak istediğimizi belirtiyorum
            .Select(x => x)
            .FirstOrDefault();
            System.Console.WriteLine(y);
        }
    }
}
