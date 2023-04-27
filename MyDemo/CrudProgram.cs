//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MyDemo
//{
//    internal class CrudProgram
//    {
//        static void Main(String[] args)
//        {
//            ProductCRUD cRUD=new ProductCRUD();
//            int option = 0;
//            do
//            {
//                Console.WriteLine("1.Add Product");
//                Console.WriteLine("2,Update Product");
//                Console.WriteLine("3,Delete Product");
//                Console.WriteLine("4,View All");
//                Console.WriteLine("5,View by Id");
//                Console.WriteLine("6,Price less than 1000");
//                int choice = Convert.ToInt32(Console.ReadLine());

//                switch (choice)
//                {
//                    case 1:
//                        Product p = new Product();
//                        Console.WriteLine("Enter the Id");
//                        p.Id = Convert.ToInt32(Console.ReadLine());
//                        Console.WriteLine("Enter the Name");
//                        p.Name = Console.ReadLine();
//                        Console.WriteLine("Enter the price");
//                        p.Price = Convert.ToInt32(Console.ReadLine());
//                        cRUD.AddProduct(p);
//                        break;
//                    case 2:
//                        Product p1 = new Product();
//                        Console.WriteLine("Enter the Id");
//                        p1.Id = Convert.ToInt32(Console.ReadLine());
//                        Console.WriteLine("Enter Price");
//                        Console.WriteLine("Enter the Name");
//                        p1.Name =Console.ReadLine();
//                        cRUD.UpdateProduct(p1);
//                        break;
//                    case 3:
//                        Console.WriteLine("Enter the Id");
//                        int id = Convert.ToInt32(Console.ReadLine());
//                        cRUD.DeleteProduct(id);
//                        break;
//                    case 4:
//                        List<Product> list = cRUD.GetProducts();
//                        Console.WriteLine("Id\t name \t Price");
//                        foreach (Product item in list)
//                        {
//                            Console.WriteLine($"{item.Name}\t{item.Price}");
//                        }
//                        break;
//                    case 5:
//                        Console.WriteLine("Enter Id");
//                        int id2 = Convert.ToInt32(Console.ReadLine());
//                        Product item2 = cRUD.GetProductById(id2);
//                        Console.WriteLine("Id \t name \t price");
//                        Console.WriteLine($"{item2.Id} \t {item2.Name} \t {item2.Price}");
//                        break;
//                    default:
//                        Console.WriteLine("No option available");
//                        break;
//                }
//                Console.WriteLine("Do you want to continue");
//                option = Convert.ToInt32(Console.ReadLine());
//            }
//            while (option == 1);
//        }
//    }
//}
