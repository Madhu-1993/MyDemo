using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemo
{
    internal class HashSetDemo
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();
            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(1); //duplicate vlaues are not allowed in hashset

            foreach(int i in set)
            {
                Console.WriteLine(i);
            }
        }
    }
}
