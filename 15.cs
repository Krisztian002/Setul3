using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] v = new int[n];
        for (int i = 0; i < n; i++) v[i] = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
            for (int j = i + 1; j < n; j++)
                if (v[j] == v[i])
                    v[j] = int.MinValue;

        for (int i = 0; i < n; i++)
            if (v[i] != int.MinValue)
                Console.Write(v[i] + " ");
    }
}
