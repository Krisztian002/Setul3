using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] v = new int[n];

        for (int i = 0; i < n; i++)
            v[i] = int.Parse(Console.ReadLine());

        for (int i = n - 1; i >= 0; i--)
            Console.Write(v[i] + " ");
    }
}
