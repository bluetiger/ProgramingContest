using System;
using System.Collections.Generic;
using System.Linq;

class ABC119C{
    public static void Main(){
        var NABC = Console.ReadLine().Split().Select(int.Parse);
        var take = new List<int>();
        foreach(var n in Enumerable.Range(0,NABC[0])){
            take.Add(int.Parse(Console.ReadLine()));
        }
        take.Add(NABC[1]);
        take.Add(NABC[2]);
        take.Add(NABC[3]);
        take.Sort();
    }
    public static int NearCheck(List<int> list,int a,int b,int c){
        int a_index = list.FindIndex(x=>x==a);
        int b_index = list.FindIndex(x=>x==b);
        int c_index = list.FindIndex(x=>x==c);
        var a_near = b_near = c_near = 0;
        if(a_index == 0)a_near = 1;
        else if(a_index == list.Length-1)a_near = a_index-1;
        else a_near = Math.Abs(a-list[a_index-1])-Math.Abs(a-list[a_index+1])<0?a_index-1:a_index+1;
        if(b_index == 0)a_near = 1;
        else if(b_index == list.Length-1)b_near = b_index-1;
        else b_near = Math.Abs(b-list[b_index-1])-Math.Abs(b-list[b_index+1])<0?b_index-1:b_index+1;
        if(c_index == 0)a_near = 1;
        else if(c_index == list.Length-1)c_near = c_index-1;
        else c_near = Math.Abs(c-list[c_index-1])-Math.Abs(c-list[c_index+1])<0?c_index-1:c_index+1;
        
    }
}