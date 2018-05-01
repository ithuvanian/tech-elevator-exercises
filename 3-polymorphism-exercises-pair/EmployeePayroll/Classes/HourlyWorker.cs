using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    public class HourlyWorker : IWorker
    {
        public string FirstName { get; }
        public string LastName { get; }
        public double HourlyRate { get; }
        public int HoursWorked { get; }

        public HourlyWorker(double hourlyRate, string firstName, string lastName, int hoursWorked)
        {
            this.HourlyRate = hourlyRate;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.HoursWorked = hoursWorked;
        }


        public double CalculateWeeklyPay(int hoursWorked)
        {
            double pay = hoursWorked * HourlyRate;
            int overtime = hoursWorked - 40;
            if (overtime > 0)
            {
                pay = pay + HourlyRate * overtime *.5;
            }
            return pay;
        }

    }
}
