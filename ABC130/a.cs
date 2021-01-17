using System;
using System.Collections.Generic;
using System.Linq;

class ABC130A{
    public static void Main(){
        var xa = Console.ReadLine().Split(' ').Select(int.Parse);
        Console.WriteLine(xa.ElementAt(0)<xa.ElementAt(1)?"0":"10");
    }
}