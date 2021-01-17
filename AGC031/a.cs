using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class AGC031A{
    public static void Main(){
        var N = int.Parse(Console.ReadLine());
        var Str = Console.ReadLine().ToCharArray().ToList();
        Str.Sort();
        var C = 1000000007;
        var sum = 0.0;
        var sum1 = 1.0;
        var sum2 = 1.0;
        var check = new List<int>();
        var now = Str[0];
        var count = 0;
        for(int index = 1;index<Str.Count();index++){
            if(now != Str[index]){
                now = Str[index];
                if(count != 0)check.Add(count+1);
                count = 0;
            }
            count++;
        }
        foreach (var item in Enumerable.Range(1,N))
        {
            sum1*= N+1-item;
            sum2*= item;
            sum += sum1/sum2;
        }
        Console.WriteLine(sum);
        if(check.Count != 0)sum-=1;
        foreach(var item2 in check){
            sum -= ((item2*item2-1)/2);
            sum -= (N-item2)*(N-2);
        }
        foreach(var item in Enumerable.Range(2,N-2)){
            sum += Comb(check.Count(x=>x>2),item);
        }
        Console.WriteLine(sum);
    }
    static double Comb(int n,int n2){
        return XMax(Enumerable.Range(n-n2,n2))/XMax(Enumerable.Range(1,n2));
    }
    static double XMax(IEnumerable<int> e){
        var s = 1;
        foreach(var x in e)s*=x;
        return s;
    }
}