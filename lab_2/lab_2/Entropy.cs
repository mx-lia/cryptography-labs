using System;
using System.Collections.Generic;

namespace lab_2
{
    public static class Entropy
    {
        public static double CalculateShannonEntropy(string s)
        {
            var map = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (!map.ContainsKey(c))
                {
                    map.Add(c, 1);
                }
                else
                {
                    map[c] += 1;
                }
            }

            int len = s.Length;
            double result = 0D;
            //var frequency_map = new SortedDictionary<char, double>();
            foreach (var item in map)
            {
                var frequency = (double)item.Value / len;
                //frequency_map.Add(item.Key, frequency);
                result -= frequency * Math.Log(frequency, 2);
            }

            //foreach (var item in frequency_map)
            //{
            //    Console.WriteLine($"{item.Key} - {item.Value}");
            //}
            //Console.WriteLine();

            return result;
        }

        public static double GetAmountOfInformation(string s, double entropy)
        {
            double result = s.Length * entropy;
            return result;
        }

        public static double GetAmountOfInformationWithMistake(string s, double entropy, double p)
        {
            double Hyx = -p * Math.Log(p, 2) - (1 - p) * Math.Log(1 - p, 2);
            double result = (entropy - Hyx) * s.Length;
            return result;
        }

        public static double GetAmountOfInformationWithMistake(string s, double p)
        {
            double Hyx = -p * Math.Log(p, 2) - (1 - p) * Math.Log(1 - p, 2);
            double result = (1 - Hyx) * s.Length;
            return result;
        }
    }
}
