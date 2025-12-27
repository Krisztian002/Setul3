using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var v1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var v2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var set1 = new HashSet<int>(v1);
        var set2 = new HashSet<int>(v2);

        Console.WriteLine(string.Join(" ", set1.Intersect(set2)));
        Console.WriteLine(string.Join(" ", set1.Union(set2)));
        Console.WriteLine(string.Join(" ", set1.Except(set2)));
        Console.WriteLine(string.Join(" ", set2.Except(set1)));
    }
}
