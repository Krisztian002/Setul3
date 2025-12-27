using System;

class Program
{
    static void Main()
    {
        int[] v = { 1, 0, 2, 0, 3, 0, 4 };

        int index = 0;
        for (int i = 0; i < v.Length; i++)
        {
            if (v[i] != 0)
            {
                int temp = v[i];
                v[i] = v[index];
                v[index] = temp;
                index++;
            }
        }

        foreach (var x in v)
            Console.Write(x + " ");
    }
}
