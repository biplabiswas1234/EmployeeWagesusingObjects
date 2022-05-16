using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePresentAbsent
{
    internal class CheckPresentAbsent
    {
        public void CheckEmpPresentAbsent()
        {
            int EmpPresent = 1;
            Random check = new Random();
            int CheckEmp = check.Next(0, 2);

            if (EmpPresent == CheckEmp)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
