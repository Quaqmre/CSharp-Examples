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
    public static string GetLocalIPv4()
    {
        string localIP;
        using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
        {
            socket.Connect("8.8.8.8", 65530);
            IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
            localIP = endPoint.Address.ToString();
        }
        return localIP;
    }

    static void Main()
    {
        var x = Environment.GetEnvironmentVariables();
        var tt = GetLocalIPv4();
        System.Console.WriteLine("akif");


    }
}