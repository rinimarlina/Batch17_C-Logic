using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.PartTwo
{


    internal class Employee
    {
        //instance variable
        private int empId;
        private string firstName;
        string lastName;
        DateTime joinDate;
        Decimal basicSalary;
        private string city;
        private string role;
        private decimal totalSalaryEmp;
        //static variable:global variable yg scopenya ada di class dan bisa dipakai oleh emp1, emp2, emp3 nanti doi ngecounter.
        public static int totalEmployee = 0;
        public static Decimal totalBasicSalary = 0M;

        //default constructor/empty constructor
        public Employee()
        {
            totalEmployee++;
            totalBasicSalary += this.BasicSalary;
            this.TotalSalaryEmp = this.basicSalary;
        }

        //constructor parameter
        public Employee(int empId, string firstName, string lastName, DateTime joinDate, decimal basicSalary)
        {
            this.empId = empId; //opsional : new Random().Next(1000, 1100);
            this.firstName = firstName;
            this.lastName = lastName;
            this.joinDate = joinDate;
            this.basicSalary = basicSalary;
            totalEmployee++;
            totalBasicSalary += this.BasicSalary;
            this.TotalSalaryEmp = this.basicSalary;
        }

        //overloading constructor
        public Employee(int empId, string firstName, string lastName, DateTime joinDate, decimal basicSalary, string city)
             : this(empId, firstName, lastName, joinDate, basicSalary)
        {
            this.city = city;
        }

        public Employee(int empId, string firstName, string lastName, DateTime joinDate, decimal basicSalary, string city, string role)
                : this(empId, firstName, lastName, joinDate, basicSalary, city)
        {
            this.role = role;
        }

        //method return
        public override string? ToString()
        {
            return $"Employee={this.empId} | {this.firstName} | {this.lastName} | {this.basicSalary} | Role : {this.role} | Total Salary : {this.TotalSalaryEmp}";
        }

        private decimal GetTotalSalary()
        {
            return this.basicSalary;
        }
        
        //create getset
        //get: untuk mengambil value dari variable
        //set : untuk manipulasi instance variable
        public int EmpId { get => empId; set => empId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime JoinDate { get => joinDate; set => joinDate = value; }
        public decimal BasicSalary
        {
            get => basicSalary;
            set
            {
                basicSalary = value;
                totalSalaryEmp = basicSalary;
            }
        }
        public string City { get => city; set => city = value; }
        public string Role { get => role; set => role = value; }
        public decimal TotalSalaryEmp { get => totalSalaryEmp; set => totalSalaryEmp = value; }
    }
    
}
