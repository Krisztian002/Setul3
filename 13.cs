using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; i++) a[i] = int.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
            for (int j = i + 1; j < n; j++)
                if (a[j] < a[i])
                {
                    int t = a[i];
                    a[i] = a[j];
                    a[j] = t;
                }

        for (int i = 0; i < n; i++) Console.Write(a[i] + " ");
    }
}
