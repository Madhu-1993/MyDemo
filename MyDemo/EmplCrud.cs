using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyDemo.EmplProject;
using static MyDemo.EmplProject.Employee;

namespace MyDemo
{
    internal class EmplCrud
    {
        private static int salary;

        static void Main(String[]args)
        {
            EmployeeCRUD empCrud=new EmployeeCRUD();
            int op = 0;
            do
            {
                Console.WriteLine("1.AddEmployee");
                Console.WriteLine("2.UpdateEmployee");
                Console.WriteLine("3.DeleteEmployee");
                Console.WriteLine("4.View All");
                Console.WriteLine("5.View By Id");
                Console.WriteLine("6.Salary less than 30000");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Employee e = new Employee();
                        Console.WriteLine("Enter Id");
                        e.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter employee Name");
                        e.Name = Console.ReadLine();
                        Console.WriteLine("Enter salary");
                        e.Salary= Convert.ToInt32(Console.ReadLine());
                        empCrud.AddEmployee(e);
                        break;

                    case 2:
                        Employee e1 = new Employee();
                        Console.WriteLine("Enter Id");
                        e1.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Name");
                        e1.Name = Console.ReadLine();
                        Console.WriteLine("Enter Price");
                        e1.Salary = Convert.ToInt32(Console.ReadLine());
                        empCrud.UpdateEmployee(e1);
                        break;

                    case 3:
                        Console.WriteLine("Enter Id");
                        int id=Convert.ToInt32(Console.ReadLine());
                        empCrud.DeleteEmployee(id);
                        break;

                    case 4:
                        List<Employee> list = empCrud.GetEmployees();
                        Console.WriteLine("Id \t Name \t Salary");
                        foreach(Employee item in list)
                        {
                            Console.WriteLine($"{item.Id} \t {item.Name} \t {item.Salary}");
                        }
                        break;
                      
                    case 5:
                        Console.WriteLine("Enter Id");
                        int Id2 = Convert.ToInt32(Console.ReadLine());
                        Employee item2= empCrud.GetEmployeeById(Id2);
                        Console.WriteLine("Id \t Name \t Salary");
                        Console.WriteLine($"{item2.Id} \t {item2.Name} \t {item2.Salary}");
                        break;

                    case 6:
                        Console.WriteLine("Enter the sallary");
                        if (salary < 30000)
                        {
                            Console.WriteLine("Salary is less then 30000");
                        }
                        else
                        {
                            Console.WriteLine("Salary is greater than 30000");
                        }
                        break;

                    default:
                        Console.WriteLine("No option available");
                        break;
                }
                Console.WriteLine("Do you want to continue");
                op = Convert.ToInt32(Console.ReadLine());
            }
            while (op == 1);
        }
    }
}
