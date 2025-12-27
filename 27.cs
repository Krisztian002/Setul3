using System;

class Program
{
    static void Main()
    {
        string[] parti = Console.ReadLine().Split(' ');
        int[] vector = new int[parti.Length];

        for (int j = 0; j < parti.Length; j++)
            vector[j] = int.Parse(parti[j]);

        int index = int.Parse(Console.ReadLine());

        Array.Sort(vector);

        Console.WriteLine(vector[index]);
    }
}
