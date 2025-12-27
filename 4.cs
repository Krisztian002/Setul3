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
        int cmin = 1, cmax = 1;

        for (int i = 1; i < n; i++)
        {
            if (v[i] < min)
            {
                min = v[i];
                cmin = 1;
            }
            else if (v[i] == min)
                cmin++;

            if (v[i] > max)
            {
                max = v[i];
                cmax = 1;
            }
            else if (v[i] == max)
                cmax++;
        }

        Console.WriteLine(min + " " + cmin);
        Console.WriteLine(max + " " + cmax);
    }
}
