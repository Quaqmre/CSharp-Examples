using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading;
// using System.Threading.Tasks.Dataflow;


// namespace C__Örneklerim
// {
//     /*
//    Burada C#'ın stackte valueleri falan nasıl kullandığını gördük,
//    bir array oluşturmuş olsakta buna sadece ilk değerin adresi atanmakta ve 
//    arrayin diğer adreslerine ulaşmak istediğimizde byte array olduğu için diğer valuelar
//    1 adres ileri yazılmakta çok hoş :D

//    2 Array tanımlandığında aralarında ortalama 16 decimallık adres farkı bulunmakta

//    Ayrıca Tekil byte pointerlar tanımlandı  ,
//    ve bunlar stackten ilk adres olarak 0x00000 almakta ancak bir byte değerinin adresine
//    eşitle dediğimizde tanımnlanan byte=1 değerinin adresi bu byte* a atanmakta,
//      */
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             byte[] a = new byte[] { 1, 1, 1, 1 };
//             a[0] = 3;
//             System.Console.WriteLine(a[2]);
//             deneme();
//         }
//         public static unsafe void deneme()
//         {
//             byte* arr = stackalloc byte[3];
//             byte* arr1 = stackalloc byte[3];
//             arr[0] = 97;
//             arr[1] = 97;
//             arr[2] = 97;//tüm arr'içeriği aynı adresi göstermekte,
//                         //Array [0] adresini bir pointera atar ve içeriğini değiştirirsem
//                         //Tüm array içeriği değişmekte :D
//             byte* av = &arr[0];
//             *av = 1;
//             byte x = 255;
//             byte* ptr3 = &x;
//             System.Console.WriteLine(arr[0].GetHashCode());
//             System.Console.WriteLine(arr[1].GetHashCode());

//             byte* ptr = &arr[0];
//             byte* ptr1 = &arr[2];
//             byte yy = *ptr;
//             byte adre = yy;
//             System.Console.WriteLine(yy.GetHashCode());
//             System.Console.WriteLine(((byte)adre).GetHashCode());
//             byte* ptr2 = &arr1[0];
//             // System.Console.WriteLine(*ptr);
//             // System.Console.WriteLine(((int)ptr).ToString("X"));


//             // byte x = 1;
//             // byte y = 16;
//             // byte* p;
//             // p = &x;
//             // byte* p1 = p;
//             // p1 = &y;
//             // System.Console.WriteLine((int)p1);
//         }

//     }
// }
