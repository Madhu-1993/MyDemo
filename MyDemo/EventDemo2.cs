using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemo
{
    public delegate void Account();
    public class Bank
    {
        private double balance;
        public event MyDelegate insufficient;
        public event MyDelegate lowbalance;

        public Bank()
        {
            balance = 10000;
        }
        public void Credit(double amt)
        {
            balance += amt;
        }
        public void Debit(double amt)
        {
            if(amt>balance)
            {
                insufficient();
            }
            else
            {
                balance -= amt;
                if(balance<3000)
                {
                    lowbalance();
                }
            }
        }
        public override string ToString()
        {
            return $"Current balance is{balance}";
        }
    }
    internal class EventDemo2
    {
        static void Msg1()
        {
            Console.WriteLine("Can not withdraw the ");
        }
        static void Msg2()
        {
            Console.WriteLine("Current balance is less then 3000");
        }
        static void Main(string[]args)
        {
            Bank bk = new Bank();
            bk.insufficient += new MyDelegate(Msg1);
            bk.lowbalance += new MyDelegate(Msg2);
            Console.WriteLine(bk);
            bk.Credit(2000);
            Console.WriteLine(bk);
            bk.Debit(11000);
            Console.WriteLine(bk);
        }
    }
}
