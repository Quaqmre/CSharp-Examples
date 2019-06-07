using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

/*
subtotal olarak paralel for'a girdi olarak verdiğimiz alan threadlerin local statesini belirtir,
Thread işlemini yapıp bir süre bekler ise yine bu local statesine ulaşabilir
Bize avantaj olarak her threadin bir üst fonsiyondaki static değişkeni değiştirmesinden ziyade,
Kendi iş ömürleri boyunca local statelerine veri atabilirler ve bu şekilde iş ömrü biten threadler
Thread sayısı kadar bu üst static değişkeni kitliyerek ekleme yapabilir,Performans açısından önemli bir katkı sağlar bu
Adındanda anlaşılacağı üzere benim forumda ()=>0,olarak geçen,Documantasyonlarda initial local state olarak geçen alan
Her paralel task için başlatıcı local değişken olarak kabul ediliyor,ve threde bir local state geçirmiş oluyoruz,


 */
class MultiplyMatrices
{
    static void Main()
    {
        int[] nums = Enumerable.Range(0, 1000000).ToArray();
        long total = 0;

        // Use type parameter to make subtotal a long, not an int
        Parallel.For<long>(0, nums.Length, () => 0, (j, loop, subtotal) =>
        {
            subtotal += nums[j];
            return subtotal;
        },
            (x) => Interlocked.Add(ref total, x)
        );

        Console.WriteLine("The total is {0:N0}", total);
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
    }
}