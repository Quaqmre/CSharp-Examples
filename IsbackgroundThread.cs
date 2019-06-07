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
    /* Bu örnekte thread oluşturmalarda ilgili threadlerin ne gibi özellikler alabileceği
    backround thread olunc main threadin bittiğinde diğer threadte çalışan codunda öldürüldüğü görüşmüştür.
*/
    class Program
    {
        static int i = 0;

        static void Main(string[] args)
        {
            Thread t = new Thread(asd);
            t.IsBackground = true;
            t.Start();

        }
        static void asd()
        {
            System.Console.WriteLine(Thread.CurrentThread.IsBackground);
        }


    }
}

