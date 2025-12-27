using System;

class Program
{
    static void Main()
    {
        int[] v = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        QuickSort(v, 0, v.Length - 1);
        foreach (int x in v) Console.Write(x + " ");
    }

    static void QuickSort(int[] a, int l, int r)
    {
        if (l < r)
        {
            int p = Partition(a, l, r);
            QuickSort(a, l, p - 1);
            QuickSort(a, p + 1, r);
        }
    }

    static int Partition(int[] a, int l, int r)
    {
        int pivot = a[r], i = l - 1;
        for (int j = l; j < r; j++)
            if (a[j] <= pivot)
            {
                i++;
                int t = a[i]; a[i] = a[j]; a[j] = t;
            }
        int tmp = a[i + 1]; a[i + 1] = a[r]; a[r] = tmp;
        return i + 1;
    }
}
