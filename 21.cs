using System;

class Program
{
    static void Main()
    {
    int[] v1 = {1,3,5};
    int[] v2 = {1,3,4};

    int i = 0;
    while (i < v1.Length && i < v2.Length)
    {
        if (v1[i] < v2[i])
        {
            Console.WriteLine("v1");
            return;
        }
        if (v1[i] > v2[i])
        {
            Console.WriteLine("v2");
            return;
        }
        i++;
    }

    if (v1.Length <= v2.Length)
        Console.WriteLine("v1");
    else
        Console.WriteLine("v2");
    }
}
