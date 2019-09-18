// using System;

// namespace C__Örneklerim
// {
//     class EventDriven1
//     {
//         /* Bu klasör içeriği çalıştırılmak istenirse Program.cs içerisine taşınmalıdır.
//         Burada Amaçlanan bir metot döndüren bir metotdun subsları çalıştırıldığında Ana metot içerisindeki statelerin
//         sanki bir classın en üst scopunda tanımlanmış gibi bir etki yaratır,
//         Kullanım alanları event tabanlı programlamada kullanılabilir ,
//         Ana bir metot tanımlanır ve bunlara subs olan metotlar belirli if koşullarını sağladıklarında kendilerini 
//         Invoke edebilirler,Saat ticki gibi bu Ana metot her çağrıldığında bir flag arttırılır be 
//         Diğer subs olacak metotlar bu flagın bellirli koşullarını sağladıklarında Invoke edilir.
//         Hedef! Bu yapıyı kullanarak kendi tick eventini oluştur.



//          */
//         static Action outofmetot = () => System.Console.WriteLine("Dışardan bir metor");
//         static Action metot1(Action t)
//         {
//             int i = 0;
//             return () =>
//             {
//                 i++;
//                 if (i == 2)
//                     t.Invoke();
//             };
//         }
//         static void Main(string[] args)
//         {
//             Action a = metot1(outofmetot);
//             a();
//             a();
//             a();
//         }
//     }
// }
