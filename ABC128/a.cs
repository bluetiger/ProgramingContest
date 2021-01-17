using System;
using System.Collections.Generic;
using System.Linq;

class ABC128A{
    public static void Main(){
        var ap = Console.ReadLine().Split(' ').Select(int.Parse);
        Console.WriteLine((ap.ElementAt(0)*3+ap.ElementAt(1))/2);
    }
}