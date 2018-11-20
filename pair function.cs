//Pair function 
static int sockMerchant(int n, int[] ar)
{
	//sort the array of int[] ar
	Array.Sort(ar);
	//initial value of total pairs
	int pairs = 0;

	//For loop to that is sorted
	for(int i =0; i <n-1; i++)
	{
		//nested if statement for iteration to find
		//total number of pairs
		if (ar[i] == ar [i+1])
		{
			++pairs;
			++i;
		}
	}
	return pairs;
}