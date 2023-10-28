using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRollManagementSystem.Models
{
    public class PayrollManager
    {

        private List<Employee> employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public List<Employee> GetAllEmployees()
        {
            return employees;
        }

        public void PrintEmployeeInfo()
        {
            List<Employee> employees = GetAllEmployees();

            

            Console.WriteLine("Employee Info");

            var newTable = new ConsoleTable("Name", "Active", "Start Date", "End Date", "Pay Date", "Regular Hours", "Overtime Hours");
            var newTable2 = new ConsoleTable("Regular Rate", "OverTime Rate", "Gross Pay", "Net Pay", "Medicare Deduction", "Rent Deduction", "Food Deduction"); 
            foreach (var employee in employees)
            {
                employee.CalculatePayroll();
                newTable.AddRow(employee.Name, employee.IsActive, employee.StartDate, employee.EndDate, employee.PayDate, employee.RegularHours, employee.OvertimeHours);
                newTable2.AddRow(employee.RegularRate,employee.OvertimeRate, employee.GrossPay, employee.NetPay, employee.MedicareDeduction, employee.RentDeduction, employee.FoodDeduction);
               
            }

            newTable.Options.EnableCount = false;
            newTable2.Options.EnableCount = false;
            newTable.Write();
            newTable2.Write();
        }
    }
}
