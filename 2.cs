using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int[] v = new int[n];
        int poz = -1;

        for (int i = 0; i < n; i++)
        {
            v[i] = int.Parse(Console.ReadLine());
            if (v[i] == k && poz == -1)
                poz = i + 1;
        }

        Console.WriteLine(poz);
    }
}
