using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool[] prim = new bool[n + 1];

        for (int i = 2; i <= n; i++) prim[i] = true;

        for (int p = 2; p * p <= n; p++)
            if (prim[p])
                for (int i = p * p; i <= n; i += p)
                    prim[i] = false;

        for (int i = 2; i <= n; i++)
            if (prim[i])
                Console.Write(i + " ");
    }
}
