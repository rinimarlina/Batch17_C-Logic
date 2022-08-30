using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.PartTwo
{
    internal class EmployeeImpl : IEmployee
    {
        public Employee FindEmployeeById(List<Employee> list, int id)
        {
            Employee? emps = null;
            foreach (var item in list)
            {
                if(item.EmpId == id)
                {
                    emps = item;
                }
            }
            return emps;
        }

        public List<Employee> FindSalaryRange(List<Employee> list, decimal startFrom, decimal endTo)
        {
            var empRange = new List<Employee>();
            
            foreach (var item in list)
            {
                if(item.TotalSalaryEmp >= startFrom && item.TotalSalaryEmp <= endTo)
                {
                    empRange.Add(item);
                }
            }

            return empRange;
        }

        
        public decimal GetTotalSalary<T>(ref List<T> list)
        {
            var total = 0M;
            //OfType digunakan jika data yg dikirim generic dan kita ingin akses attribute
            foreach (var item in list.OfType<Employee>()) 
            {
                total += item.TotalSalaryEmp;
            }
            return total;   
        }

        public List<Employee> InitDataEmployee()
        {
            Employee emp1 = new Employee(1001, "Code", "Academy", new DateTime(), 5_000_000);
            Employee emp2 = new Employee(1002, "Fatin", "Fatiyah", new DateTime(), 6_000_000, "Bogor");
            Employee emp3 = new Employee(1003, "Budi", "Farhana", new DateTime(2023, 8, 29), 5_000_000, "Bandung");
         
            Programmer prog1 = new Programmer(1004, "Rini", "Marlina", new DateTime(2021, 07, 12), 6_500_000,
                                "Bogor", 500_000);
            
            Sales sals = new Sales(1005, "Anisa", "Farhanani", new DateTime(2020, 08, 14), 5_000_000,
                                    "Bogor", 1_000_000, 500_000);
           
            QA myQA = new QA(1005, "Fatih", "Akbar", new DateTime(2020, 07, 2), 4_500_000,
                            "Bogor", 10_000);

            //direct return without variable
            return new List<Employee> { emp1, emp2, emp3, prog1, sals, myQA };
        }
         

        public void ShowList<T>(ref List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }
        }

        
    }
}
