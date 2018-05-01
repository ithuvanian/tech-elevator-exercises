using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    public class VolunteerWorker : IWorker
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int HoursWorked { get; }

        public VolunteerWorker(string firstName, string lastName, int hoursWorked)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.HoursWorked = hoursWorked;
        }

        public double CalculateWeeklyPay(int hoursWorked)
        {
            int pay = hoursWorked * 0;
            return pay;
        }
    }
}
