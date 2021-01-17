using System;
using System.Collections.Generic;
using System.Linq;

class ABC125C{
    public static void Main(){
        var N = int.Parse(Console.ReadLine());
        var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var S = new int[N-1];
        var R = new int[N-1];
        S[0] = A[0];
        R[0] = A.Last();
        for(int i = 1;i < N-1;i++){
            S[i] = GCD(S[i-1],A[i]);
            R[i] = GCD(R[i-1],A[N-(i+1)]);
        }
        var list = new List<int>();
        for(int i = 0;i < N-2;i++){
            list.Add(GCD(S[i],R[N-(i+3)]));
        }
        list.Add(GCD(S.Last(),A[N-2]));
        list.Add(GCD(R.Last(),A[1]));
        Console.WriteLine(list.Max());
    }
    public static int GCD(int a,int b){
        if(b == 0){
            Console.WriteLine(a);
            return a;
        }
        return GCD(b,a%b);
    }
}