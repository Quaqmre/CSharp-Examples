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

*/
    class Program
    {
        public class Point
        {
            public Point(double x, double y)
                => (X, Y) = (x, y);

            public double X { get; }
            public double Y { get; }

            public (double, double) Deconstruct()
            {
                return (X, Y);
            }
        }
        static void Main(string[] args)
        {
            var p = new Point(3.14, 2.71);
            (double X, double Y) = p.Deconstruct();
            System.Console.WriteLine(Y);

        }
    }
}

