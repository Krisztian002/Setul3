using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] v1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] v2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        List<int> inter = new List<int>();
        List<int> reuniune = new List<int>();
        List<int> diff1 = new List<int>();
        List<int> diff2 = new List<int>();

        int i = 0, j = 0;
        while (i < v1.Length && j < v2.Length)
        {
            if (v1[i] == v2[j])
            {
                inter.Add(v1[i]);
                reuniune.Add(v1[i]);
                i++; j++;
            }
            else if (v1[i] < v2[j])
            {
                reuniune.Add(v1[i]);
                diff1.Add(v1[i]);
                i++;
            }
            else
            {
                reuniune.Add(v2[j]);
                diff2.Add(v2[j]);
                j++;
            }
        }

        while (i < v1.Length) { reuniune.Add(v1[i]); diff1.Add(v1[i]); i++; }
        while (j < v2.Length) { reuniune.Add(v2[j]); diff2.Add(v2[j]); j++; }

        Console.WriteLine(string.Join(" ", inter));
        Console.WriteLine(string.Join(" ", reuniune));
        Console.WriteLine(string.Join(" ", diff1));
        Console.WriteLine(string.Join(" ", diff2));
    }
}
