using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace StringsAndNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var decoded = new List<string>();

            var inputArray = input.ToList();



            var decoderHelp = new Dictionary<char, int>();
            var decoderOrdered = new Dictionary<char, int>();

            var decoder = new Dictionary<char, int>();

            var counter=9;

            for (int i = 0; i < inputArray.Count; i++)
            {
                if (decoderHelp.ContainsKey(inputArray[i]))
                {
                    decoderHelp[inputArray[i]]++;
                }
                else
                {
                    decoderHelp[inputArray[i]]=1;
                }

            }

            decoderOrdered=decoderHelp.OrderByDescending(w => w.Value).ToDictionary(w => w.Key, w => w.Value);


            foreach (var itempair in decoderOrdered)
            {
                decoder[itempair.Key] = counter;
                counter--;
                if (counter==-1)
                {
                    break;
                }
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (decoder.ContainsKey(input[i]))
                {
                    decoded.Add(Convert.ToString(decoder[input[i]]));
                }
                else
                {
                    decoded.Add(Convert.ToString(' '));
                }
            }

            var decodedVersion = string.Concat(decoded);

            decodedVersion=decodedVersion.Trim();

            var Output = decodedVersion.Split((default(string[])), StringSplitOptions.RemoveEmptyEntries)
                .Select(BigInteger.Parse)
                .ToArray();


            BigInteger outputNumber = 0;

            for (int i = 0; i < Output.Length; i++)
            {
                outputNumber += Output[i];
            }

            Console.WriteLine(outputNumber);



            //var charachters = inputArray.Distinct().ToArray();
            //var count = 0;
            //for (int i = 0; i < charachters.Length; i++)
            //{
            //    for (int j = 0; j < inputArray.Count; j++)
            //    {
            //        if (charachters[i].Equals(inputArray[j]))
            //        {
            //            count++;
            //        }
            //
            //        decoder.Add(charachters[i], count);
            //        count = 0;
            //    }
            //}



        }
    }
}
