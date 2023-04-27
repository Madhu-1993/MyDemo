using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemo
{
    internal class DictionarDemo
    {
        static void Main(string[]args)
        {
            Dictionary<int, string> list = new Dictionary<int, string>();
            list.Add(1, "user1");
            list.Add(2, "user2");
            list.Add(3,"user3");
            list.Add(4, "user4");
            foreach(KeyValuePair<int, string> item in list)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }
        }
    }
}
