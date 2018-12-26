using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{

    //Counting Valleys Program that takes number of steps and 
    //a string stating direction up and down
    //returns the number of valleys traversed
    class Program
    {

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int result = countingValleys(n, s);

            Console.WriteLine(result);

            
        }

        static int countingValleys(int n, string s)
        {
            var seaLevel = 0;
            var valleyCount = 0;
            var numberOfsteps = n;
            var stepRecord = s;

            var valleyActive = false;

            for (int i = 0; i < numberOfsteps; i++)
            {
                if (stepRecord[i] == 'U')
                {
                    seaLevel++;
                }
                else
                {
                    seaLevel--;
                }

                if (!valleyActive && seaLevel < 0)
                {
                    valleyActive = true;
                }

                if (valleyActive && seaLevel == 0)
                {
                    valleyCount++;
                    valleyActive = false;
                }
            }

            return valleyCount;
        }
    }
}
