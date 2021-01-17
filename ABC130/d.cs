using System;
using System.Collections.Generic;
using System.Linq;

class ABC130D{
    public static void Main(){
        var NK = Console.ReadLine().Split(' ').Select(double.Parse);
        var An = Console.ReadLine().Split(' ').Select(double.Parse);
        var count = 0.0;
        for(int ind = 0;ind<NK.ElementAt(0);ind++){
            var tmp = 0.0;
            int i = 0;
            for(i = ind;i<NK.ElementAt(0);i++){
                tmp += An.ElementAt(i);
                if(tmp>=NK.ElementAt(1)){
                    count += NK.ElementAt(0)-i;
                    break;
                }
            }
            if(NK.ElementAt(0) == i)break;
        }
        Console.WriteLine(count);
    }
}