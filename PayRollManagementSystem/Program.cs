
using PayRollManagementSystem.Models;

PayrollManager payrollManager = new PayrollManager();

while (true);
{
    Console.WriteLine("Enter employee details or type 'exit' to finish:");

    Console.Write("Name: ");
    string name = Console.ReadLine();

    if (name.ToLower() == "exit") 
     
    Console.Write("Is Active (true/false): ");
    bool isActive = Convert.ToBoolean(Console.ReadLine());

    Console.Write("Start Date (yyyy-mm-dd): ");
    DateTime startDate = DateTime.Parse(Console.ReadLine());

    Console.Write("End Date (yyyy-mm-dd): ");
    DateTime endDate = DateTime.Parse(Console.ReadLine());

    Console.Write("Pay Date (yyyy-mm-dd): ");
    DateTime payDate = DateTime.Parse(Console.ReadLine());

    Console.Write("Regular Hours: ");
    double regularHours = Convert.ToDouble(Console.ReadLine());

    Console.Write("Overtime Hours: ");
    double overtimeHours = Convert.ToDouble(Console.ReadLine());

    //Console.Write("Regular Rate: ");
    //double regularRate = Convert.ToDouble(Console.ReadLine());

    //Console.Write("Overtime Rate: ");
    //double overtimeRate = Convert.ToDouble(Console.ReadLine());

    employee newEmployee = new employee(1500, 200)
    {
        Name = name,
        IsActive = isActive,
        StartDate = startDate,
        EndDate = endDate,
        PayDate = payDate,
        RegularHours = regularHours,
        OvertimeHours = overtimeHours
    };

    payrollManager.AddEmployee(newEmployee);
}

payrollManager.PrintEmployeeInfo();
    
