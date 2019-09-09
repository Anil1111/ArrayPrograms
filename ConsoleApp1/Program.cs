using System;
using System.Diagnostics;

class Program
{
    const int _max = 1000000;
    static void Main()
    {
        // Version 1: use an empty array cache to avoid creating more than 1 array.
        var s1 = Stopwatch.StartNew();
        for (int i = 0; i < _max; i++)
        {
            if (Method1().Length != 0)
            {
                return;
            }
        }
        s1.Stop();
        // Version 2: use a new array on each method call.
        var s2 = Stopwatch.StartNew();
        for (int i = 0; i < _max; i++)
        {
            if (Method2().Length != 0)
            {
                return;
            }
        }
        s2.Stop();
        Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) /
            _max).ToString("0.00 ns"));
        Console.WriteLine(((double)(s2.Elapsed.TotalMilliseconds * 1000000) /
            _max).ToString("0.00 ns"));
    }

    static int[] _emptyArrayCache = new int[0];
    static int[] Method1()
    {
        return _emptyArrayCache; // Return the cached array.
    }

    static int[] Method2()
    {
        return new int[0]; // Return a new array.
    }
}

