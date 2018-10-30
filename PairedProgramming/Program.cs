using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairedProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee() { EmployeeID = 223445, EmployeeName = "John Landry", RateofPay = 15, HoursWorked = 35.50 });
            employees.Add(new Employee() { EmployeeID = 223476, EmployeeName = "Angela Rush", RateofPay = 15, HoursWorked = 32.25 });
            employees.Add(new Employee() { EmployeeID = 223487, EmployeeName = "Bill Marsh", RateofPay = 16.50, HoursWorked = 45.50 });
            employees.Add(new Employee() { EmployeeID = 223504, EmployeeName = "Peggy Simon", RateofPay = 16.75, HoursWorked = 50 });
            employees.Add(new Employee() { EmployeeID = 223512, EmployeeName = "Carl Yost", RateofPay = 15.75, HoursWorked = 40 });
            employees.Add(new Employee() { EmployeeID = 223519, EmployeeName = "Joe Miles", RateofPay = 15.00, HoursWorked = 40 });
            employees.Add(new Employee() { EmployeeID = 223525, EmployeeName = "Joan Jeffries", RateofPay = 14.25, HoursWorked = 25.75 });
            employees.Add(new Employee() { EmployeeID = 223536, EmployeeName = "George Mills", RateofPay = 13.65, HoursWorked = 38 });
            employees.Add(new Employee() { EmployeeID = 223542, EmployeeName = "Gary Cooper", RateofPay = 15.25, HoursWorked = 37.25 });
            employees.Add(new Employee() { EmployeeID = 223558, EmployeeName = "Mary Millicent", RateofPay = 15.75, HoursWorked = 40 });


            Console.WriteLine("Payroll Program\n\n\n");

            Console.WriteLine("ID           Employe Name            Rate of Pay         Hours Worked            Standard Pay        Overtime Pay        Total Pay");
            Console.WriteLine("**********************************************************************************************************************************");

            employees.ForEach((thisEmployee) => Console.WriteLine(thisEmployee.EmployeeID
                + $"{thisEmployee.EmployeeName, 19}" 
                + $"{thisEmployee.RateofPay.ToString("C"), 22}"
                + $"{thisEmployee.HoursWorked, 21}"
                + $"{thisEmployee.StandardPay().ToString("C"),20}"
                + $"{thisEmployee.TotalOvertime().ToString("C"),20}"
                + $"{thisEmployee.TotalPay().ToString("C"),20}"
                ));

            double sum = employees.Sum(s => s.TotalPay());

            Console.WriteLine("\n\n\n\nTotal Payroll\n**********\n" + sum);

            Console.WriteLine("\n\n\n\n\n");




        }
    }
}