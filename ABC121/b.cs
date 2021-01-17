using System;
using System.Collections;
using System.Linq;

class ABC121B{
    public static void Main(){
        var NMC = Console.ReadLine().Split().Select(int.Parse).ToList();
        var B = Console.ReadLine().Split().Select(int.Parse).ToList();
        var count = 0;
        while(As.Count() != NMC[0]){
            var a = Console.ReadLine().Split().Select(int.Parse).ToList();
            var sum = NMC[2];
            foreach(var n in Enumerable.Range(0,NMC[1])){
                sum += B[n]*a[n];
            }
            if(sum>0)count++;
        }
        Console.WriteLine(count);
    }
}