using System;
using System.Collections.Generic;
using System.Linq;

class ABC124C{
    public static void Main(){
        var Sin = Console.ReadLine();
        var S = new List<bool>();
        foreach(var s in Sin.ToCharArray()){
            S.Add(s=='1');
        }
        var r1 = new List<bool>();
        var r2 = new List<bool>();
        for(int i = 0;i<Sin.Length;i++){
            r1.Add((i%2==0) ^ S[i]);
            r2.Add((i%2==1) ^ S[i]);
        }
        Console.WriteLine(r1.FindAll(x=>x).Count<r2.FindAll(x=>x).Count?r1.FindAll(x=>x).Count:r2.FindAll(x=>x).Count);
    }
}