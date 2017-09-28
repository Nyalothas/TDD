namespace Calculator
{
    public class SalaryCalculator
    {
        const int HoursInYear = 2080;
        public decimal GetAnnualSalary(decimal hourlyWage)
        {
            return hourlyWage * HoursInYear;
        }

        public decimal GetHourlyWage(int annualSalary)
        {
            return annualSalary/HoursInYear;
        }
    }
}
