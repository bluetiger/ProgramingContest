using System;
using System.Collections.Generic;
using System.Linq;

class ABC125A{
    public static void Main(){
        var ABT = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(ABT[1]*(ABT[2]/ABT[0]));
    }
}