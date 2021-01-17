using System;
using System.Collections.Generic;
using System.Linq;

class ABC128B{
    public static void Main(){
        var N = int.Parse(Console.ReadLine());
        var SP = new Dictionary<int,Com>();
        for(int i = 0;i < N;i++){
            var tmp = Console.ReadLine().Split(' ');
            SP.Add(tmp[0],int.Parse(tmp[1]));
        }
        
    }
    public int CompareTo(ValueTuple<string, int> a, ValueTuple<string, int> b)
    {
        int c = Comparer<string>.Default.Compare(a.Item1,b.Item1);
        if (c != 0) return c;

        c = Comparer<int>.Default.Compare(a.Item2,b.Item2);
        return c;
    }
}

class Com:IComparer<(string,int)>{
    public int Compare(ValueTuple<string, int> a, ValueTuple<string, int> b)
    {
        int c = Comparer<string>.Default.Compare(a.Item1,b.Item1);
        if (c != 0) return c;

        c = Comparer<int>.Default.Compare(a.Item2,b.Item2);
        return c;
    }
}