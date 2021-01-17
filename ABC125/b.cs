using System;
using System.Collections.Generic;
using System.Linq;

class ABC125B{
    public static void Main(){
        var N = int.Parse(Console.ReadLine());
        var V = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var C = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var ans = 0;
        for(int index = 0;index < V.Count();index++){
            ans += V[index]>C[index]?V[index]-C[index]:0;
        }
        Console.WriteLine(ans);
    }
}