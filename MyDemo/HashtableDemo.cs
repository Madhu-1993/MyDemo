using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemo
{
    internal class HashtableDemo
    {
        static void Main(string[]args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(91, "Ind");
            hashtable.Add(63, "Aus");
            hashtable.Add(1, "Usa");
            hashtable.Remove(1);
            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine($"{item.Key}->{item.Value}");
            }
        }
    }
}
