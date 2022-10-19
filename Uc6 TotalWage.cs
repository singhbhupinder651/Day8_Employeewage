using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Uc6_TotalWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_WORKING_HOURS = 100;
        public void Employee5()
        {
            int emphours = 0;
            int totalemphours = 0;
            int totalworkingdays = 0;

            while (totalemphours <= MAX_WORKING_HOURS && totalworkingdays < NUM_OF_WORKING_DAYS)
            {
                totalworkingdays++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case IS_PART_TIME:
                        emphours = 4;
                        break;
                    case IS_FULL_TIME:
                        emphours = 8;
                        break;
                    default:
                        emphours = 0;
                        break;

                }

                totalemphours += emphours;
                Console.WriteLine("Day: " + totalworkingdays + "Employee hours: " + emphours);

            }
            int totalempwage = totalemphours * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Employee wage is : " + totalempwage);
        }
    }
}
