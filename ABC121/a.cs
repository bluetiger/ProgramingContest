using System;
using System.Linq;

class ABC121A{
    public static void Main(){
        var HW = Console.ReadLine().Split().Select(int.Parse).ToList();
        var hw = Console.ReadLine().Split().Select(int.Parse).ToList();
        Console.WriteLine(HW[0]*HW[1]-(hw[0]*HW[1]+(HW[0]-hw[0])*hw[1]));
    }
}