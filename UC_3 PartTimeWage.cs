using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class UC_3_PartTimeWage
    {
        public void Employee2()
        {
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;

            int emphours = 0;
            int empwage = 0;

            Random random = new Random();
            int empcheck = random.Next(0, 3);
            if (empcheck == IS_PART_TIME)
            {
                emphours = 4;
                Console.WriteLine(" PartTime");

            }
            else if (empcheck == IS_FULL_TIME)
            {
                emphours = 8;
                Console.WriteLine("emp FullTime");

            }
            else
            {
                emphours = 0;
                Console.WriteLine("no time");

            }
            empwage = emphours * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee wage is : " + empwage);
        }
    }
}
