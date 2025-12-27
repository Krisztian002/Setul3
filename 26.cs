using System;

class Program
{
    static void Main()
    {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();

        int n = s1.Length, m = s2.Length;
        int max = Math.Max(n, m);
        int[] a = new int[max];
        int[] b = new int[max];

        for (int i = 0; i < n; i++) a[i] = s1[n - 1 - i] - '0';
        for (int i = 0; i < m; i++) b[i] = s2[m - 1 - i] - '0';

        int[] sum = new int[max + 1];
        for (int i = 0; i < max; i++)
        {
            sum[i] += a[i] + b[i];
            sum[i + 1] += sum[i] / 10;
            sum[i] %= 10;
        }
        bool started = false;
        for (int i = max; i >= 0; i--)
        {
            if (sum[i] != 0) started = true;
            if (started) Console.Write(sum[i]);
        }
        if (!started) Console.Write("0");
        Console.WriteLine();

        int[] diff = new int[max];
        for (int i = 0; i < max; i++)
        {
            diff[i] = a[i] - b[i];
            if (diff[i] < 0)
            {
                diff[i] += 10;
                a[i + 1]--;
            }
        }
        started = false;
        for (int i = max - 1; i >= 0; i--)
        {
            if (diff[i] != 0) started = true;
            if (started) Console.Write(diff[i]);
        }
        if (!started) Console.Write("0");
        Console.WriteLine();

        int[] prod = new int[2 * max];
        for (int i = 0; i < max; i++)
            for (int j = 0; j < max; j++)
            {
                prod[i + j] += a[i] * b[j];
                prod[i + j + 1] += prod[i + j] / 10;
                prod[i + j] %= 10;
            }
        started = false;
        for (int i = 2 * max - 1; i >= 0; i--)
        {
            if (prod[i] != 0) started = true;
            if (started) Console.Write(prod[i]);
        }
        if (!started) Console.Write("0");
        Console.WriteLine();
    }
}
