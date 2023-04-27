using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MyDemo
{
    public delegate int AddSum(int a,int b);
    public class Calc
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
    }
    internal class DelegateDemo2
    {
        static void Main(string[]args)
        {
            Calc calc = new Calc();
            AddSum addSum = new AddSum(calc.Add);
            Console.WriteLine(addSum.Invoke(10,20));
        }
    }
}
