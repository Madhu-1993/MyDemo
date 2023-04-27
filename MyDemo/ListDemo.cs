using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyDemo
{
    internal class ListDemo
    {
        static void Main(string[] args)
        {
            List<Product> produtlist = new List<Product>()
            {
                //new Product{Name="Pen",Price=10},
              // new Product(Name="Pencil",Price=12)
            };

            foreach (Product item in produtlist)
            {
              //  Console.WriteLine(item.Name + " " + item.Price);
            }
            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5 };
            foreach (int item in list1)
            {
                Console.WriteLine(item);
            }
            List<string> list2 = new List<string>() { "user1", "user2" };
            foreach (string item in list2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
