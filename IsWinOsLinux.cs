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
class Program
{
    public static bool IsWin() =>
      RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

    public static bool IsMac() =>
        RuntimeInformation.IsOSPlatform(OSPlatform.OSX);

    public static bool IsGnu() =>
        RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
    public static string GetCurrent()
    {
        return
        (IsWin() ? "win" : null) ??
        (IsMac() ? "mac" : null) ??
        (IsGnu() ? "gnu" : null);
    }
    static void Main()
    {
        var x = GetCurrent();
        System.Console.WriteLine(x);
    }

}
//</snippet1>