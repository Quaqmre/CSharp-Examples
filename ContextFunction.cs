using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Microsoft.Extensions.Caching.Memory;

namespace C__Örneklerim
{
    /*
     Dependency injection olarak değerlendirilebilir,bir parent item içerisinden gerekli metotlar veya objeler alınarak
     Başka bir yerde kullanılmak üzere Func<string,string> objesine pars edilmektedir.
*/
    public class objHandler
    {
        public Dictionary<string, object> obDict = new Dictionary<string, object>();
        public objHandler(string key, object t)
        {
            obDict.Add(key, t);
        }
        public object getObj(string key)
        {
            return obDict.GetValueOrDefault(key);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            // Console.ReadLine();
            // Func<string, string> denemeFunc = (t) =>
            // {
            //     return "akif";
            // };

            // var handLerClass = new objHandler("denemeFunc", denemeFunc);
            // var gettedMyFunc = handLerClass.getObj("denemeFunc") as Func<string, string>;

            // var returnString = gettedMyFunc("denedim olmadı");

            // System.Console.WriteLine(returnString);
            var sum = 0;
            for (int i = 0; i < 2; i++)
            {
                sum += Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(sum);

        }
    }
}
