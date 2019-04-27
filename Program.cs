using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace C__Örneklerim
{
    /* 
    Burada Async metotları oluşturmak için Task objesinden yararlanmak mantıklı gibi duruyor,
    çünki thread gibi farklı bir threadde çalıştığı için main thread kitlenmiyor,ve async programing
    için daha anlaşılabilir bir hal alıyor,
    Soru? static bir değişkeni değiştirmek istesek ve buna farklı zamanlarda nasıl erişebiliriz?
    Task g() metodu ile daha iyi kavradım Async programlamayı kendi async metodumuzu yazdık istersek Bu
    metodun bitmesini bekliyebiliriz await ile yada beklemek istersek await eklemeden execute edebiliriz metodu,
    Soru 1 eğer async metot içerisindeki local değişkenleri yield return mantığı ile geri dönebilirmiyiz ?
    Soru 2 Dönmek yerine static değişkeni değiştirmesini sağlıyarak bu işlemlerin sonuclarını kontrol edebiliriz,

*/
    class Program
    {
        static int b;
        static async Task Main(string[] args)
        {

            await g();
            while (true)
                System.Console.WriteLine(b);
        }
        static async Task g()
        {
            System.Console.WriteLine(Environment.CurrentManagedThreadId);
            Task a = new Task(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    b = i;
                    Thread.Sleep(100);
                }
            });
            a.Start();
            await a;
        }
    }
}

