using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EmpWageBuilder Dmart = new EmpWageBuilder("Dmart", 20, 2, 10);
            //EmpWageBuilder Reliance = new EmpWageBuilder("Reliance", 10, 4, 20);
            //Dmart.ComputeWage();
            //Console.WriteLine(Dmart.ToString());
            //Reliance.ComputeWage();
            //Console.WriteLine(Reliance.ToString());


            Console.WriteLine("...........................................................");

            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("Dmart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.ComputeEmpWage();


            Console.ReadKey();
        }
    }
}
