// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading;
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
//         static void Main(string[] args)
//         {
//             ILife<string> moreComplex = new Human<string>();
//             ILife<object> lessComplex = new Human<object>();
//             moreComplex = lessComplex;
//             // lessComplex = moreComplex;
//         }
//     }

//     interface ILife<in TLife>
//     {
//     }
//     class Human<TLife> : ILife<TLife>
//     {

//     }


// }
