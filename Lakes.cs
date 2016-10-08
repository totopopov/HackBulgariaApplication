using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lakes
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().ToCharArray();
            var depth = 0;
            var volume = 0;

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'd':
                        depth++;
                        if (depth > 0)
                        {
                            volume += ((depth - 1) * 1000 + 500);
                        }
                        break;
                    case 'h':
                        if (depth > 0)
                        {
                            volume += ((depth) * 1000);
                        }
                        break;
                    case 'u':
                        ;
                        depth--;
                        if (depth >= 0)
                        {
                            volume += ((depth) * 1000 + 500);
                        }

                        break;
                }
            }

            Console.WriteLine(volume);


        }
    }
}
