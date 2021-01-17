using System;
using System.Collections.Generic;
using System.Linq;

class ABC123C{
    public static void Main(){
        var n = double.Parse(Console.ReadLine());
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());
        var c = double.Parse(Console.ReadLine());
        var d = double.Parse(Console.ReadLine());
        var e = double.Parse(Console.ReadLine());
        var list = new double[5];
        list[0] = n/a;
        list[1] = n/b;
        list[2] = n/c;
        list[3] = n/d;
        list[4] = n/e;
        Console.WriteLine(Math.Ceiling(list.Max())+4);
    }
}