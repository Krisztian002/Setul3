using System;

class Program
{
    static void Main()
    {
        int n, suma = 0;

        Console.Write("n = ");
        n = int.Parse(Console.ReadLine());

        int[] v = new int[n];

        for (int i = 0; i < n; i++)
        {
            v[i] = int.Parse(Console.ReadLine());
            suma = suma + v[i];
        }

        Console.WriteLine("Suma este: " + suma);
    }
}
