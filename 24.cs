using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] v1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] v2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int n = Math.Max(v1.Length, v2.Length);

        int[] intersectie = new int[n];
        int[] reuniune = new int[n];
        int[] diferentaV1V2 = new int[n];
        int[] diferentaV2V1 = new int[n];

        for (int i = 0; i < n; i++)
        {
            int a = i < v1.Length ? v1[i] : 0;
            int b = i < v2.Length ? v2[i] : 0;

            intersectie[i] = a & b;
            reuniune[i] = a | b;
            diferentaV1V2[i] = a & ~b;
            diferentaV2V1[i] = b & ~a;
        }

        Console.WriteLine(string.Join(" ", intersectie));
        Console.WriteLine(string.Join(" ", reuniune));
        Console.WriteLine(string.Join(" ", diferentaV1V2));
        Console.WriteLine(string.Join(" ", diferentaV2V1));
    }
}
