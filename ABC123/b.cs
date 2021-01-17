using System;
using System.Collections.Generic;
using System.Linq;

class ABC123B{
    public static void Main(){
        var ae = new List<int>();
        ae.Add(int.Parse(Console.ReadLine()));
        ae.Add(int.Parse(Console.ReadLine()));
        ae.Add(int.Parse(Console.ReadLine()));
        ae.Add(int.Parse(Console.ReadLine()));
        ae.Add(int.Parse(Console.ReadLine()));
        var ae2 = new List<int>();
        ae.ForEach(x=>ae2.Add(10-x%10));
        ae2.RemoveAll(x=>x==10);
        if(ae2.Count != 0)ae2.Remove(ae2.Max());
        Console.WriteLine(ae.Sum()+ae2.Sum());
    }
}