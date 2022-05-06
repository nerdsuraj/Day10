using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class EmpWageBuilderArray
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private int NumOfComapny = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }

        public void addCompanyEmpWage(string Company, int EmpRatePerHour, int NumOfWorkingDays, int MaxHoursPerMonth)
        {
            companyEmpWageArray[this.NumOfComapny] = new CompanyEmpWage(Company, EmpRatePerHour, NumOfWorkingDays, MaxHoursPerMonth);
            NumOfComapny++;
        }

        public void ComputeEmpWage()
        {
            for (int i = 0; i < NumOfComapny; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.ComputeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }

        private int ComputeEmpWage(CompanyEmpWage CompanyEmpWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= CompanyEmpWage.MaxHoursPerMonth && totalWorkingDays < CompanyEmpWage.NumOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;

                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs :" + empHrs);
            }
            return totalEmpHrs * CompanyEmpWage.EmpRatePerHour;
        }
    }

    public class CompanyEmpWage
    {
        private string Company;
        public  int EmpRatePerHour;
        public int NumOfWorkingDays;
        public int MaxHoursPerMonth;
        public int TotalEmpWage;

        public CompanyEmpWage(string Company, int EmpRatePerHour, int NumOfWorkingDays, int MaxHoursPerMonth)
        {
            this.Company = Company;
            this.EmpRatePerHour = EmpRatePerHour;
            this.NumOfWorkingDays = NumOfWorkingDays;
            this.MaxHoursPerMonth = MaxHoursPerMonth;
        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.TotalEmpWage = totalEmpWage;
        }

        public string toString()
        {
            return "Total empwage for company : " + this.Company + " is : " + this.TotalEmpWage;
        }
    }
}
