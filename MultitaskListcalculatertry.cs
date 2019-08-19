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

Son olarak Task metoduda eklendi,New Task olarak Action metoduna parametre geçme örneğinede bu proje altından erişilebilir,



*/
    class Program
    {
        static long toplam = 0;
        static byte[] values = new byte[5000000];
        static void Main(string[] args)
        {
            System.Console.WriteLine("started progress");
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var rnd = new Random(100);
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = (byte)rnd.Next(10);
            }
            System.Console.WriteLine(watch.Elapsed);
            watch.Reset();
            watch.Start();
            System.Console.WriteLine("multithreadprogress");
            Thread[] listth = new Thread[Environment.ProcessorCount];
            for (int t = 0; t < Environment.ProcessorCount; t++)
            {
                listth[t] = new Thread(multipleprocess);
                listth[t].Start(t);
            }
            for (int tt = 0; tt < Environment.ProcessorCount; tt++)
                listth[tt].Join();

            watch.Stop();
            System.Console.WriteLine(watch.Elapsed);
            watch.Reset();
            watch.Start();
            System.Console.WriteLine("multiTasking");
            Task[] listth1 = new Task[Environment.ProcessorCount];
            for (int t = 0; t < Environment.ProcessorCount; t++)
            {
                listth1[t] = Task.Factory.StartNew(atomicProg, t);
                //new Task(atomicProg, t).RunSynchronously(); Şeklinde syncron bir şekilde execute edilebilir,


            }
            Task.WaitAll(listth1);
            System.Console.WriteLine(watch.Elapsed);


        }
        static void multipleprocess(object portionNumber)
        {
            long x = 0;
            System.Console.WriteLine(portionNumber);
            var rnd = new Random(100);
            for (int ii = (int)portionNumber * values.Length / Environment.ProcessorCount; ii < (int)portionNumber
            * (values.Length / Environment.ProcessorCount) + values.Length / Environment.ProcessorCount; ii++)
            {
                x += values[ii];
            }
            toplam += x;

        }
        static Action<object> atomicProg = (object gg) =>
                {
                    {
                        for (int ii = (int)gg * values.Length / Environment.ProcessorCount; ii < (int)gg
                        * (values.Length / Environment.ProcessorCount) + values.Length / Environment.ProcessorCount; ii++)
                        {
                            values[ii] = 1;
                        }
                    }
                };



    }
}

