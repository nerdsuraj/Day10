using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class EmpWageBuilder
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private string Company;
        private int EmpRatePerHour;
        private int NumOfWorkingDays;
        private int MaxHoursPerMonth;
        private int TotalEmpWage;

        public EmpWageBuilder(string Company, int EmpRatePerHour, int NumOfWorkingDays, int MaxHoursPerMonth)
        {
            this.Company = Company;
            this.EmpRatePerHour = EmpRatePerHour;
            this.NumOfWorkingDays = NumOfWorkingDays;
            this.MaxHoursPerMonth = MaxHoursPerMonth;
        }

        public void ComputeWage()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= MaxHoursPerMonth && totalWorkingDays < NumOfWorkingDays)
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
            int totalEmpWage = totalEmpHrs * EmpRatePerHour;
            Console.WriteLine("Total Emp Wage :" + totalEmpWage);
        }

        public string toString()
        {
            return "Total empwage for company : " + this.Company + " is : " + this.TotalEmpWage;
        }
    }
}
