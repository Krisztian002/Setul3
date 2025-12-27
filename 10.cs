using System;

class Program
{
    static void Main()
    {
        int[] vector = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int k = int.Parse(Console.ReadLine());

        int stanga = 0;
        int dreapta = vector.Length - 1;

        while (stanga <= dreapta)
        {
            int mijloc = (stanga + dreapta) / 2;

            if (vector[mijloc] == k)
            {
                Console.WriteLine(mijloc);
                return;
            }

            if (vector[mijloc] < k)
            {
                stanga = mijloc + 1;
            }
            else
            {
                dreapta = mijloc - 1;
            }
        }

        Console.WriteLine(-1);
    }
}
