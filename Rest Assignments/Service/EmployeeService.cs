using Rest_Assignments.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rest_Assignments.Service
{
   
        public interface IEmployeeService
        {
            void AddEmployee(Employee employee);
            Employee GetEmployeeByID(int id);
            IEnumerable<Employee> GetAllEmployee();
            Employee GetHighestSalaryByCity(string city);
            IEnumerable<Employee> GetEmployeesWithoutID(string name,string city);

        }

   
    public class EmployeeService : IEmployeeService
    {

        List<Employee> _employee = new List<Employee>
        {
                 new Employee { EmployeeID = 1, EmployeeName = "Rohan", Salary = 30000, City = "Pune"},
                 new Employee { EmployeeID = 2, EmployeeName = "Aayaz", Salary = 40000, City = "Nashik"},
                 new Employee { EmployeeID = 3, EmployeeName = "Pavan", Salary = 50000, City = "Latur"}
        };


        public void AddEmployee(Employee employee)
        {
            _employee.Add(employee);

        }
        public IEnumerable<Employee> GetAllEmployee()
        {
           return _employee;
        }

       

        public Employee GetEmployeeByID(int id)
        {
            var EmployeeByID = _employee.FirstOrDefault(e => e.EmployeeID == id);
            return EmployeeByID;
        }

        public Employee GetHighestSalaryByCity(string city)
        {
            var employeeHighSalaryByCity = _employee.Where(e => e.City == city).OrderByDescending(e => e.Salary).First();
            return employeeHighSalaryByCity;
        }

        IEnumerable<Employee> IEmployeeService.GetEmployeesWithoutID(string name, string city)
        {
            var employeeWithoutId = _employee.Where(e => e.City == city).ToList();
            return employeeWithoutId;
        }
    
    }
}

   
