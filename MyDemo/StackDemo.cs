using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemo
{
    internal class StackDemo
    {
        static void Main(String[] args)
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);

            stack.Pop();
            Console.WriteLine($"Top element on the stack {stack.Peek()}");
            //Console.WriteLine($"elements on the stack {stack.Count()}");

            foreach(object i in stack )
            {
                Console.WriteLine(i);
            }
        }
    }
}
