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
Async metotlar tanımlamak için kullanılacak Task classını main threadte başlatmak istersek
RunSyncronsly metodu ile başlatabilir,Farklı bir threadte başlatmak istersekte 
Start() metodu ile başlatabiliriz,Veya bir obje nitelemesi ilede başlatılabilir
Task.Factory.StartNew(action,"taskId") bu yöntem ile execute edilemedi.
Soru?Neden Task.Factory yöntemi ile execute edilemedi..


*/
    class Program
    {
        static object c = null;

        static Action a = () => { System.Console.WriteLine(Thread.CurrentThread.ManagedThreadId); };
        static void Main(string[] args)
        {
            System.Console.WriteLine("MainTHreadID=" + Thread.CurrentThread.ManagedThreadId);
            System.Console.WriteLine("IsBackendThread??=" + Thread.CurrentThread.IsBackground);
            Task t1 = new Task(a);
            t1.RunSynchronously();
            t1.Start();
            t1.Wait();
            System.Console.WriteLine("Finished");
        }



    }
}
