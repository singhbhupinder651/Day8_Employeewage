using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Uc5_MonthlyWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public void Employee4()
        {
            int emphours = 0;
            int empwage = 0;
            int totalempwage = 0;

            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {

                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case IS_PART_TIME:
                        emphours = 4;
                        Console.WriteLine("part time");
                        break;
                    case IS_FULL_TIME:
                        emphours = 8;
                        Console.WriteLine("full time");
                        break;
                    default:
                        emphours = 0;
                        Console.WriteLine("no time");
                        break;

                }

                empwage = emphours * EMP_RATE_PER_HOUR;
                totalempwage += empwage;
                Console.WriteLine("Employee wage is : " + empwage);
            }
            Console.WriteLine("Total Employee wage is : " + totalempwage);
        }
    }
}
