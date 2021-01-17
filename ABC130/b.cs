using System;
using System.Collections.Generic;
using System.Linq;

class ABC130B{
    public static void Main(){
        var NX = Console.ReadLine().Split(' ').Select(int.Parse);
        var Ln = Console.ReadLine().Split(' ').Select(int.Parse);
        var count = 1;
        var sum = 0;
        foreach(var l in Ln){
            sum += l;
            if(sum>NX.ElementAt(1)){
                break;
            }
            count++;
        }
        Console.WriteLine(count);
    }
}