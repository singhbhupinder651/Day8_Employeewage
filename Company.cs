namespace EmployeeWage
{
    internal class Company
    {
        private string v;
        private int empWagePerhour;
        private int fullTime_WorkingHrs_PerDay;
        private int partTime_WorkingHours_PerDay;
        private int mAX_WORKING_HRS;

        public Company(string v, int empWagePerhour, int fullTime_WorkingHrs_PerDay, int partTime_WorkingHours_PerDay, int mAX_WORKING_HRS, int mAX_WORKING_DAYS)
        {
            this.v = v;
            this.empWagePerhour = empWagePerhour;
            this.fullTime_WorkingHrs_PerDay = fullTime_WorkingHrs_PerDay;
            this.partTime_WorkingHours_PerDay = partTime_WorkingHours_PerDay;
            this.mAX_WORKING_HRS = mAX_WORKING_HRS;
            MAX_WORKING_DAYS = mAX_WORKING_DAYS;
        }

        public int MAX_WORKING_DAYS { get; internal set; }
        public int PartTime_WorkingHours_PerDay { get; internal set; }
        public int FullTime_WorkingHrs_PerDay { get; internal set; }
        public int EmpWagePerHour { get; internal set; }
        public int MAX_WORKING_HRS { get; internal set; }
    }
}