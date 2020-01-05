using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace C__Örneklerim
{

    /* 
    Generic metot tanımlamak için aşağıdaki gibi metot yanına generic olduğunu anlatan <T> eklenmelidir.
    new yapılabilmesi için t nin Newlenbilen olduğunu belirtmek için where T:new() şekilde eklenebilir
*/
    class Program
    {
        static void Main(string[] args)
        {
            deneme(4);
            deneme((double)56);
            deneme(new object());
            // deneme("asd"); // hata verecektir çünkü string newlenemez birer objedir.Intler neden newlenebiliyor bilen yok:D
        }
        static void deneme<T>(T obj) where T : new()
        {
            T nesne = new T();
            System.Console.WriteLine(nesne.GetType());

        }
    }
}
