
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace factorial
{
    class Program
    {
		//Calulate factorial in C#

		//Factorial of a number is obtained from the result of multipyling a series of descending 
		//natural numbers 

		//Using For Loop

		static void Main(string[] args)
		{
			int i, number, fact;
			Console.WriteLine("Enter the number");
			number = int.Parse(Console.ReadLine());
			fact = number;
	
			//For loop to multiply a series of descending natural numbers
			for(i = number - 1; i >= 1; i--)
			{
				fact = fact * i;
			}
			Console.WriteLine("\nFactorial of Given Number is:" + fact);
			Console.ReadLine();
		}
	}
}

//Another method using Recursion

Public double factorial_Recursion(int number)
{
	if (number == 1)
		return 1;
	else
		return number * factorial_recursion(number - 1);
}

//Using While Loop for factorial

public doble factorial_WhileLoop(int number)
{
	double result = 1;
	while (number != 1)
	{
		result = result * number;
		number = number - 1;
	}
}

