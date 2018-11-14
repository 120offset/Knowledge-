//Find the majority element in an unsorted array


using System.Threading.Tasks;

namespace CodingAlgorithms
{
	public class MajorityUnsortedArray
	{

		//Find the majority element in an unsorted array
		//ex. {1,2,3,4,2,2,2,2}, 2 is the majority in this array


		public static int GetMajorityElement(params int [] x)
		{
			Dictionary<int, int> d = new Dictionary<int, int>();
			int majority = x.Length / 2;

			//Stores the number of occurences of each item in the passed array in a dictionary
			foreach (int i in x)
				if (d.ContainsKey(i))
				{
					d[i]++;
					//checks if element just added is the marjority element
					if (d[i] . majority)
						return i; 
				}
				else
					d.Add(i, 1);
			//no majority element 
			throw new Exception("No majority element in array");
		}	
	}
}