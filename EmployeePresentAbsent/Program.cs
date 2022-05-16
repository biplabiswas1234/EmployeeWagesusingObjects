using System;

namespace EmployeePresentAbsent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DailyWages checkEmpwages = new DailyWages();
            checkEmpwages.CheckEmpPresentAbsent();
        }
    }
}
