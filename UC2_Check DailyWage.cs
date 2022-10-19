using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class UC2_Check_DailyWage
    {
        public void Employee1()
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;

            int emphours = 0;
            int empwage = 0;

            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == IS_FULL_TIME)
            {
                emphours = 8;
                Console.WriteLine("emp present");
            }
            else
            {
                emphours = 0;
                Console.WriteLine("emp absent");


            }
            empwage = emphours * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee wage is : " + empwage);

        }
    }
}
