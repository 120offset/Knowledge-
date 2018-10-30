using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PairedProgramming
{
    public class Employee 
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public double RateofPay { get; set; }
        public double HoursWorked { get; set; }

        double overTime;
        double otPay;
        double otTotal;
        double totalPay;
        double pay;

        public double StandardPay()
        {
            if (HoursWorked > 40)
            {
                pay = 40 * RateofPay;
            }
            else
            {
                pay = HoursWorked * RateofPay;
            }
            return pay;
        }

        public double TotalOvertime()
        {
            if (HoursWorked > 40)
            {
                overTime = HoursWorked - 40;
                otPay = (RateofPay * 1.5);
                otTotal = overTime * otPay;

            }
            else
            {
                otTotal = 0;
            }
            return otTotal;
        }

        public double TotalPay()
        {

            totalPay = pay + otTotal;
            return totalPay;
        }

        



    }
}
