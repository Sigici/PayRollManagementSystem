using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRollManagementSystem.Models    
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime PayDate { get; set; }
        public double RegularHours { get; set; }
        public double OvertimeHours { get; set; }

        // Private fields for regular and overtime rates
        private double regularRate;
        private double overtimeRate;

        // Public read-only properties for regular and overtime rates
        public double RegularRate
        {
            get { return regularRate; }
        }

        public double OvertimeRate
        {
            get { return overtimeRate; }
        }

        public double GrossPay { get; private set; }
        public double NetPay { get; private set; }
        public double MedicareDeduction { get; private set; }
        public double RentDeduction { get; private set; }
        public double FoodDeduction { get; private set; }

        public Employee (double regularRate, double overtimeRate)
        {
            this.regularRate = regularRate;
            this.overtimeRate = overtimeRate;
        }

        public void CalculatePayroll()
        {
            if (IsActive)
            {
                // Calculate Gross Pay
                GrossPay = (RegularHours * RegularRate) + (OvertimeHours * OvertimeRate);

                // Calculate Deductions
                MedicareDeduction = 0.02 * GrossPay;
                RentDeduction = 0.05 * GrossPay;
                FoodDeduction = 0.03 * GrossPay;

                // Calculate Net Pay
                NetPay = GrossPay - (MedicareDeduction + RentDeduction + FoodDeduction);
            }
        }

    }
}
