using System;
using System.Linq;

class ABC119A{
    public static void Main(){
        var t = int.Parse(new String(Console.ReadLine().Where(x=>x!='/').ToArray()));
        if(t<=20190430){
            Console.WriteLine("Heisei");
        }else{
            Console.WriteLine("TBD");
        }
    }
}