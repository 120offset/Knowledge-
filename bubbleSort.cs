using System;

class BubbleSort
{
    //optimized version of Bubble Sort
    static void BubbleSort(int[] arr, int n)
    {
        int i, j, temp;
        bool swapped;

        for (i = 0; i < n -1; i++)
        {
            swapped = false;
            for (j = 0; j < n - i - 1; j++)
            {
                if(arr[j] > arr[j + 1])
                {
                    //swap arr[j] with arr[j+1]
                    temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }

            //If no two consecutive elements were
            //swapped then break loop
            if(swapped == false)
                break;
        }
    }

    //Function to print the array
    static void PrintArray(int[] arr, int size)
    {
        int i;
        for (i = 0; i < size; i++)
            Console.Write(arr[i] + " ");
            Console.WriteLine();
    }   

    //Main Function
    public static void Main()
    {
        int[] arr = { 12, 3, 49, 34, 56, 73, 5};
        int n = arr.Length;
        BubbleSort(arr, n);
        Console.WriteLine("Sorted Array");
        PrintArray(arr, n);
    }
}