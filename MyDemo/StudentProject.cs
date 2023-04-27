using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemo
{
    internal class StudentProject
    {
        public int Roll_no { get; internal set; }
        public string? Name { get; internal set; }
        public int Per { get; internal set; }

        public class Student
        {
            public int Roll_no;
            public string Name;
            public int Per;
        }
       
       public class StudentCRUD
        {
            private List<Student> students;
            public StudentCRUD()
            {
                students = new List<Student>();
            }
            public void AddStudent(Student stud)
            {
                students.Add(stud);
            }
            public void UpdateStudent(Student stud)
            {
                foreach(Student s in students)
                {
                    if(s.Roll_no==stud.Roll_no)
                    {
                        s.Roll_no=stud.Roll_no;
                        s.Name=stud.Name;
                        s.Per = stud.Per;
                    }
                }
            }
            public void DeleteStudent(int roll_no)
            {
                foreach(Student s in students)
                {
                    if(s.Roll_no==roll_no)
                    {
                        students.Remove(s);
                        break;
                    }
                }
            }
            public List<Student>GetStudents()
            {
                return students;
            }
            public Student GetStudentByRollno(int roll_no)
            {
                Student stud = new Student();
                foreach(Student s in students)
                {
                    if(s.Roll_no==roll_no)
                    {
                        stud = s;
                        break;
                    }
                }
                return stud;
            }
        }
    }
}
