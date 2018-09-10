using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeClass
{
    public class Coffee
    {
        double CoffeeSales { get; set; }

        //menu items
        const double csmprice = 1;
        const double cmdprice = 3;
        const double clgprice = 5;
        const double csmcost = .10;
        const double cmdcost = .15;
        const double clgcost = .20;
        const double eggprice = 5.50;
        const double chxprice = 7.50;
        const double eggcost = .95;
        const double chxcost = 1.20;
        
        public void GetSales()
        {
            

            try
            {
                Console.WriteLine("How many Small Coffees were sold?");
                double small = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("How many Medium Coffees were sold?");
                double medium = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("How many Large Coffees were sold?");
                double large = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("How many Egg Sandwiches were sold?");
                double egg = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("How many Chicken Biscuits were sold?");
                double chx = Convert.ToDouble(Console.ReadLine());
                
                //constant menu price w daily items
                double TotalCost = (small * csmcost) + (medium * cmdcost) + (large * clgcost) + (egg * eggcost) + (chx * chxcost);
                double TotalSales = (small * csmprice) + (medium * cmdprice) + (large * clgprice) + (egg * eggcost) + (chx * chxprice);
                double TotalProfit = TotalSales - TotalCost;

                Console.WriteLine($"Total Sales for the day: {TotalSales:c}\nTotal Cost for the day: {TotalCost:c}\nTotal Profit for the day: {TotalProfit:c}");
            }
            catch (Exception ex)
            {
                if (ex is Exception)
                {
                    Console.WriteLine("Please enter a number");
                }
                else
                {
                    throw;
                }
            }

        }
    }
    public enum Option { Sales = 1, PayRoll, Exit }
}

