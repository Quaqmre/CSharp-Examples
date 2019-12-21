// using System;
// using System.Collections.Generic;
// using System.Globalization;
// using System.Linq;
// using System.Reflection;
// using System.Threading;
// using System.Threading.Tasks.Dataflow;

// namespace C__Örneklerim
// {
//     /*
//    Bir file yazmak için kullanılmaktadır
//      */
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Parser<Okul> pars = new Parser<Okul>();
//             List<string> strList = new List<string>() { "yusuf", "2" };
//             var t = pars.Parse(strList);
//         }
//     }
//     public class Okul
//     {
//         [CustomAttribute(0)]
//         public string name { get; set; }
//         [CustomAttribute(1)]
//         public int capacity { get; set; }
//     }
//     /*
//      Parser Generic Bir Type almakta be gelen string listeyi kendi propertilerine göre ayrıca propertilerinde yer alan customAtrribute sırasına göre
//      valuleri alarak property typına çevirmekte ve ürtettiği new T() objesine bu propertileri atamaktadır,
//      Attibute sıra belirlemekte,gelen str listesine göre değer çekmekte çekilen değeri propertinin typına göre parse etmekte ve
//      propertiye value olarak set etmektedir,Tüm propertileri set edildiğinde bir listeye bunlar eklenmekte ve 
//      geriye oluşturulan bu Liste dönmektedir,Hoş güzel bir yaklaşım genericlere.
//     */
//     public class Parser<T> where T : new()

//     {
//         public List<T> Parse(List<string> strList)
//         {
//             var item = new T();//generic type türetme
//             Type t = typeof(T);
//             List<T> list = new List<T>();
//             PropertyInfo[] properties = t.GetProperties(); // generic gelen typin propertiesini aldık

//             foreach (var prop in properties)
//             {
//                 object tmp = prop.GetCustomAttributes(typeof(CustomAttribute), false)
//                             .FirstOrDefault();
//                 var itemOrder = ((CustomAttribute)tmp)?.Order ?? -1;
//                 var value = strList[itemOrder];
//                 var intt = typeof(int);
//                 var strr = typeof(string);

//                 if (prop.PropertyType == intt)
//                 {
//                     prop.SetValue(item, (int)double.Parse(value, CultureInfo.InvariantCulture), null);
//                 }

//                 if (prop.PropertyType == strr)
//                 {
//                     prop.SetValue(item, value, null);
//                 }
//             }
//             list.Add(item);

//             return list;


//         }
//     }
//     [AttributeUsage(AttributeTargets.Property)]
//     public class CustomAttribute : Attribute
//     {
//         public CustomAttribute(int order)
//         {
//             Order = order < 0
//                 ? throw new ArgumentException($"{nameof(order)} can't be less than zero.")
//                 : order;
//         }

//         public int Order { get; }
//     }
// }
