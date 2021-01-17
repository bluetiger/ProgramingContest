using System;
using System.Collections.Generic;
using System.Linq;

class ABC124D{
    public static void Main(){
        var NK = Console.ReadLine().Split().Select(int.Parse);
        var Sin = Console.ReadLine().ToCharArray();
        var Si = new List<int>();
        var Sb = new List<bool>();
        var count = 0;
        var bef = Sin[0] == '1';
        var t = true;
        for(var index = 0;index<Sin.Length;index++){
            t = Sin[index]=='1';
            if(bef == t){
                count++;
            }else{
                Si.Add(count);
                Sb.Add(bef);
                bef=t;
                count = 1;
            }
        }
        Si.Add(count);
        Sb.Add(t);
        var max = 0;
        var sum = 0;
        if(NK.ElementAt(1)*2>Si.Count){
            Console.WriteLine(Si.Sum());
            return;
        }
        for(var index = 0;index+NK.ElementAt(1)*2<Si.Count;index++){
            var take = NK.ElementAt(1)*2+(Sb[index]?1:0);
            sum = Si.Skip(index).Take(take).Sum();
            if(max<sum)max = sum;
        }
        Console.WriteLine(max);
    }
}