using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day4.PartOne
{
    internal class Programmer : Employee
    {
        private Decimal transportasi;

        public Programmer(int empId, string firstName, string lastName, 
            DateTime joinDate, decimal basicSalary, string city, 
            decimal transportasi) : base(empId, firstName, lastName, joinDate, basicSalary, city)
        {
            this.Transportasi = transportasi;
            this.Role = "Programmer";
            TotalSalaryEmp = basicSalary + transportasi;
        }

        public decimal Transportasi { get => transportasi; set => transportasi = value; }
        

        public override string ToString()
        {
            return $"{base.ToString()} | Tunjangan Transportasi = {this.transportasi.ToString("C", new CultureInfo("id-ID"))} | Total salary = {this.TotalSalaryEmp.ToString("C", new CultureInfo("id-ID"))}";
        }
        public decimal TotalSalary { get => TotalSalary; set => TotalSalary = value; }

    }
}
