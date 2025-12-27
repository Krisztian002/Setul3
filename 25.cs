using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] v1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] v2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int[] result = new int[v1.Length + v2.Length];
        int i = 0, j = 0, k = 0;

        while (i < v1.Length && j < v2.Length)
            result[k++] = v1[i] < v2[j] ? v1[i++] : v2[j++];

        while (i < v1.Length) result[k++] = v1[i++];
        while (j < v2.Length) result[k++] = v2[j++];

        Console.WriteLine(string.Join(" ", result));
    }
}
