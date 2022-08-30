using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.PartOne
{
    internal class Sales : Employee
    {
        private Decimal bonus;
        private Decimal commision;

        public Sales(int empId, string firstName, string lastName, DateTime joinDate, decimal basicSalary, string city, decimal bonus, decimal commision) :
            base(empId, firstName, lastName, joinDate, basicSalary, city)
        {
            this.Bonus = bonus;
            this.commision = commision;
            this.Role = "Sales";
            TotalSalaryEmp = basicSalary + bonus + commision;
        }

        public decimal Bonus { get => bonus; set => bonus = value; }
        public decimal Commision { get => commision; set => commision = value; }

        public override string? ToString()
        {
            return $"{base.ToString()} | Tunjangan Sales ( Bonus = {this.bonus.ToString("C", new CultureInfo("id-ID"))} Commision = {this.commision.ToString("C", new CultureInfo("id-ID"))} )" +
                   $"| Total salary = {this.TotalSalaryEmp.ToString("C", new CultureInfo("id-ID"))}";
        }
        
        public decimal TotalSalary { get => TotalSalary; set => TotalSalary = value; }
    }
}
