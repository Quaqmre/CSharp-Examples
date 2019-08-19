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
//             await Task.Delay(1);
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
//         public static unsafe void staticAdres(string statics)
//         {
//             /*
//             Denenmek istenen şey fixed içerisinde bir pointera atanan adresin değişip değişmediğini kontrol etmekti
//             Bunun nedeni fixed alanı içerisinde value adresinin değişik değişmediğini kontrol etmekti */
//             char* i;
//             char k = 'k';
//             char j = 'j';
//             i = &k;
//             i = &j;

//             fixed (char* value = statics)
//             {
//                 var pointer = value;
//                 char* ii;
//                 char kk = 'k';
//                 char jj = 'j';
//                 ii = &kk;
//                 ii = &jj;
//             }

//         }
//         public static unsafe void cronosFunc(string statics, string statics1)
//         {
//             //Cronos reposunun örnek metotlarıdır.
//             string dd = statics; // stringleri aynı yerde store ediliyor çünkü ikiside aynı adres oalrak gösterilmekte,
//             System.Console.WriteLine();
//             fixed (char* value2 = statics1)
//             {
//             }
//             fixed (char* value = statics)
//             {
//                 char x = 'c';
//                 var pointer = value;
//                 *pointer = x;
//                 SkipWhiteSpaces(ref pointer);
//                 Accept(ref pointer, '@');
//             }
//         }
//         private static unsafe void SkipWhiteSpaces(ref char* pointer)
//         {
//             //Cronos reposunun örnek metotlarıdır.

//             while (IsWhiteSpace(*pointer)) { pointer++; }
//         }
//         private static bool IsWhiteSpace(int code)
//         {
//             //Cronos reposunun örnek metotlarıdır.

//             return code == '\t' || code == ' ';
//         }
//         private static unsafe bool Accept(ref char* pointer, char character)
//         {
//             //Cronos reposunun örnek metotlarıdır.

//             if (*pointer == character)
//             {
//                 pointer++;
//                 return true;
//             }

//             return false;
//         }
//         private static unsafe bool AcceptCharacter(ref char* pointer, char character)
//         {
//             //Cronos reposunun örnek metotlarıdır.

//             if (ToUpper(*pointer) == character)
//             {
//                 pointer++;
//                 return true;
//             }

//             return false;
//         }
//         private static int ToUpper(int code)
//         {
//             //Cronos reposunun örnek metotlarıdır.

//             if (code >= 97 && code <= 122)
//             {
//                 return code - 32;
//             }

//             return code;
//         }



//     }
// }
