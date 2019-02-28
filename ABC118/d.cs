using System;
using System.Collections.Generic;
using System.Linq;

public class ABC118D
{
	public static void Main()
	{
		var rule = new int[]{2,5,5,4,5,6,3,7,6};
		var split = Console.ReadLine().Split().Select(int.Parse).ToList();
		var n = split[0];
		var m = split[1];
		split = Console.ReadLine().Split().Select(int.Parse).ToList();
		Check(split);
		var rule2 = new Dictionary<int,int>();
		var rule_list = new Dictionary<int,List<int>>();
		foreach(var v in split){
			rule2.Add(rule[v-1],v);
			rule_list.Add(rule[v-1],new List<int>{v});
		}
		var min = rule2.Keys.Min();
		var max = n/min;
		if(min*max == n){
			for(int i = 0;i<max;i++){
				Console.Write(rule2[min]);
			}
			Console.WriteLine();
		}
		else {
			var ans = Enumerable.Repeat(rule2[min], max).ToList();
			n = n % min;
			while(true){
				var next_list = new Dictionary<int,List<int>>();
				foreach(var v in rule_list){
					foreach(var v2 in rule2){
						var tmp = new List<int>(v.Value);
						tmp.Add(v2.Value);
						var n_k = v2.Key+v.Key;
						if(rule_list.Keys.Contains(n_k))continue;
						if(next_list.Keys.Contains(n_k)){
							if(next_list[n_k].Count()<tmp.Count()){
								next_list[n_k]=tmp;
							}else if(next_list[n_k].Count()==tmp.Count()){
								if(next_list[n_k].Max()<tmp.Max()){
									next_list[n_k]=tmp;
								}else{
									if(next_list[n_k].Sum()<tmp.Sum()){
										next_list[n_k]=tmp;
									}
								}
							}
							continue;
						}
						next_list.Add(n_k,tmp);
					}
				}
				foreach(var v in next_list)rule_list.Add(v.Key,v.Value);
				if(rule_list.Keys.Contains(n)){
					ans.AddRange(rule_list[n]);
					PrintAns(ans);
					break;
				}
				ans.RemoveAt(0);
				n = n + min;
			}
		}
	}
	public static void Check(List<int> list){
		if(list.Contains(2)&&list.Contains(3)){
			list.Remove(2);
		}
		if(list.Contains(3)&&list.Contains(5)){
			list.Remove(3);
		}
		if(list.Contains(2)&&list.Contains(5)){
			list.Remove(2);
		}
		if(list.Contains(6)&&list.Contains(9)){
			list.Remove(6);
		}
	}
	public static void PrintAns(List<int> ans){
		ans.Sort((a,b)=>(int)b-(int)a);
		foreach(var v in ans){
			Console.Write(v);
		}
		Console.WriteLine();
	}
}
