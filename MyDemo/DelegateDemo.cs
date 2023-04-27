using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemo
{
    public delegate string UpperCaseDelegate(string s);

    public class Uppercase
    {
        public string Upper(string s)
        {
            Console.WriteLine("enter string to connect uppercase");
            s = Console.ReadLine();
            string s1 = s.ToUpper();
            return s1;
        }
        public string Lower(string s)
        {
            Console.WriteLine("enter string to convert lowercase");
            s= Console.ReadLine();
            string s2 = s.ToLower();
            return s2;
        }
    }
    internal class DelegateDemo
    {
        static void Main(string[] args)
        {
            Uppercase up = new Uppercase();
            UpperCaseDelegate del = new UpperCaseDelegate(up.Upper);
            del += new UpperCaseDelegate(up.Lower);
            Delegate[] list = del.GetInvocationList();
            foreach (Delegate d in list)
            {
                Console.WriteLine(d.DynamicInvoke("Madhuri"));
            }
        }
    }
}
