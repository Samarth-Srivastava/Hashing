namespace Hashing{
	public class Solution{
		public List<int> TwoSum_GoodPair(List<int> A, int B){
			List<int> lst = new List<int>(){
				int.MaxValue, int.MaxValue
			};
			int N = A.Count();

			Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();
			for (int i = 0; i < N; i++)
			{
				if(dic.ContainsKey(A[i])){
					dic[A[i]][0] += 1;
					dic[A[i]].Add(i);
				}
				else{
					dic[A[i]] = new List<int>() { 1, i};
				}
			}

			for (int i = 0; i < N; i++)
			{
				int index1 = i;
				int k = B-A[i];
				if(dic.ContainsKey(k) && dic[k][0] > 0){
					int index2 = k ==  A[i] && dic[k][0] > 1 ? dic[k][2] : dic[k][1];
					if(index2 < lst[1] && index1 < index2){
						lst[0] = index1;
						lst[1] = index2;
					}
					dic[A[i]][0]--; //kind of removing this, so it will not be counted again
				}
			}

			return lst;
		}
	}
}
