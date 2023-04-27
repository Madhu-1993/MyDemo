using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemo
{
    //Assignment:
    //   Create class Product with name & price,
    //Compare between two product prices & display the result ,
    //using IComparable & IComparer interface

    internal class ComprblComparer
    {
        public class Product : IComparable<Product>
        {
            private string pname;
            private int price;

            public string Pname
            {
                get
                {
                    return pname;
                }
            }
            public int Price
            {
                get
                {
                    return price;
                }

            }
            public Product(string pname, int price)
            {
                this.pname = pname;
                this.price = price;
            }

            public int CompareTo(Product other)
            {
                if (this.price < other.price)
                {
                    return -1;
                }
                else if(this.price> other.price)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            public override string ToString()
            {
                return $"{pname}-{price}";
            }
        }
        public class Test:IComparer<Product>
        {
            public int Compare(Product x,Product y) 
            {
                if(x.Price<y.Price)
                {
                    return -1;
                }
                else if(x.Price>y.Price) 
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
        static void Main(string[]args)
        {
            Product Mobile = new Product("Moto", 7000);
            Product Headphone = new Product("Rockerz", 1999);
            Product Laptop = new Product("Lenovo", 30000);
            Test test = new Test();
            int result = test.Compare(Mobile, Laptop);
            test.Compare(Mobile, Headphone);
            Mobile.CompareTo(Headphone);

            if (result==1)
            {
                Console.WriteLine("Mobile is costly than Headphone ");
            }
            else if(result==-1)
            {
                Console.WriteLine("Headphone is costly than mobile");
            }
            else
            {
                Console.WriteLine("Both are same in price");
            }
        }
    }
}



