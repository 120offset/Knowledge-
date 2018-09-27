using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //shortern version to initialize
            int[] ArrayA = { 0, 2, 4, 6, 8, 10 };
            int[] ArrayB = { 1, 3, 5, 7, 9 };
            int[] ArrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            //initialize array length
            int a = ArrayA.Length;
            int b = ArrayB.Length;
            int c = ArrayC.Length;

            //Introduction
            Console.WriteLine("\nArray A: 0,2,4,6,8,10");
            Console.WriteLine("Array B: 1,3,5,7,9");
            Console.WriteLine("Array C: 3,1,4,1,5,9,2,6,5,3,5,9\n\n");
            

            //the count for each array
            Console.WriteLine($"Here are the counts of each array.\n\nThe count of Array A is {ArrayA.Length}");
            Console.WriteLine($"The count of Array B is {ArrayB.Length}");
            Console.WriteLine($"The count of Array C is {ArrayC.Length}");

            //print the sum of arrays
            Console.WriteLine("\nHere are the sums of each array.\n\nSum of Array A is " + sumA(ArrayA, a));
            Console.WriteLine("Sum of Array B is " + sumB(ArrayB, b));
            Console.WriteLine("Sum of Array C is " + sumC(ArrayC, c));

            //print the mean of arrays
            Console.WriteLine("\nHere are the means of each array.\n\nMean of Array A is " + MeanA(ArrayA, a));
            Console.WriteLine("Mean of Array B is " + MeanB(ArrayB, b));
            Console.WriteLine("Mean of Array C is " + MeanC(ArrayC, c));

            //reverse Arrays 
            rverseArrayA(ArrayA, 0, 5);
            Console.WriteLine("\nEach arrays reversed.\n\nArray A\n");
            printrvers(ArrayA, 6);

            rverseArrayB(ArrayB, 0, 4);
            Console.WriteLine("Array B\n");
            printrvers(ArrayB, 5);

            rverseArrayC(ArrayC, 0, 11);
            Console.WriteLine("Array C\n");
            printrversC(ArrayC, 12);

            //rotate arrays
            Console.WriteLine("\nRotated Arrays");
            Console.WriteLine("Array C rotated two places to the Left\n");
            PrintArray(ArrayRotator(2, true, ArrayA));
            Console.WriteLine("\nArray B rotated two places to the Right\n");
            PrintArray(ArrayRotator(2, false, ArrayB));
            Console.WriteLine("\nArray C rotated four places to the Left\n");
            PrintArray(ArrayRotator(4, true, ArrayC));
            Console.WriteLine();

            //sorted arrays
            Console.WriteLine("\nArray C is sorted\n");
            PrintArray(SortArr(ArrayC));
            
        }
        //method for sum of arrays
        static int sumA(int[] ArrayA, int a)
        {
            int sum = 0;
            //iterate through all elements and add to sum
            for (int i = 0; i < a; i++)
                sum += ArrayA[i];
            return sum;
        }
        static int sumB(int[] ArrayB, int b)
        {
            int sum = 0;
            for (int i = 0; i < b; i++)
                sum += ArrayB[i];
            return sum;
        }
        static int sumC(int[] ArrayC, int c)
        {
            int sum = 0;
            for (int i = 0; i < c; i++)
                sum += ArrayC[i];
            return sum;
        }

        //MEAN OF ARRAYS 

        static double MeanA(int[] ArrayA, int a)
        {
            double sum = 0, mean = 0;
            for (int i = 0; i < a; i++)
            {
                sum += ArrayA[i];
            }
            mean = sum / a;
            return mean;
        }
        static double MeanB(int[] ArrayB, int b)
        {
            double sum = 0, mean = 0;
            for (int i = 0; i < b; i++)
            {
                sum += ArrayB[i];
            }
            mean = sum / b;
            return mean;
        }
        static double MeanC(int[] ArrayC, int c)
        {
            double sum = 0, mean = 0;
            for (int i = 0; i < c; i++)
            {
                sum += ArrayC[i];
            }
            mean = sum / c;
            return mean;
        }

        //REVERSE ARRAY
        static void rverseArrayA(int[] ArrayA, int start, int end)
        {
            int temp;
            while (start < end)
            {
                temp = ArrayA[start];
                ArrayA[start] = ArrayA[end];
                ArrayA[end] = temp;
                start++;
                end--;
            }
        }
        static void printrvers(int[] ArrayA, int size)
        {
            string values = "";

            for (int i = 0; i < size; i++)
            {
                values +=  ArrayA[i] + " ";
            }
                Console.WriteLine(values);
            Console.WriteLine();
        }
        static void rverseArrayB(int[] ArrayB, int start, int end)
        {
            int temp;
            while (start < end)
            {
                temp = ArrayB[start];
                ArrayB[start] = ArrayB[end];
                ArrayB[end] = temp;
                start++;
                end--;
            }
        }
        static void printrversB(int[] ArrayB, int size)
        {
            for (int i = 0; i < size; i++)
                Console.WriteLine(ArrayB[i] + "");
            Console.WriteLine();
        }
        static void rverseArrayC(int[] ArrayC, int start, int end)
        {
            int temp;
            while (start < end)
            {
                temp = ArrayC[start];
                ArrayC[start] = ArrayC[end];
                ArrayC[end] = temp;
                start++;
                end--;
            }
        }
        static void printrversC(int[] ArrayC, int size)
        {
            string values = "";
            for (int i = 0; i < size; i++)
            {
                values += ArrayC[i] + " ";
            }
                Console.WriteLine(values);
            Console.WriteLine();
        }

        //PRINTED ARRAY METHOD FOR ROTATE AND SORT
        static void PrintArray(int[] array)
        {
            
            foreach (int item in array)
            {
                Console.WriteLine(item + " ");
            }
        }

        //ROTATING ARRAY
        static int [] ArrayRotator(int cycles, bool direction, int[] choiceArray)
        {
            int[] ArrayRotator = new int[choiceArray.Length];

            //True rotate right
            //False rotate left

            if (direction == true)
            {
                int ii = 0;
                for (int i = 0; i < choiceArray.Length; i++)
                {
                    if (choiceArray.Length - ii - cycles == choiceArray.Length)
                    {
                        ii = choiceArray.Length - cycles;
                    }
                    ArrayRotator[i] = choiceArray[choiceArray.Length - ii - cycles];

                    ii--;
                }
            }
            else if (direction == false)
            {
                int ii = 0;
                for (int i = 0; i < choiceArray.Length; i++)
                {
                    if (ii + cycles == choiceArray.Length)
                    {
                        ii = 0 - cycles;
                    }
                    ArrayRotator[i] = choiceArray[ii + cycles];

                    ii++;
                }
            }
            return ArrayRotator;
        } 

        //SORTING ARRAYS
        static int[] SortArr(int[] sortArray)
        {
            int num = 0;

            for (int i = 0; i < sortArray.Length - 1; i++)
            {
                for (int sort = 0; sort < sortArray.Length - 1 - i; sort++)
                {
                    if (sortArray[sort] > sortArray[sort + 1])
                    {
                        num = sortArray[sort];
                        sortArray[sort] = sortArray[sort + 1];
                        sortArray[sort + 1] = num;
                    }
                }
            
            }
            return sortArray;
        }

    }
}
