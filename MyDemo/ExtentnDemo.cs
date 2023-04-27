using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemo
{
    internal class ExtentnDemo
    {
        public class Calc
        {
            public int Add(int a, int b)
            {
                return a + b;
            }
            public int Sub(int a, int b)
            {
                return a - b;
            }
        }
        //extension method
        public static class Test   //static class
        {
            //static method
            //parameter will be the ref of the class

            //public static int Multiply(this Calc c, int x, int y)
            //{
            //    return x * y;
            //}
        }
        public class Program
        {
            static void Main(string[] args)
            {
                Calc calc = new Calc();
                Console.WriteLine(calc.Add(45, 67));
                Console.WriteLine(calc.Sub(45, 23));
               // Console.WriteLine(calc.Multiply(12, 67));

            }
        }
    }
}
