// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading;
// using System.Threading.Tasks;
// using System.Threading.Tasks.Dataflow;


// namespace C__Örneklerim
// {
//     /*
//         Generic intheridence yapıldığında kalıtım verdiğin classa şunu söyleyebilmekteyim
//         Interface<in x> yapısı demek Sen daha komplex bir yapı olabilirsin ancak geriye dönük evrim geçiremezsin,
//         Interface<out y> yapısı ise sen daha koplex olamazsın ancak geriye dönük değişimler geçirebilirsin demek,

//         interface'e in out parametresi geçmez isek içerisine <parametre> bunlar birbirlerine dönüştürülememektedir,
//         interface'e <parametre> almaz ise bunlar birbirlerine dönüştürülebilir,
//      */
//     class Program
//     {
//         static string a = "asd";
//         static char b = 'g';
//         static async Task Main(string[] args)
//         {
//             System.Console.WriteLine("main:" + Environment.CurrentManagedThreadId);
//             // await deneme();//Bu metot beklenir çünkü thread burada bekler 
//             deneme();//Bu metot execute edilir nerede ne yaptığıyla ilgilenmez deneme içindeki while ve main threadteki while execute edilir,
//             while (true)
//             {
//                 System.Console.WriteLine("********************************");
//             }

//             // // string str1 = "hello"; // Bu alanda unsafeteki gibi aynı stringlere aynı adres mi atanmakta bunu check ettim
//             // // string str2 = "hello"; // Ancak aynı adres atanıyor olsa bile bir adres değiştiğinde diğeri etkilenmemekte,
//             // // str2 = str2 + "asd";
//             // // System.Console.WriteLine(str1);
//             // // System.Console.WriteLine(str2);
//             // // cronosFunc(str1, str2);
//         }
//         static async Task deneme()
//         {
//             // System.Console.WriteLine("ilk:" + Environment.CurrentManagedThreadId);
//             // await Task.Delay(5000);
//             await deneme1();
//         }
//         static async Task deneme1()
//         {
//             // System.Console.WriteLine("ilk:" + Environment.CurrentManagedThreadId);
//             // await Task.Delay(5000);
//             await Task.Run(() =>
//             {
//                 while (true)
//                 {
//                     System.Console.WriteLine("-----------------------------------");
//                 }
//             });

//         }
//         public static unsafe void GCDeneme()
//         {
//             /*
//             Garbage Collector için 1000 obje oluşturararak sadece 1 tanesinin referansını tutuyoruz,
//             We Garbage collectorü çağırarak rami temizlemesini istiyoruz,
//              */
//             object ob;
//             for (int i = 0; i < 1000; i++)
//             {
//                 ob = new object();
//             }
//             Console.WriteLine("Memory used before collection:       {0:N0}",
//                        GC.GetTotalMemory(false));
//             ob = "asd";
//             Console.WriteLine("Memory used before collection:       {0:N0}",
//                       GC.GetTotalMemory(false));
//             GC.Collect(); // Garbage kollaktörü temizlemesi için çağırdık

//             int y = 1;
//             int* x = &y;
//             fixed (char* value = a)
//             {
//                 var pointer = value;
//                 var deneme = pointer + (byte)1;
//                 var deneme2 = pointer + (byte)2;
//                 var deneme3 = pointer + (byte)3;
//             }//Farklı adreslerdeki değerleri çekmek için adresi 1 er 1 er arttırıyoruz,
//             Console.WriteLine("Memory used after full collection:   {0:N0}",
//                         GC.GetTotalMemory(true));
//         }
//     }
// }
