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
    Task.Factory.StartNew(Action,ASync state) Burada ilk döküman Bir metot belirtir ve farklı threadte çalışmakta,
    ikinci alan ise bu threadte çalışan Taskın(görebin) sahip olduğu local state olarak
    Belirtiriz CustomData classı oluştururuz ve Bu thread ile alakalı değişkenleri bu state atayabiliriz,
    Task oluşturursak buna sadece action atayabilirz ancak geri döndürmek istediğimiz bir bilgi olduğunda,
    bunu oluşturduğumuz taska girdi olarak alıp,2. bir alan olarak bu state dışarı çıkarabiliriz,
    Buda bize sadece static state üzerinden bilgi aktarımı yapmaktan ziyade her görev ve threadin 
    local değişkeni olarak kullanabiliriz,
    Soru? eğer Tüm tasklar aynı threadin üzerinde çalışırsa bu state en son çalışan taskın bilgilerini mi tutar
    yoksa her task objesi kendi statesini mi tutmaktadır,
    Cevap=Thread dışında her state objeye özgü olarak tutulmaktadır,Buda İyi birşey,eğerki 10 task sadece 2 threadte
    çalışır ise bu local state thearede özgü olmayacak bu taskın atandığı objeye özgü olacak,Daha kullanışlı olacaktır.
    Thread based olması istenirse dışarıdan farklı bir static objeye atama yapılabilir.

    */
    class CustomData
    {
        public long CreationTime;
        public int Name;
        public int ThreadNum;
    }

    public class Program
    {
        // static Task a = new Task((Object f) =>
        // {
        //     CustomData data = f as CustomData;
        //     data.Name = 2;
        // },
        // new CustomData()
        // );
        public static void Main()
        {
            // a.Start();
            // a.Wait();
            // var x = a.AsyncState as CustomData;
            // System.Console.WriteLine(x.Name + x.ThreadNum
            // );


            Task[] taskArray = new Task[10];
            for (int i = 0; i < taskArray.Length; i++)
            {
                taskArray[i] = Task.Factory.StartNew((Object obj) =>
                {
                    CustomData data = obj as CustomData;
                    if (data == null)
                        return;

                    data.ThreadNum = Thread.CurrentThread.ManagedThreadId;
                    Thread.Sleep(1000);
                }, new CustomData() { Name = i, CreationTime = DateTime.Now.Ticks });
            }
            Task.WaitAll(taskArray);
            foreach (var task in taskArray)
            {
                var data = task.AsyncState as CustomData;
                if (data != null)
                    Console.WriteLine("Task #{0} created at {1}, ran on thread #{2}.",
                                      data.Name, data.CreationTime, data.ThreadNum);
            }
        }
    }
}
