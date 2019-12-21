// using System;
// using System.Collections;
// using System.Collections.Generic;
// using System.Diagnostics;
// using System.Linq;
// using System.Linq.Expressions;
// using System.Threading;
// using System.Threading.Tasks;
// using System.Timers;

// namespace C__Örneklerim
// {
//     /* 
//     Object Orianted Programing 101
// */
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             var intgenereted = new intGenerator<int>();
//             intgenereted.generateInt();
//             // intgenereted.generateThingsFromTop("string");//This cant compile beacause our objcet passed generic type with int ,but we are trying pass string in abstract public metot
//             // // if we want to protect values for our lowest metot we should give him abstract and dont let who else to pass in to the pecific value,
//             // // abstract class and protected methods give as to the change write more type safe code. 



//         }
//     }

//     public abstract class generetor<Ttype>
//     {
//         protected void generateThings(Ttype a)
//         {

//             if (a is int)
//                 System.Console.WriteLine("input is int");
//             if (a is string)
//                 System.Console.WriteLine("input is string");
//         }
//         public void generateThingsFromTop(Ttype a)
//         {

//             if (a is int)
//                 System.Console.WriteLine("input is int");
//             if (a is string)
//                 System.Console.WriteLine("input is string");
//         }
//         public abstract void overRightIt(); // this syntax overrite when inherit abstract class pin down,
//     }
//     public class intGenerator<Tinput> : generetor<Tinput>
//     {
//         readonly Tinput a;
//         public intGenerator()
//         {
//             a = default;
//         }
//         public void generateInt()
//         {
//             base.generateThings(a);
//         }

//         public override void overRightIt()
//         {
//             throw new NotImplementedException();
//         }
//     }
// }

