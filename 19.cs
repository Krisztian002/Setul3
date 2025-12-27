using System;

class Program
{
    static void Main()
    {
        int[] s = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] p = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int count = 0;
        for (int i = 0; i <= s.Length - p.Length; i++)
        {
            bool ok = true;
            for (int j = 0; j < p.Length; j++)
                if (s[i + j] != p[j]) { ok = false; break; }
            if (ok) count++;
        }
        Console.WriteLine(count);
    }
}
