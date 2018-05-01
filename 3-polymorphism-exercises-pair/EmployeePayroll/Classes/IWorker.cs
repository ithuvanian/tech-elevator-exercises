using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    interface IWorker
    {

        string FirstName { get; }
        string LastName { get; }
        int HoursWorked { get; }

        double CalculateWeeklyPay(int hoursWorked);

    }
}
