using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MyDemo
{
    internal class HashSetDemo2
    {
        static void Main(string[]args)
        {
            //does not allow duplicate values
            //to perform maths calcultn like union,intersect,Except
            HashSet<int> set1 = new HashSet<int>() { 1, 2, 3, 4, 5 };
            HashSet<int> set2 = new HashSet<int> { 1, 2, 3, };

            //set1.UnionWith(set2);-->combine the result & give unique values
            //set1.ExceptWith(set2);-->common values from both the set

            set1.ExceptWith(set2);    //-->Common values from both the set
            foreach(int item in set1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
