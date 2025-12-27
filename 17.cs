using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        string result = "";
        string digits = "0123456789ABCDEF";

        if (n == 0)
            result = "0";
        else
            while (n > 0)
            {
                result = digits[n % b] + result;
                n /= b;
            }

        Console.WriteLine(result);
    }
}
