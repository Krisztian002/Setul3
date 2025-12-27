using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] v = new int[n];

        for (int i = 0; i < n; i++)
            v[i] = int.Parse(Console.ReadLine());

        int min = v[0], max = v[0];
        int pozMin = 0, pozMax = 0;

        for (int i = 1; i < n; i++)
        {
            if (v[i] < min)
            {
                min = v[i];
                pozMin = i;
            }
            if (v[i] > max)
            {
                max = v[i];
                pozMax = i;
            }
        }

        Console.WriteLine(pozMin + 1);
        Console.WriteLine(pozMax + 1);
    }
}
