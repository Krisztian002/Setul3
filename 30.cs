using System;

namespace S3EX30
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] E = new int[n];
            int[] W = new int[n];

            for (int i = 0; i < n; i++)
                E[i] = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
                W[i] = int.Parse(Console.ReadLine());

            BicriteriaSort(E, W);

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{E[i]} {W[i]}");
        }

        static void BicriteriaSort(int[] E, int[] W)
        {
            int n = E.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (E[j] > E[j + 1] || (E[j] == E[j + 1] && W[j] < W[j + 1]))
                    {
                        int tempE = E[j];
                        int tempW = W[j];

                        E[j] = E[j + 1];
                        W[j] = W[j + 1];

                        E[j + 1] = tempE;
                        W[j + 1] = tempW;
                    }
                }
            }
        }
    }
}
