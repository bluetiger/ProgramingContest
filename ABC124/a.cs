using System;
using System.Collections.Generic;
using System.Linq;

class ABC124A{
    public static void Main(){
        var ab = Console.ReadLine().Split().Select(int.Parse);
        if(ab.ElementAt(0)+ab.ElementAt(1)>ab.Max()*2-1){
            Console.WriteLine(ab.ElementAt(0)+ab.ElementAt(1));
            return;
        }
        Console.WriteLine(ab.Max()*2-1);
    }
}