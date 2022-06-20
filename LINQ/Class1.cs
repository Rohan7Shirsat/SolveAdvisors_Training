
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;namespace LINQ_Assignment
{
          
    //1. Create an employee class with properties (Id, Name, City, Salary).

    class Employee
    {
        public int EmpId { get; set; }
        public string EName { get; set; }
        public string City { get; set; }
        public double Salary { get; set; }
        public static void Main(string[] args)
        {
            //2. Create List of Employees with hardcodes employes(100 entries, Id 1 to 100) //
            
            List<Employee> empList = new List<Employee>();

           var empList2 = new List<String>() { "Pune","Ahmednagar","Nagpur","Latur" };    

            Random rand = new Random();

            for (int i = 1; i < 101; i++)
            {
                int index=rand.Next(empList2.Count);
                empList.Add(new Employee()
                {
                    EmpId = i,
                    EName = " Emp" + i,
                    City = empList2[index],
                    Salary = 12345 + i * 10
                }) ;
            }
           

            //3. Write a Linq query to find employee with an id 45

            var empID = empList.Where(e => e.EmpId == 45);
            foreach (Employee emp in empID)
            {
                Console.WriteLine("Emp ID:" + emp.EmpId + "Emp Name:" + emp.EName + " City:" + emp.City + " Salary:" + emp.Salary);
            }

            Console.WriteLine("==================================================================================================");
            Console.WriteLine();

            //4.Write a Linq query to find employees with an id that are even

          
                    var empEven = empList.Where(e => e.EmpId%2 == 0);
                    foreach (Employee emp in empEven)
                    {
                        Console.WriteLine("ID:" + emp.EmpId + " Name:" + emp.EName + " City:" + emp.City + " Salary:" + emp.Salary);
                    }
                
            
            Console.WriteLine("==================================================================================================");
            Console.WriteLine(); 
            
            //5. Write a Linq query to find highest salary holder

            var highest = empList.Where(e=>e.City == "Pune").Max(e => e.Salary);
            Console.WriteLine("Max Salary is :" + highest);
            Console.WriteLine();
            Console.WriteLine("==================================================================================================");
            
            //6. Write a Linq query to find highest salary holder in Pune City
           
            var highSalaryCity = empList.Where(emp => emp.City == "Pune").GroupBy(e => e.City)
            .Select(em => em.OrderByDescending(e => e.Salary).First());
            //Console.WriteLine("Max Salary in Pune:" + highSalaryCity);
            foreach (Employee emp in highSalaryCity)
            {
                Console.WriteLine("ID:" + emp.EmpId + " Name:" + emp.EName + " City:" + emp.City + " Salary:" + emp.Salary);
            }
            Console.WriteLine();
            Console.WriteLine("==================================================================================================");
            
            //7. Write a Linq query to find highest salary holder from each city

            var highSalEachCity = empList.GroupBy(e => e.City)
            .Select(em => em.OrderByDescending(e => e.Salary).First());
            foreach (Employee emp in highSalEachCity)
            {
                Console.WriteLine("ID:" + emp.EmpId + " Name:" + emp.EName + " City:" + emp.City + " Salary:" + emp.Salary);
            }


        }
    }
}

