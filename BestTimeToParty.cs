using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.IO;
using System.Runtime.InteropServices;
using System.Net.Sockets;
using System.Net;
class Program
{
    // M.I.T. University
    //// Programming for the Puzzled
    ///// Puzzle 2: The Best Time to Party

    // Celebrity Comes Goes
    // Beyoncé 6, 8
    // Taylor 6, 12
    // Brad 6, 7
    // Katy 7, 8
    // Tom 7, 10
    // Drake 8, 9
    // Alicia 9, 12
    // When is the best time to attend the party? That is, which hour should you go to?
    // Partye katılmak için zaman belirlenmeli ve 1 saatlik vaktimiz var beyonce 6 da gelir ve 6.59 da partyden ayrılır
    // Örneğin Beyonce'nin partyde bulunma aralığı şu şekilde ifade edilir [6,7)
    //Partyde en çok selfie çekebilmek için hangi zaman aralığında gitmek gerekir????

    static void Main()
    {
        List<(int start, int end)> atParty = new List<(int, int)>{(6, 8), (6, 12), (6, 7), (7, 8), (7, 10), (8, 9), (8, 10), (9, 12),
            (9, 10), (10, 11), (10, 12), (11, 12)};
        var dict = new ConcurrentDictionary<int, int>();

        foreach (var item in atParty)
        {
            for (int i = item.start; i < item.end; i++)
            {
                dict.AddOrUpdate(i, 1, (x, tane) => ++tane);
            }
        }
        var bestTime = dict.Aggregate((selector, input) => input.Value > selector.Value ? input : selector);
        System.Console.WriteLine(bestTime.Value);
    }


}