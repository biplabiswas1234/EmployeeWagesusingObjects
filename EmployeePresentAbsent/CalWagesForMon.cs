using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePresentAbsent
{
    public class CalWagesForMon
    {
        public int EmpHour = 0;
        public int WagesPerHour = 20;
        public const int IsFullTime = 1;
        public const int IsPartTime = 2;
        public int EmployeeDay = 1;
        public int TotalWages = 0;
        public void EmployeeWages()
        {
            while (EmployeeDay <= 20)
            {
                Random EmpType = new Random();
                int EmpCheck = EmpType.Next(0, 3);
                switch (EmpCheck)
                {
                    case IsFullTime:
                        EmpHour = 8;
                        Console.WriteLine("Employee is full time");
                        break;
                    case IsPartTime:
                        EmpHour = 4;
                        Console.WriteLine("Employee is part time");
                        break;
                    default:
                        EmpHour = 0;
                        Console.WriteLine("Employee is absent");

                        break;
                }
                int EmployeeWage = EmpHour * WagesPerHour;
                TotalWages += EmployeeWage;
                EmployeeDay++;
                
            }
            Console.WriteLine("Total Wages:" + TotalWages);
        }


    }
}
