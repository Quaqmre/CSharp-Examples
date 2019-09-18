using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks.Dataflow;
using System.Web;
using LiteDB;
using MonkeyCache;
using MonkeyCache.FileStore;

namespace C__Örneklerim
{
    /*
     regex içerisinde match metodu denenmekte,
     */
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            deneme(); // unsafe metodumu çağırarak c kodlarını denemekteyim
            string a = "deneme123";//string adresi içerisinde değişiklik yapılırsa stringde değişir;
            denemestr(a); // str fonksiyonuna bir string gönderildi

            string x = "J%2BILg1vyr6T%2B6RG%2Fv9d17mQ4fOuPTwniGuIHPFIb8o4%3D%40MjEwNzQ%3D";
            var cikti = HttpUtility.UrlDecode(x, Encoding.ASCII);
        }

        unsafe struct okul // C levelde bir struct tanımlaması yapıldı
        {
            public int sinif;
            public int ders;
        }

        static unsafe void deneme()
        {
            okul o; // bir struct oluşturuldu
            okul* adres = &o; // oluşturulan structın adresi bir pointera atandı
            o.sinif = 10; // struct içindeki değer değiştirildi.
            adres->sinif = 13; // Önemli,pointera atanan struct adresi üzerinden gerçek struct propertisinin değeri değiştirildi
            denemestruct(&o); //oluşturulan struct adresi bir metoda parametre geçildi
            int[] array = { 1, 2, 3 }; // oluşturulan arraylerin adresleri bir pointera parametre olarak geçilmek istenirse fixed içerisinde geçilebilmektedir
            int* a, b, ar; // bir int pointerı oluşturudu
            int t = 1;
            int t2 = 2;
            fixed (int* den = array) // oluşturulan arrayin adresi fixed içerisinde bir int pointerine atanabilmektedir.
            {
                ar = den; // int pointer içerisine array adresi atanmıştır
                ar[2] = 6; // Ve bu int pointeri üzerinden 2 byte ileri giderek arrayin 3. elemanı değiştirmekteyiz,
            }

            a = &t; // tanımlanan int'ların adresleri pointera atanmaktadır.
            b = &t2;// tanımlanan int'ların adresleri pointera atanmaktadır.
            t = *b; // bir int pointerin gösterdiği adresteki value bir interger varaibla atanmıştır.
            int z = 3;
            var j = &z;
            deneme2(a); //bir metoda int pointer parametre olarak geçilmektedir.

        }
        static unsafe void deneme2(int* girdi)
        {//gönderilen type value type olduğu için girdi adresi 5'in adresi olarak atandı ancak deneme2 içerisinde gönderilen a Değeri değişmedi
         //metot bittiğinde tüm adresler ve valueler kayboldu.
            int ty = 15;
            girdi = (int*)5;
        }
        static unsafe void denemestr(string girdi)
        {//gönderilen stringin 3. elemanı r olarak değiştirildiğinde ref type olduğu için ana stringde değişiklik gösterdi.
            fixed (char* x = girdi)
            {
                x[2] = 'r';
            }
        }
        static unsafe void denemestruct(okul* a) // metot içerisinde bir structun adresini almakta ve içerisinde bu adres üzerindeki değerleri değştirmekte.
        {
            a->sinif = 12; // bir struct pointeri ile bir değer bu şekilde değiştirilebilmektedir.
        }
    }
}

