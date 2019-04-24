using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace C__Örneklerim
{
    /* 
*/
    class Program
    {
        static void Main(string[] args)
        {
            var t = g;
            System.Console.WriteLine(t((5, 6, 7)).Item1);


        }
        static Func<(int i, int ii, int iii), (int, int, int)> g = (t) => (t.i * 2, t.ii * 2, t.iii * 2);
    }
}
