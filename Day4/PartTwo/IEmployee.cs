﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.PartTwo
{
    internal interface IEmployee
    {
        public List<Employee> InitDataEmployee();
        
        public void ShowList<T>(ref List<T>list);

        public Employee FindEmployeeById(List<Employee> list, int id);

        //method return with genric datatype <T>
        public decimal GetTotalSalary<T>(ref List<T> list);
        
        public List<Employee> FindSalaryRange(List<Employee> list,decimal startFrom,decimal endTo);


        //aghregate summary total employee
       // public Dictionary<string, int> GetTotalEmployeeByRole(List<Employee> list);
    }
}
