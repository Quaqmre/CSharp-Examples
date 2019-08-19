// using System;
// using System.Collections;
// using System.Collections.Generic;
// using System.Linq;
// using System.Linq.Expressions;
// using System.Threading;
// using System.Threading.Tasks;
// using System.Timers;

// namespace C__Örneklerim
// {
//     /* 
//     Burada Yapılmak istenen şey çalıştırılan kodların hangi threadlerde ne şekilde çalıştığını anlamaya çalışmak istedim,
//     Bir program single thread te başlar bu hangi thread olduğu önemli değil ve biz belirtmediğimiz sürece metotlar bu thread üzerinde
//     execute edilmeye devam etmektedir,
//     Önemli konulardan Thread.Sleep() ve Task.Delay metotlarını kullanarak aslında thread based programing ve sync async progrmaing hakkında
//     bilgi edinebilmektedir,
//     Single thread çalışmakta olan programımıza Thread.Sleep() veya while(true) ile kitlememiz arasında bir fark yoktur,çünkü
//     programımız artık bu metotlar sonunda işlem yapamaz ve bekleme aşamasına geçmektedir,
//     Task.Delay() aslında logical bir bekleme çeşididir,Tam emin olamamakla birlikte aslında farklı bir thread içerisinde bu delay fonksiyonu
//     çalıştırılmakta ve bunun sonucu istenirse beklenebilmektedir,Örneğin single thread içerisinde bir işlem yapılmakta ve x metodu sırası gereği
//     çağılması gerekmekte ancak bu x metodu devam eden kod içerisinde herhangi bir şekil değiştirmemekte ve etkilememektedir,ancak bu metot sonucunu
//     bir şekilde ileride kullanacağız,O yüzden bu metodu farklı bir thread içerisinde çalıştırmak istiyebiliriz ki kendi single threadimizde
//     İşlemlerimize devam edelim zamanı geldiğinde x metotuda bitmiş ise yada ihtiyacımız olduğu zaman bunun sonucunu kullanmak istediğimizde
//     await yaparak bu metot sonucunu alabiliriz,
//     Yada şuan planladığım kendi event based scheduler servisimi tasarlamak istediğimden eventlerin çağıracağı metotları single thread de çalıştırabilir ancak
//     bu metotları tetikliyecek event sayaçlarımı farklı bir threadde async olarak çalıştırabilirim,
//     *Eğer task.delay verdiğimiz bir metot'u nerden çağırır isek eğer bu delaylı metot' delay komutundan sonra farklı işlemler yapmayada 
//     Devam etmekte ise bu metodu çağırdığımız yerde Delaylı metodumuzu bir şekilde await le beklememiz gerekmekte çünkü farklı thread içerisinde çalıştırılan
//     bir metodu bu async metot içerisinde bekler isek ancak single thread ömrüde bitmiş ise artık farklı threadte devam eden işlemleri kullanamayız
//     çünkü main fonksiyonunun çalıştığı thread ölmüştür.


//     */
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             System.Console.WriteLine(Environment.CurrentManagedThreadId);
//             Task delay = async();
//             sync();
//             delay.Wait();


//         }
//         static void sync()
//         {
//             Thread.Sleep(1);
//             System.Console.WriteLine(Environment.CurrentManagedThreadId + "--sync");
//         }
//         static void sync1()
//         {
//             System.Console.WriteLine(Environment.CurrentManagedThreadId + "--sync1");
//         }
//         static async Task async()
//         {
//             System.Console.WriteLine(Environment.CurrentManagedThreadId + "--async");
//             // var x = Task.Delay(5000);
//             Thread.Sleep(5000);
//             // await x;
//             System.Console.WriteLine("Done");

//         }
//         static async Task async1()
//         {
//             System.Console.WriteLine(Environment.CurrentManagedThreadId + "--async1");
//             Thread.Sleep(1000);
//             System.Console.WriteLine(Environment.CurrentManagedThreadId + "--async1 after 5000 delay");

//         }


//     }
// }

