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
    Okuduğum dökümanlarda Thread ile farklı threadte iş yaptırmaktan ziyade threadpool kullanılması tavsiye ediliyor,
    Bunun nedeni SwitchContex olduğu belirtiliyor,Bir threadin uyutuması uyandırılması,öldürülmesi veya
    yaratılması iş maliyeti çok bir uygulama bu yüzden threadpool,çalışma zamanında bu işleri kendi handle ediyor,
    Eğer çalıştırılabilecek uykuda thread varsa bunun üzerinde bu işlemi execute eder,
    Maliyetli işleri tercih etmeden en iyi kombinasyonu bize sunar.
    */

    class Program
    {
        public static void Main()
        {
            // Queue the task.
            ThreadPool.QueueUserWorkItem(ThreadProc);
            Console.WriteLine("Main thread does some work, then sleeps.");

            Console.WriteLine("Main thread exits.");
        }

        // This thread procedure performs the task.
        static void ThreadProc(Object stateInfo)
        {
            Thread.Sleep(1000);
            // No state object was passed to QueueUserWorkItem, so stateInfo is null.
            Console.WriteLine("Hello from the thread pool.");
        }
    }
}
