using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class UC1_EmployeeCheck
    {
        int IS_FULL_TIME = 1;
        public void Employee()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("emp is present");
            }
            else
            {
                Console.WriteLine("emp is absent");
            }

        }
    }
}
