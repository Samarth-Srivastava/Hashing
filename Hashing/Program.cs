//driver code
using System;
using System.IO;

namespace Hashing{
	public class Program{
		public static void Main(string[] args){
			Driver d = new Driver();

			d.Options();
		}
	}

	public class Driver{
		Solution s = new Solution();

		public void Options(){

			Console.WriteLine("Sub Array sith sum 0 : Press 1");
			Console.WriteLine("Two Sum : Press 2");

			string? input = Console.ReadLine();
			if(!string.IsNullOrEmpty(input)){
				switch (input)
				{
					case "1": 
						break;
					case "2":
						CallTwoSum();
						break;
					default:
						Console.Clear();
						break;
				}
			}
		}

		public void CallTwoSum(){
			Console.Clear();
			Console.WriteLine("Enter an integer array with spaces in between elements");
			string? line = Console.ReadLine();

			string[] n_arr_str = string.IsNullOrEmpty(line) ? new string[0] : line.Split(", ");

			List<int> A = new List<int>();
			for (int i = 0; i < n_arr_str.Length; i++)
			{
				A.Add(Convert.ToInt32(n_arr_str[i]));
			}

			Console.WriteLine("Enter Sum expected");
			int B = Convert.ToInt32(Console.ReadLine());

			List<int> index = s.TwoSum_GoodPair(A, B);
			for (int i = 0; i < index.Count()-1; i=i+2)
			{
				Console.WriteLine(index[i] + " " + index[i+1]);
			}

		}
	}
}
