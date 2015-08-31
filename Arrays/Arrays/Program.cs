using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.ReverseString();
            prog.DieRoller();

            Console.ReadLine();
        }

        public void ReverseString()
        {
            Console.WriteLine("Reverse String");

            string msg = Console.ReadLine();

            for (int i = 0; i < msg.Length; i++)
            {
                Console.Write(msg[msg.Length - 1 - i]);
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        public void DieRoller()
        {
            Console.WriteLine("Die Roller");

            Random newRandom = new Random();

            int num = 0;
            int[] results = new int[6];
            for (int i = 0; i < 100; i++)
            {
                num = newRandom.Next() % 6;
                results[num]++;
            }

            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("Number {0} occurred {1} times", i, results[i]);
            }

            // since num % 6 = 0 is really 6, I brought this to the end of the list instead of beginning. 
            Console.WriteLine("Number {0} occurred {1} times", 6, results[0]);
        }
    }
}
