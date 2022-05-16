using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePresentAbsent
{
    public class PartTimeWagesToo
    {
        public int EmpPresent = 1;
        public int FullTimeEmp = 1;
        public int FullDayHour = 8;
        public int PartTimeHour = 4;
        public int WagesPerHour = 20;
        public void AlsoPartTimeWages()
        {
            Random Check = new Random();
            int CheckEmp = Check.Next(0, 2);
            if (EmpPresent == CheckEmp)
            {
                Console.WriteLine("Employee is present");
                Random TimeCheck = new Random();
                int CheckTimeEmp = TimeCheck.Next(0, 2);
                if (FullTimeEmp == CheckTimeEmp)
                {
                    Console.WriteLine("Employee is FullTimeEmp");
                    int DailyWages = FullDayHour * WagesPerHour;
                    Console.WriteLine("DailyWages: " + DailyWages);
                }
                else
                {
                    Console.WriteLine("Employee is PartTimeEmp");
                    int DailyWages1 = PartTimeHour * WagesPerHour;
                    Console.WriteLine("DailyWages: " + DailyWages1);
                }
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }

    }
}