using System;
using System.Collections;


namespace MyDemo
{
    public class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public override string ToString()
        {
            return $"{Id},{Name}";
        }
    }
    internal class ArrayListDemo
    {
        static void Main(string[]args)
        {
            int[] arr = new int[] { 1, 2, 3 };
            Emp emp = new Emp { Id = 1, Name = "Madhuri" };
            ArrayList List= new ArrayList();
            List.Add(10);
            List.Add("Hello");
            List.Add(67.77);
            List.Add(emp);
            //List.Insert(1.15);
            //List.AddRnge(arr);
            //Console.WriteLine("count is"+List.Count);
            //Console.WriteLine($"Count of ArrayLimst{ List.Count}");
            ////List.Remove("Hello);
            ////List.RemoveAt(3);
            //List.RemoveRange();
            //Console.WriteLine($"cunt of ArraylIst{List.Count}");
            ////int x=List[0];
            ////double d=Convert.ToDouble(List[2]); //explicit unboxing
              foreach(var item in List)
            {
                Console.Write(item);
            }
        }
           
    }
}
