using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] v = new int[n];
        for (int i = 0; i < n; i++)
            v[i] = int.Parse(Console.ReadLine());

        int k = int.Parse(Console.ReadLine());
        k = k % n;

        int[] temp = new int[k];
        for (int i = 0; i < k; i++)
            temp[i] = v[i];

        for (int i = 0; i < n - k; i++)
            v[i] = v[i + k];

        for (int i = 0; i < k; i++)
            v[n - k + i] = temp[i];

        for (int i = 0; i < n; i++)
            Console.Write(v[i] + " ");
    }
}
