using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATHApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter which type of mathematical action you would like use:\n");
            Console.WriteLine("+ for addition\n- for subtraction\n* for multiplication\n/ for division");
            Console.WriteLine("If you would simply like to exit the program then press q");
            try
            {
                string option = Console.ReadLine();

                switch (option)
                {
                    case "+":
                        Console.WriteLine("\nYou want to add, ok, enter two numbers\n");
                        double add1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\n...now the second number\n");
                        double add2 = Convert.ToDouble(Console.ReadLine());
                        Addition(add1, add2);
                        break;
                    case "-":
                        Console.WriteLine("\nYou want to subtract, ok, enter two numbers\n");
                        double sub1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\n...now the second number\n");
                        double sub2 = Convert.ToDouble(Console.ReadLine());
                        Subtraction(sub1, sub2);
                        break;
                    case "*":
                        Console.WriteLine("\nYou want to multiply, ok, enter two numbers\n");
                        double mlt1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\n...now the second number\n");
                        double mlt2 = Convert.ToDouble(Console.ReadLine());
                        Multiply(mlt1, mlt2);
                        break;
                    case "/":
                        Console.WriteLine("\nYou want to divide, ok, enter two numbers\n");
                        double div1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\n...now the second number\n");
                        double div2 = Convert.ToDouble(Console.ReadLine());
                        DivideByZero(div2);
                        Division(div1, div2);
                        break;
                    case "q":
                        Console.WriteLine("\nThanks for stopping by!");
                        Environment.Exit(0);
                        break;
                        //default:
                        //    Environment.Exit(0);
                        //    break;
                }
            }
            catch (DivideByZeroException DBZE)
            {
                Console.WriteLine(DBZE.Message);
            }
            finally
            {
                Console.WriteLine("\nThanks for stopping by!");
                Environment.Exit(0);
            }
        }
        static void Addition(double add1, double add2)
        {
            double sum = add1 + add2;
            Console.WriteLine($"\n{add1} + {add2} = {sum}");
        }
        static void Subtraction(double sub1, double sub2)
        {
            double sum = sub1 - sub2;
            Console.WriteLine($"\n{sub1} - {sub2} = {sum}");
        }
        static void Multiply(double mlt1, double mlt2)
        {
            double sum = mlt1 * mlt2;
            Console.WriteLine($"\n{mlt1} * {mlt2} = {sum}");
        }
        static void Division(double div1, double div2)
        {
            double sum = div1 / div2;
            Console.WriteLine($"\n{div1} / {div2} = {sum}");
        }
        static double DivideByZero(double div2)
        {
            if (div2 == 0)
                Console.WriteLine("\nPlease use another number other than zero");
            return div2;
        }
    }
}
