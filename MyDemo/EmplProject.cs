using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemo
{
    internal class EmplProject
    {
        public class Employee
        {
            public int Id;
            public string Name;
            public int Salary;
        public Employee()
            {
                Id = 1;
                Name= string.Empty;
                Salary = 0;
            }

            public class EmployeeCRUD
            {
                private List<Employee> employees;
                public EmployeeCRUD()
                {
                    employees = new List<Employee>();
                }
                public void AddEmployee(Employee emp)
                {
                    employees.Add(emp);
                }
                public void UpdateEmployee(Employee emp)
                {
                    foreach(Employee e in employees)
                    {
                        if(e.Id == emp.Id)
                        {
                            e.Id= emp.Id;
                            e.Name = emp.Name;
                            e.Salary = emp.Salary;
                        }
                    }
                }
                public void DeleteEmployee(int id)
                {
                    foreach(Employee e in employees)
                    {
                        if(e.Id==id)
                        {
                            employees.Remove(e);
                            break;
                        }
                    }
                }
                public List<Employee> GetEmployees()
                {
                    return employees;
                }
                public Employee GetEmployeeById(int id)
                {
                    Employee emp = new Employee();
                    foreach(Employee e in employees)
                    {
                        if (e.Id == id)
                        {
                            emp = e;
                            break;
                        }
                    }
                    return emp;
                }
            }
        }
    }
}
