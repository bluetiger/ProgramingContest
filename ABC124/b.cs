using System;
using System.Collections.Generic;
using System.Linq;

class ABC124B{
    public static void Main(){
        var N = int.Parse(Console.ReadLine());
        var Hs = Console.ReadLine().Split().Select(int.Parse);
        var max = 0;
        var count = 0;
        foreach(var H in Hs){
            if(H>=max){
                count++;
                max = H;
            }
        }
        Console.WriteLine(count);
    }
}