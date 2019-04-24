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
            var x = new System.Timers.Timer();
            x.Enabled = true;
            x.Interval = 201;
            x.Elapsed += (sender, e) => ornekkod();
            Console.ReadKey();
        }
        static void ornekkod()
        {
            System.Console.WriteLine("OrnekKodstarted");
            Thread.Sleep(1000);
            System.Console.WriteLine("Ornekkod ended");

        }
    }
}
