
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
                    EName = "Emp" + i,
                    City = empList2[index],
                    Salary = 12345 + i * 10
                }) ;
            }

            Console.WriteLine("1) Write a Linq query to find employee with an id 45");
            Console.WriteLine();

            var empWithId45  = empList.First(e => e.EmpId == 45);
            Console.WriteLine("Emp ID :" + empWithId45.EmpId + "  Emp Name : " + empWithId45.EName + "  Emp Salary :" + empWithId45.Salary);

            Console.WriteLine("============================================================================================");
            Console.WriteLine();

            Console.WriteLine("2) Write a Linq query to find employees with an id that are even");
            Console.WriteLine();


            foreach (Employee emp in empList.Where(e => e.EmpId % 2 == 0))
                    {
                        Console.WriteLine("ID:" + emp.EmpId + " Name:" + emp.EName + " City:" + emp.City + " Salary:" + emp.Salary);
                    }
                
            
            Console.WriteLine("==================================================================================================");
            Console.WriteLine();

            Console.WriteLine("3) Write a Linq query to find highest salary holder");
            Console.WriteLine();
            var highestSal = empList.OrderByDescending(e => e.Salary).First();
            Console.WriteLine("ID:" + highestSal.EmpId + " Name:" + highestSal.EName + " City:" + highestSal.City + " Salary:" + highestSal.Salary);
            Console.WriteLine();
            Console.WriteLine("==================================================================================================");

            Console.WriteLine("4) Write a Linq query to find highest salary holder in Pune City ");
           
            var highSalaryInPuneCity = empList.Where(e=>e.City == "Pune").OrderByDescending(e => e.Salary).First();
            Console.WriteLine();
            Console.WriteLine("EmpId : "+highSalaryInPuneCity.EmpId + "  Emp Name : " + highSalaryInPuneCity.EName +"  Emp Salary"+highSalaryInPuneCity.Salary);
           
            Console.WriteLine();
            Console.WriteLine("==================================================================================================");

            Console.WriteLine("5) Write a Linq query to find highest salary holder from each city");
            Console.WriteLine();

            foreach (Employee emp1 in empList.GroupBy(e => e.City)
            .Select(e => e.OrderByDescending(e => e.Salary).First()))
            {
                Console.WriteLine("ID:" + emp1.EmpId + " Name:" + emp1.EName + " City:" + emp1.City + " Salary:" + emp1.Salary);
            }


        }
    }
}

