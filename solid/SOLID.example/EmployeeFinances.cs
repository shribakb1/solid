using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.SOLID.example
{

    public interface IEmployeeRewards
    {
        public double CalculateBonus(Employee employee)
        {
            return 5;
        }
    }
    public interface IEmployeeFinances: IEmployeeRewards
    {
        public double CalculateSalary(Employee employee)
        {
            return 20;
        }
    }

    public interface IStockOptions: IEmployeeFinances
    {
        public double CalculateStockOptions(Employee employee)
        {
            return 1000;
        }
    }

    public class PermanentEmployeeFinances : IEmployeeFinances
    {
        public double CalculateSalary(Employee employee)
        {
            return employee.TotalHoursWorked * 50;
        }
        public double CalculateBonus(Employee employee)
        {
            return employee.TotalHoursWorked * 10;
        }
    }

    public class ContractEmployeeFinances : IEmployeeRewards
    {
        public double CalculateBonus(Employee employee)
        {
            return employee.TotalHoursWorked * 5;
        }
    }
    public class InternEmployeeFinances : IEmployeeFinances
    {
        public double CalculateSalary(Employee employee)
        {
            return employee.TotalHoursWorked * 15;
        }
        public double CalculateBonus(Employee employee)
        {
            return 0;
        }
    }

    public class CLevelEmployeeFinances: IStockOptions
    {
        public double CalculateSalary(Employee employee)
        {
            return employee.TotalHoursWorked * 70;
        }
        public double CalculateBonus(Employee employee)
        {
            return employee.TotalHoursWorked * 15;
        }
        public double CalculateStockOptions(Employee employee)
        {
            return employee.TotalHoursWorked * 500;
        }
    }
}