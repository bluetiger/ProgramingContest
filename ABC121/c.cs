using System;
using System.Collections.Generic;
using System.Linq;

class ABC121C{
    public static void Main(){
        var AB = Console.ReadLine().Split().Select(Int64.Parse).ToList();
        var list = new List<bool[]>();
        for(var n = AB[0];n<AB[1]-AB[0]+1;n+=1){
            list.Add(Convert.ToString(n, 2).ToCharArray().Select(x=>x=='1').ToArray());
        }
        var ans = new int[list.Max(x=>x.Count())];
        foreach(var n in list){
            foreach(var s in Enumerable.Range(0,n.Count())){
            ans[n.Count()-(s+1)] += n[s]?1:0;
            }
        }
        var ans_s = "";
        foreach(var n in ans){
            ans_s += n%2 == 0?"0":"1";
        }
        Console.WriteLine(Convert.ToInt64(ans_s, 2));
    }
}