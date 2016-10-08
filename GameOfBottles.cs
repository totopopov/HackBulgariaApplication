using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfBottles
{
    class Program
    {
        static void Main(string[] args)
        {

            var bottlesNumber = int.Parse(Console.ReadLine());

            var inputCoordinates = new string[bottlesNumber];

            for (int i = 0; i < inputCoordinates.Length; i++)
            {
                inputCoordinates[i] = Console.ReadLine();
            }

            var distance = new Dictionary<int, int>();

            for (int i = 1; i <= inputCoordinates.Length; i++)
            {
                for (int j = 1; j <= inputCoordinates.Length; j++)
                {
                    if (j != i)
                    {

                        distance[i * 10 + j] = Math.Abs((int)(inputCoordinates[i - 1][0]) - (int)(inputCoordinates[j - 1][0]))
                            + Math.Abs((int)(inputCoordinates[i - 1][2]) - (int)(inputCoordinates[j - 1][2]));
                    }
                }
            }
            var minTotalDistance = int.MaxValue;
            var sumDistance = 0;
            var minCurrentDistance = int.MaxValue;
            var previousPoiner = 0;

            
            

            var pointer = 1;
            var nextPointer = 1;

            for (int i = 1; i <= bottlesNumber; i++)
            {
                pointer = i;
                var passedDirectionPointers = new List<int>();
                
                for (int j = 1; j < bottlesNumber; j++)
                {
                    for (int k = 1; k <= bottlesNumber; k++)
                    {
                        if (k != pointer)
                        {
                            if (distance[pointer * 10 + k] < minCurrentDistance 
                                && k != previousPoiner 
                                && !passedDirectionPointers.Contains(k))
                                
                            {

                                
                                minCurrentDistance = distance[pointer * 10 + k];
                                nextPointer = k;
                                previousPoiner = pointer;
                            }
                        }
                    }
                    
                        passedDirectionPointers.Add(pointer);
                        pointer = nextPointer;
                        sumDistance += minCurrentDistance;
                        minCurrentDistance = int.MaxValue;
                    
                    
                }

                if (sumDistance<minTotalDistance && sumDistance!=0 && sumDistance > 0)
                {
                    minTotalDistance = sumDistance;
                }
                sumDistance = 0;
            }
            Console.WriteLine(minTotalDistance);
        }
    }
}
