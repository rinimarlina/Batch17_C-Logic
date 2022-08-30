using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.PartTwo
{
    internal class QA : Employee
    {
        private Decimal makan;

        public QA(int empId, string firstName, string lastName, DateTime joinDate, decimal basicSalary, string city, decimal makan) :
            base(empId, firstName, lastName, joinDate, basicSalary, city)
        {
            this.Makan = makan;
            this.Role = "QA";
            TotalSalaryEmp = basicSalary + makan;
        }

        public decimal Makan { get => makan; set => makan = value; }

        public override string? ToString()
        {
            return $"{base.ToString()} | Tunjangan QA = {this.makan.ToString("C", new CultureInfo("id-ID"))} " +
                $"| Total salary = {this.TotalSalaryEmp.ToString("C", new CultureInfo("id-ID"))}";
        }

        public decimal TotalSalary { get => TotalSalary; set => TotalSalary = value; }
    }
}
