using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class ABC121D{
    public static void Main(){
        var AB = Console.ReadLine().Split().Select(int.Parse).ToList();
        var list = new List<char[]>();
        foreach(var n in Enumerable.Range(AB[0],AB[0]-AB[1])){
            string str = Convert.ToString(n, 2).ToCharArray();
        }
        var ans = new char[list.Max(x=>x.Count())];
        foreach(var n in list){
            foreach(var s in Enumerable.Range(0,n.Count())){
                if(n[s] == '1'&&ans[n.Count()-(s+1)] == '0'){
                    ans[n.Count()-(s+1)] = 1;
                }
                else if(n[s] == '0'&&ans[n.Count()-(s+1)] == '1'){
                    ans[n.Count()-(s+1)] = 1;
                }
                else if(n[s] == '1'&&ans[n.Count()-(s+1)] == '1'){
                    ans[n.Count()-(s+1)] = 0;
                }
                else if(n[s] == '0'&&ans[n.Count()-(s+1)] == '0'){
                    ans[n.Count()-(s+1)] = 0;
                }
            }
        }
        foreach(var n in ans)Console.WriteLine(n);
    }
}