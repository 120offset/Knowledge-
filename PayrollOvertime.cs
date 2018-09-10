using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CoffeeClass 
{
    public struct PayrollOvertime
    {
        //named constants 
        const double baseHours = 40;
        const double overtime = 1.5;

        //local variables 
        double hoursWorked;
        double hourlyPayRate;
        double overtimeHours;
        double basePay;
        double overtimePay1;
        double overtimePay2;
        double overtimePay3;
        double overtimePay4;
        double overtimePay5;
        double grossPay1;
        double grossPay2;
        double grossPay3;
        double grossPay4;
        double grossPay5;
      

        public double EmployeePay1()
        {
            Console.WriteLine("\nHow many hours did the Employee 1 work this week?");
            double hours = Convert.ToDouble(Console.ReadLine());
            try
            {
                //get the hours worked and hourly pay rate 
                hoursWorked = hours;
                hourlyPayRate = 12.5;

                //determine the gross pay 
                if (hoursWorked > baseHours)
                {
                    //calculate the base pay (without overtime) 
                    basePay = hourlyPayRate * baseHours;

                    //calculate the number of overtime hours 
                    overtimeHours = hoursWorked - baseHours;

                    //calculate the overtime pay 
                    overtimePay1 = overtimeHours * hourlyPayRate * overtime;

                    //calculate the gross pay 
                    grossPay1 = basePay + overtimePay1;
                }
                else
                {
                    //calculate the gross pay
                    grossPay1 = hoursWorked * hourlyPayRate;
                }
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
            return this.grossPay1 + this.overtimePay1;
        }
        public double EmployeePay2()
        {
            Console.WriteLine("How many hours did the Employee 2 work this week?");
            double hours = Convert.ToDouble(Console.ReadLine());
            try
            {
                hoursWorked = hours;
                hourlyPayRate = 12.5;
                if (hoursWorked > baseHours)
                {
                    basePay = hourlyPayRate * baseHours;
                    overtimeHours = hoursWorked - baseHours;
                    overtimePay2 = overtimeHours * hourlyPayRate * overtime;
                    grossPay2 = basePay + overtimePay2;
                }
                else
                {
                    grossPay2 = hoursWorked * hourlyPayRate;
                }
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
            return this.grossPay2 + this.overtimePay2;
        }
        public double EmployeePay3()
        {
            Console.WriteLine("How many hours did the Employee 3 work this week?");
            double hours = Convert.ToDouble(Console.ReadLine());
            try
            {
                hoursWorked = hours;
                hourlyPayRate = 12.5;
                if (hoursWorked > baseHours)
                {
                    basePay = hourlyPayRate * baseHours;
                    overtimeHours = hoursWorked - baseHours;
                    overtimePay3 = overtimeHours * hourlyPayRate * overtime;
                    grossPay3 = basePay + overtimePay3;
                }
                else
                {
                    grossPay3 = hoursWorked * hourlyPayRate;
                }
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
            return this.grossPay3 + this.overtimePay3;
        }
        public double EmployeePay4()
        {
            Console.WriteLine("How many hours did the Employee 4 work this week?");
            double hours = Convert.ToDouble(Console.ReadLine());
            try
            {
                hoursWorked = hours;
                hourlyPayRate = 12.5;
                if (hoursWorked > baseHours)
                {
                    basePay = hourlyPayRate * baseHours;
                    overtimeHours = hoursWorked - baseHours;
                    overtimePay4 = overtimeHours * hourlyPayRate * overtime;
                    grossPay4 = basePay + overtimePay4;
                }
                else
                {
                    grossPay4 = hoursWorked * hourlyPayRate;
                }
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
            return this.grossPay4 + this.overtimePay4;
        }
        public double EmployeePay5()
        {
            Console.WriteLine("How many hours did the Employee 5 work this week?");
            double hours = Convert.ToDouble(Console.ReadLine());
            try
            {
                hoursWorked = hours;
                hourlyPayRate = 12.5;
                if (hoursWorked > baseHours)
                {
                    basePay = hourlyPayRate * baseHours;
                    overtimeHours = hoursWorked - baseHours;
                    overtimePay5 = overtimeHours * hourlyPayRate * overtime;
                    grossPay5 = basePay + overtimePay5;
                }
                else
                {
                    grossPay5 = hoursWorked * hourlyPayRate;
                }
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
            return this.grossPay5 + this.overtimePay5;
        }


        public double PayRoll()
        {
            //calculate payroll
            double PayRoll = grossPay1 + grossPay2 + grossPay3 + grossPay4 + grossPay5;
            Console.WriteLine($"The week's Payroll is {PayRoll:c}");
            return PayRoll;
        }
        public double TotalOvertime()
        {
            //calculate overtime
            double TotalOvertime = overtimePay1 + overtimePay2 + overtimePay3 + overtimePay4 + overtimePay5;
            Console.WriteLine($"The total Overtime paid this week is {TotalOvertime:c}");
            Console.ReadLine();
            return TotalOvertime;
        }
    }
}
