using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemo
{
    internal class JaggedArray
    {
        static void Main(string[]args)
        {
            int[][] jarray = new int[3][];

            jarray[0] = new int[5];
            jarray[1] = new int[3];
            jarray[2] = new int[2];

            for(int i=0;i<jarray.Length;i++)
            {
                for (int j= 0; j < jarray[i].Length;j++)
                {
                    jarray[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }

            foreach (int[]t in jarray)
            {
                foreach(var item in t)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
