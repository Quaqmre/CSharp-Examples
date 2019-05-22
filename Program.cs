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
        }
    }
}

