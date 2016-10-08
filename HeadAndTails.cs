using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadAndTails
{
    class Program
    {
        static void Main(string[] args)
        {
            var separator = new char[] { ',', ' ' };

            var input = Console.ReadLine()
                .ToLower()
                .Split(separator, StringSplitOptions
                .RemoveEmptyEntries)
                .ToArray();

            var hStreak = 1;
            var tStreak = 1;
            var maxHStreak = 0;
            var maxTStreak = 0;



            for (int i = 1; i < input.Length; i++)
            {
                if (input[i].Equals(input[i - 1]) && input[i].Equals("h"))
                {
                    hStreak++;
                }
                else
                {
                    hStreak = 1;
                }
                if (input[i].Equals(input[i - 1]) && input[i].Equals("t"))
                {
                    tStreak++;
                    hStreak = 1;
                }
                else
                {
                    tStreak = 1;
                }
                if (hStreak >= maxHStreak)
                {
                    maxHStreak = hStreak;
                }
                if (tStreak >= maxTStreak)
                {
                    maxTStreak = tStreak;
                }
            }

            if (maxTStreak == maxHStreak)
            {
                Console.WriteLine("Draw!");
            }
            else if (maxTStreak > maxHStreak)
            {
                Console.WriteLine("T wins!");
            }
            else
            {
                Console.WriteLine("H wins!");
            }

        }

    }
}
