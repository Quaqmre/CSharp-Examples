using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.IO;
using System.Runtime.InteropServices;
using System.Net.Sockets;
using System.Net;

class Program
{
    static void Main()
    {
        var native = Marshal.AllocHGlobal(100);
        Span<byte> nativeSpan;
        unsafe
        {
            nativeSpan = new Span<byte>(native.ToPointer(), 100);
        }
        byte data = 0;
        for (int ctr = 0; ctr < nativeSpan.Length; ctr++)
            nativeSpan[ctr] = data++;
        Marshal.FreeHGlobal(native);

        int nativeSum = 0;
        foreach (var value in nativeSpan)
            nativeSum += value;

        Console.WriteLine($"The sum is {nativeSum}");
        // Output:  The sum is 4950
        unsafe
        {
            var x = asd();
            System.Console.WriteLine();
        }
    }

    static unsafe void* asd()
    {
        var native = Marshal.AllocHGlobal(100);
        return native.ToPointer();
    }
}