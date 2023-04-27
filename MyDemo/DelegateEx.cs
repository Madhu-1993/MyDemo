using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemo
{
    public delegate void delegatemethod();
    public class Message
    {
        public static void display()
        {
            Console.WriteLine("Hello");
        }
        public static void show()
        {
            Console.WriteLine("Hii");
        }
        public void print()
        {
            Console.WriteLine("print");
        }
    }
    internal class DelegateEx
    {
        static void Main(string[] args)
        {
            Message msg=new Message();
            delegatemethod del1 = new delegatemethod(msg.display);
            del1 += new delegatemethod(msg.show);
            del1 += new delegatemethod(msg.print);

            Delegate[] list = del1.GetInvocationList();
            foreach(Delegate item in list)
            {
                Console.WriteLine(item.Method);
                Console.WriteLine(item.DynamicInvoke);
            }
        }
    }
}
