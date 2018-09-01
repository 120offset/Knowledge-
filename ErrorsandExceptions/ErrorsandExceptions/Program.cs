using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorsandExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[a] enter this option if you would like to work with circles.");
            Console.WriteLine("[b] enter this option if you woule like to work with triangles.");
            Console.WriteLine("[c] enter this option if you woule like to work with hemispheres.");
            Console.WriteLine("[d] enter this option if you woule like to work with the quadratic formula.");
            Console.WriteLine("[q] enter this option if you would like to end the project.");
            try
            {
                string option = Console.ReadLine();

                switch (option)
                {

                    case "a":
                        Console.WriteLine("\nLet's find both the circumference and area of a circle");
                        Console.WriteLine("\nOk,\nWhat is the radius of your circle?\n");
                        double r = Convert.ToDouble(Console.ReadLine());

                        CircleAreaCircumference(r);
                        Console.ReadLine();

                        break;
                    case "b":
                        Console.WriteLine("\nLet's find the area of a triangle");
                        Console.WriteLine("You're going to have to provide the length of 3 sides");

                        Console.Write("\nPlease enter side 1 then enter\n");
                        int side1;
                        side1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nPlease enter side 2 then enter\n");
                        int side2;
                        side2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nPlease enter side 3 then enter\n");
                        int side3;
                        side3 = Convert.ToInt32(Console.ReadLine());

                        AreaTriangle(side1, side2, side3);
                        Console.ReadLine();

                        break;
                    case "c":
                        Console.WriteLine("\nLet's calculate the volume of a hemisphere of any sphere you want");
                        Console.WriteLine("\nEnter a radius, please\n");
                        double r1;
                        r1 = Convert.ToDouble(Console.ReadLine());

                        HemisphereVolume(r1);
                        Console.ReadLine();
                        break;
                    case "d":
                        double a, b, c;

                        Console.WriteLine("\nThis program will solve the quadratic formula for you");
                        Console.WriteLine("First you will need to give three variables");

                        Console.WriteLine("\nPlease enter the value for a:");
                        a = double.Parse(Console.ReadLine());

                        Console.WriteLine("\nPlease enter the value for b:");
                        b = double.Parse(Console.ReadLine());

                        Console.WriteLine("\nPlease enter the value for c:");
                        c = double.Parse(Console.ReadLine());

                        QuadFormula(a, b, c);
                        Console.ReadLine();
                        break;
                    case "q":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Have a nice day :)");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                }
            }
            catch (FormatException fEx)
            {
                Console.WriteLine(fEx.Message);
            }
            catch (DivideByZeroException DBZE)
            {
                Console.WriteLine(DBZE.Message);
            }
            catch (OverflowException OvFlow)
            {
                Console.WriteLine(OvFlow.Message);
            }
            catch (Exception Excp)
            {
                Console.WriteLine(Excp.Message);
            }
            finally
            {
                Console.WriteLine("This program has finally terminated.");
            }
        }
        static void CircleAreaCircumference(double r)
        {
            double c = 2 * Math.PI * r;
            c = Math.Round(c, 2);
            Console.WriteLine($"\nThe circumference is {c}");

            // This will display the area
            double a = Math.PI * (r * r);
            a = Math.Round(a, 2);
            Console.WriteLine($"\nThe area is {a}\n");


        }
        static void AreaTriangle(int side1, int side2, int side3)
        {
            double s;
            s = (side1 + side2 + side3) / 2;
            double a;
            a = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
            Console.WriteLine($"\nThe area of the Triangle is {a}");
            Console.ReadLine();
        }
        static void HemisphereVolume(double r1)
        {
            double v = (2.0 / 3) * Math.PI * r1 * r1 * r1;
            v = Math.Round(v, 2);
            Console.WriteLine($"\nThe volume of a hemisphere is {v}");
        }
        static void QuadFormula(double a, double b, double c)
        {
            double inside = (b * b) - 4 * a * c;

            // The equation involves a +- so there will be two solutions 
            double root1;
            root1 = (-b + (Math.Sqrt(inside) / (2 * a)));

            double root2;
            root2 = (-b - (Math.Sqrt(inside) / (2 * a)));

            // This part will convert the two root results to strings
            string r1 = Convert.ToString(root1);
            string r2 = Convert.ToString(root2);

            // This part will show the answer

            Console.WriteLine($"Root 1 ={r1} and Root 2 = {r2}");
        }
        //static void LessthanZero(double one, string two)
        //{
    
        //}

        

    }
}
