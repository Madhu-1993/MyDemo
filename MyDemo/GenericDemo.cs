//using System;
//using System.Collections.Generic;


//namespace MyDemo
//{
//    internal class GenericDemo<T>
//    {
//        private T data;
//        public void Add(T data)
//        {
//            this.data = data;
//        }
//        public T Display()
//        {
//            return data;
//        }
//    }
//    public class Product1
//    {
//        public string Name { get; set; }
//        public int Price { get; set; }

//        public override string ToString()
//        {
//            return $"{Name}->{Price}";

//        }
//        public class Program
//        {
//            static void Main(string[] args)
//            {
//                MyGenericCls<int> obj1 = new MyGenericCls<int>();
//                obj1.Add(10);
//                Console.WriteLine(obj1.Display());

//                MyGenericCls<string> obj2 = new MyGenericCls<string>();
//                obj2.Add("User1");
//                Console.WriteLine(obj2.Display());

//                MyGenericCls<Product> obj3 = new MyGenericCls<Product>();
//                obj3.Add(new Product { Name = "Mouse", Price = 699 });
//                Console.WriteLine(obj3.Display());

//            }
//        }
//    }
//}
