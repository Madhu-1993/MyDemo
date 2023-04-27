using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemo
{
    public class Emp1
    {
        public int Id {get; set;}
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Id}-> {Name}";
        }
    }

    public class ArrList2
    {
        static void Main(string[] args)
        {
            Emp1 e1 = new Emp1 { Id = 1, Name = "Ankit" };
            Emp1 e2 = new Emp1 { Id = 2, Name = "Dhruv" };

            ArrayList List = new ArrayList();
            List.Add(e1);
            List.Add(e2);

            //or

            ArrayList List2 = new ArrayList()
            {
                new Emp1 {Id=1,Name="Mayur"},
                new Emp1 { Id = 2, Name = "Ayushi" }
        };
        }
    }
}
