using System;
using System.Collections.Generic;
using System.Linq;
					
public class Program
{
	public static void Main()
	{
		var split = Console.ReadLine().Split(' ');
		var n = int.Parse(split[0]);
		var m = int.Parse(split[1]);
		var list = new int[m];
		for(int i = 0;i<n;i++){
			foreach(var a in Console.ReadLine().Split(' ').Skip(1)){
				var a_i = int.Parse(a);
				list[a_i-1]++;
			}
		}
		var count = 0;
		foreach(var a in list){
			if(a==n)count++;
		}
		Console.WriteLine(count);
	}
}