using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemo
{
    public delegate void MyDelegate();
    public class Student
    {
        public event MyDelegate Fail;
        public event MyDelegate Pass;
        public void AcceptMarks(int marks)
        {
            if(marks<40)
            {
                Fail();
            }
            else
            {
                Pass();
            }
        }
    }
    public class Program
    {
        static void Message()
        {
            Console.WriteLine("Sorry! you are fail..!");
        }
        static void Success()
        {
            Console.WriteLine("Great! You are Pass..!");
        }


        internal class EventDemo
        {
            static void Main(string[] args)
            {
                Student stud = new Student();
                stud.Fail += new MyDelegate(Message);
                stud.Pass += new MyDelegate(Success);
                stud.AcceptMarks(30);
            }
        }
    }
}
