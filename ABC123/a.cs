using System;
using System.Collections.Generic;
using System.Linq;

class ABC123A{
    public static void Main(){
        var a = int.Parse(Console.ReadLine());
        Console.ReadLine();
        Console.ReadLine();
        Console.ReadLine();
        var e = int.Parse(Console.ReadLine());
        var k = int.Parse(Console.ReadLine());
        if(e-a > k)Console.WriteLine(":(");
        else Console.WriteLine("Yay!");   
    }
}