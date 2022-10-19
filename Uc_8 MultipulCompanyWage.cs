﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Uc_8_MultipulCompanyWage
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int IS_ABSENT = 0;
        float EmpDailyWage = 0;
        public float TotalWage = 0;
        private Dictionary<String, Company> Companies = new Dictionary<String, Company>();

        public void AddCompany(String CompanyName, int EmpWagePerhour, int FullTime_WorkingHrs_PerDay, int PartTime_WorkingHours_PerDay, int MAX_WORKING_HRS, int MAX_WORKING_DAYS)
        {
            Company company = new(CompanyName.ToLower(), EmpWagePerhour, FullTime_WorkingHrs_PerDay, PartTime_WorkingHours_PerDay, MAX_WORKING_HRS, MAX_WORKING_DAYS);
            Companies.Add(CompanyName.ToLower(), company);
        }

        public int IsEmployeePresent()
        {
            return new Random().Next(0, 3);
        }

        public void CalculateEmpWage(string CompanyName)
        {
            int DayNumber = 1;
            int EmpWorkingHours = 0;
            int TotalWorkingHrs = 0;

            if (!Companies.ContainsKey(CompanyName.ToLower()))
                throw new ArgumentNullException("Company Don't Exist");
            _ = Companies.TryGetValue(CompanyName.ToLower(), out Company company);



            while (DayNumber <= company.MAX_WORKING_DAYS && TotalWorkingHrs <= company.MAX_WORKING_HRS)
            {

                switch (IsEmployeePresent())
                {
                    case IS_ABSENT:
                        EmpWorkingHours = 0;
                        break;

                    case IS_PART_TIME:
                        EmpWorkingHours = company.PartTime_WorkingHours_PerDay;
                        break;

                    case IS_FULL_TIME:
                        EmpWorkingHours = company.FullTime_WorkingHrs_PerDay;
                        break;
                }
                EmpDailyWage = EmpWorkingHours * company.EmpWagePerHour;

                TotalWage += EmpDailyWage;
                DayNumber++;
                TotalWorkingHrs += EmpWorkingHours;
            }
            Console.WriteLine("Total working days :" + (DayNumber - 1) + "\n Total working hours :" + TotalWorkingHrs + "");
            Console.WriteLine("Total Employee wage :" + TotalWage);
        }
    }
}
