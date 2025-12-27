using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double[] c = new double[n + 1];
        for (int i = 0; i <= n; i++)
            c[i] = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());

        double r = 0;
        for (int i = 0; i <= n; i++)
            r += c[i] * Math.Pow(x, i);

        Console.WriteLine(r);
    }
}
