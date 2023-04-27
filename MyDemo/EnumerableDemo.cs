using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemo
{
    internal class EnumerableDemo
    {
        public class Player
        {
            private string name;
            private int runs;
            public Player(string name, int runs)
            {
                this.name = name;
                this.runs = runs;
            }
            public override string ToString()
            {
                return $"{name}-{runs}";
            }
        }
        public class Team:IEnumerable
        {
            private Player[] players;
            public Team()
            {
                players = new Player[3];
                players[0] = new Player("Rohit", 4000);
                players[1] = new Player("Virat", 5000);
                players[2] = new Player("Dhoni", 6000);
            }
            public IEnumerator GetEnumerator()
            {
                return players.GetEnumerator();
            }
        }
        public class Program
        {
            static void Main(string[]args)
            {
                Team team = new Team();
                foreach(Player p in team)
                {
                    Console.WriteLine(p);
                }
                int[] arr = new int[] { 1, 2, 3, 4, 5 };
                ArrayList alist = new ArrayList() { 1, 2, 3, 4, 5 };
                List<int> list = new List<int>() { 1,2,3,4,5};
                for(int i=0;i<list.Count;i++)
                {
                    Console.WriteLine(list[i]);
                }
                foreach (int item in arr)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
