using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    public class SalaryWorker : IWorker
    {
        public double AnnualSalary { get;  }
        public string FirstName { get;  }
        public string LastName { get; }
        public int HoursWorked { get; }

        public SalaryWorker(double annualSalary, string firstName, string lastName, int hoursWorked)
        {
            this.AnnualSalary = annualSalary;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.HoursWorked = hoursWorked;
        }

        public double CalculateWeeklyPay(int hoursWorked)
        {
            return AnnualSalary / 52;
        }

    }
}
