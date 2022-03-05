using System;

namespace UC8
{
    internal class Program
    {
        public const int parttime = 1;
        public const int fulltime = 2;
        private static int totalEmpHrs;

        public static int ComputeEmpWage (string company, int empRatePerHour, int numOfWorkingDays, int maxHourPerMonth)
        {
            totalEmpHrs = 0, totalworkingDays = 0;

            while (totalEmpHrs <= maxHourPerMonth && totalworkingDays < numOfWorkingDays) ;
            {
                int empHrs = 0;
                totalworkingDays++;
                Random rand = new Random();
                int empCheck=rand.Next(0, 3);
                switch (empCheck)
                {
                    case parttime: 
                        empHrs=4 ; 
                        break;
                        case fulltime:
                        empHrs=8 ; 
                        break;
                        default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs = empHrs;
                Console.WriteLine("Days#:" + totalworkingDays + "Emp Hrs:" + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage for Company:" + company + "is: " + totalEmpWage);
            return totalEmpWage;
        }

        static void Main(string[] args)
        {
            ComputeEmpWage("Dmart", 20, 2, 10);
            ComputeEmpWage("Reliance", 10, 4, 20);
        }
    }
}
