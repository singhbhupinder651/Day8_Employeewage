using EmployeeWage;

//UC1_EmployeeCheck ran = new UC1_EmployeeCheck();
//ran.Employee();

UC2_Check_DailyWage ran1 = new UC2_Check_DailyWage();
ran1.Employee1();

UC_3_PartTimeWage ran2= new UC_3_PartTimeWage();
ran2.Employee2();

Uc4_SwitchCase ran3=new Uc4_SwitchCase();
ran3.Employee3();

Uc5_MonthlyWage ran4=new Uc5_MonthlyWage();
ran4.Employee4();

Uc6_TotalWage ran5=new Uc6_TotalWage();
ran5.Employee5();

Uc7_RefractorCode ran6=new Uc7_RefractorCode();
ran6.Employee6();

Uc_8_MultipulCompanyWage ran7= new Uc_8_MultipulCompanyWage();
ran7.AddCompany("TATA", 20, 8, 4, 100, 20);
ran7.CalculateEmpWage("TATA");