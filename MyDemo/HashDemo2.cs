using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemo
{
    internal class HashDemo2
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(9372854111, "Jw");
            hashtable.Add(9689448262, "Madhuri");
            hashtable.Add(9850509334, "Jw2");
            hashtable.Add(8087147282, "Nitin");
            hashtable.Add(6785490841, "Ayush");

            foreach(DictionaryEntry item in hashtable)
            {
                Console.WriteLine($"{item.Key}->{item.Value}");
            } 
        }
    }
}
