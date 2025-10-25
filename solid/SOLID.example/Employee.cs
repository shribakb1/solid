using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.SOLID.example
{
    public class Employee
    {
        public string EmployeeType { get; set; }
        public double TotalHoursWorked { get; set; }

        public void Save(Employee employee)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Logger  logger = new Logger();
                logger.LogError(ex.Message);
            }
        }
    }

    public enum employeeType
    {
        Permanent,
        Contract,
        Intern,
        CLevel
    }
}
