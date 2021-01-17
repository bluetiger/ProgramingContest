using System;
using System.Collections.Generic;
using System.Linq;

class ABC130D2{
    public static void Main(){
        var NK = Console.ReadLine().Split(' ');
        var N = int.Parse(NK[0]);
        var K = double.Parse(NK[1]);
        var An = Console.ReadLine().Split(' ').Select(double.Parse);
        var count = 0.0;
        for(int ind = 0;ind<N;ind++){
            double i = 0;
            for(i = N-ind;i>0-ind;i--){
                if(An.Skip(ind).Take((int)i).Sum()>=K){
                    count += Check(An,ind,N,K);
                }else{
                    break;
                }
            }
        }
        Console.WriteLine(count);
    }
    public static int Check(IEnumerable<double> A,int index,int size,double K){
        var count = 0;
        if(A.Skip(index).Take(size/2).Sum()>=K){
            count += size/2;
            count += Check(A,index,size/2,K);
        }else{
            count+=One(A,index,size/2,size,K);    
        }

        Console.WriteLine(count);
        return count;
    }
    public static int One(IEnumerable<double> A,int index,int start,int last,double K)
    {
        for(start = start;start<last;start++){
            if(A.Skip(index).Take(start).Sum()>=K){
                Console.WriteLine(last-start);
                return last-start;
            }
        }
        return 1;
    }
}
