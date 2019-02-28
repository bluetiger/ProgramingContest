using System;
using System.Collections.Generic;
using System.Linq;

public class ABC118A
{
	public static void Main()
	{
		var split = Console.ReadLine().Split(' ');
		var a = int.Parse(split[0]);
		var b = int.Parse(split[1]);
		if(b%a==0)Console.WriteLine(a+b); 
		else Console.WriteLine(b-a);
	}
}