using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IWorker> AllWorkers = new List<IWorker>();
            HourlyWorker Hourly = new HourlyWorker(20, "John", "Doe", 40);
            SalaryWorker Salary = new SalaryWorker(40, "Jane", "Doe", 40);
            VolunteerWorker Volunteer = new VolunteerWorker("Steve", "Jobs", 44);
            AllWorkers.Add(Hourly);
            AllWorkers.Add(Salary);
            AllWorkers.Add(Volunteer);
            Console.WriteLine($"Employee".PadRight(15) + "Hours".PadRight(12) + "Pay".PadRight(10));
            int totalHours = 0;
            double totalPay = 0;
            foreach (IWorker Worker in AllWorkers)
            {
                
                
                Console.WriteLine($"{Worker.FirstName} {Worker.LastName.PadRight(10)} {Worker.HoursWorked.ToString().PadRight(10)} {Worker.CalculateWeeklyPay(Worker.HoursWorked).ToString().PadRight(10)}");
                totalHours += Worker.HoursWorked;
                totalPay += Worker.CalculateWeeklyPay(Worker.HoursWorked);
            }

            Console.WriteLine($"Total Hours : {totalHours}");
            Console.WriteLine($"Total Pay : {totalPay.ToString("$0.00")}");

        }
    }
}
