using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemo
{
    internal class StudentCRUD
    {
        static void Main(string[]args)
        {
            StudentCRUD studentCRUD=new StudentCRUD();
            int op = 0;
            do
            {
                Console.WriteLine("1.Add Student");
                Console.WriteLine("2.Update Student");
                Console.WriteLine("3.Delete Student");
                Console.WriteLine("4.View All");
                Console.WriteLine("5.View by Id");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        StudentProject s = new StudentProject();
                        Console.WriteLine("Enter rollno");
                        s.Roll_no = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Name");
                        s.Name = Console.ReadLine();
                        Console.WriteLine("Enter Percentage");
                        s.Per = Convert.ToInt32(Console.ReadLine());
                        studentCRUD.AddStudent(s);
                        break;

                    case 2:
                        StudentProject s1 = new StudentProject();
                        Console.WriteLine("Enter Rollno");
                        s1.Roll_no = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Name");
                        s1.Name= Console.ReadLine();
                        Console.WriteLine("Enter the percentage");
                        s1.Per= Convert.ToInt32(Console.ReadLine());
                        studentCRUD.UpdateStudent(s1);
                        break; 
                    
                    case 3:
                        Console.WriteLine("Enter the Rollno");
                        int roll_no = Convert.ToInt32(Console.ReadLine());
                        studentCRUD.DeleteStudent(roll_no);
                        break; 
                    
                    case 4:
                        List<StudentProject> list = studentCRUD.GetStudents();
                        Console.WriteLine("Roll_no \t Name \t Percentage");
                        foreach(StudentProject item in list)
                        {
                            Console.WriteLine($"{item.Roll_no} \t {item.Name} \t {item.Per}");                
                        }
                        break;

                    case 5:
                        Console.WriteLine("Enter rollno");
                        int roll_no2 = Convert.ToInt32(Console.ReadLine());
                        StudentProject item2 = studentCRUD.GetStudentByRollno(roll_no2);
                        Console.WriteLine("Roll no \t Name \t Percentage");
                        Console.WriteLine($"{item2.Roll_no} \t {item2.Name} \t {item2.Per}");
                        break;

                    default:
                        Console.WriteLine("No option available");
                        break;
                }
                Console.WriteLine("Do you want to continue");
                op = Convert.ToInt32(Console.ReadLine());
            } while (op == 1);
        }

        private void AddStudent(StudentProject s)
        {
            throw new NotImplementedException();
        }

        private void UpdateStudent(StudentProject s1)
        {
            throw new NotImplementedException();
        }

        private void DeleteStudent(int roll_no)
        {
            throw new NotImplementedException();
        }

        private List<StudentProject> GetStudents()
        {
            throw new NotImplementedException();
        }

        private StudentProject GetStudentByRollno(int roll_no2)
        {
            throw new NotImplementedException();
        }
    }
}
