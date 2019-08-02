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
using System.Text;

class Program
{
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
    static string a;

    static void Main(string[] args)
    {
        //   byte[] data = Encoding.ASCII.GetBytes("deneme");
        // System.Console.WriteLine(Encoding.ASCII.GetString(data));

        a = "deneme";
        int size = a.Length;
        byte[] data = Encoding.ASCII.GetBytes("deneme");
        byte[] data1 = new byte[size];
        IntPtr ptr = Marshal.AllocHGlobal(size);
        Marshal.Copy(ptr, data1, 0, size);
        for (int i = 0; i < size; i++)
        {
            Marshal.WriteByte(ptr, i * 1, data[i]);
        }
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(Marshal.ReadByte(ptr, i * 1));
        }
        string hash = String.Empty;
    }
}