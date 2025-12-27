using System;

class Program
{
    static void Main()
    {
        string a = Console.ReadLine().ToUpper();
        string b = Console.ReadLine().ToUpper();
        int n = a.Length;
        int count = 0;

        for (int k = 0; k < n; k++)
        {
            bool match = true;
            for (int i = 0; i < n; i++)
            {
                if (a[i] != b[i])
                {
                    match = false;
                    break;
                }
            }
            if (match) count++;

             b = b[n - 1] + b.Remove(n - 1);
        }

        Console.WriteLine(count);
    }
}
