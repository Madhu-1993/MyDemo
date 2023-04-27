//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MyDemo
//{
//    internal class SampleClass
//    {
//        //Model class /Entity class 
//        public int Id { get; set; }
//        public string Name { get; set; }

//        public int Price { get; set; }
//    }
//    public class ProductCRUD
//    {
//        private List<Product> Products;

//        public ProductCRUD()
//        {
//            Products = new List<Product>();
//        }
//    }
//    public void AddProduct(Product prod)
//    {
        
//        Products.Add(prod);
//    }
//    public void UpdateProduct(Product prod)
//    {
//        foreach(Product p in Products)
//        {
//            if(p.Id==prod.Id)
//            {
//                p.Name = prod.Name;
//                p.Price = prod.Price;
//            }
//        }
//    }
//    public void DeleteProduct(int id)
//    {
//        foreach(Product p in Products)
//        {
//            if(p.Id==id)
//            {
//                Products.Remove(p);
//                break;
//            }
//        }
//    }
//    public List<Product>GetProducts()
//    {
//        return Products;
//    }
//    public Product GetProductById(int Id)
//    {
//        Product prod = new Product();
//        foreach(Product p in Products)
//        {
//            if(p.Id==Id)
//            {
//                prod = p;
//                break;
//            }
//        }
//        return prod;
//    }
//}
