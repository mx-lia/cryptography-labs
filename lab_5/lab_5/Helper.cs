using System.Collections.Generic;
using System.IO;

namespace lab_5
{
    class Helper
    {
        public static SortedDictionary<char, double> GetFrequencyMap(string text)
        {
            var map = new Dictionary<char, int>();
            foreach (char c in text)
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
            int len = text.Length;
            var frequency_map = new SortedDictionary<char, double>();
            foreach (var item in map)
            {
                var frequency = (double)item.Value / len;
                frequency_map.Add(item.Key, frequency);
            }

            //foreach (var item in frequency_map)
            //{
            //    Console.WriteLine($"{item.Key} - {item.Value}");
            //}
            //Console.WriteLine();
            return frequency_map;
        }

        public async static void WriteDataToFile(string text, string filepath)
        {
            using (StreamWriter writer = new StreamWriter(filepath, false))
            {
                await writer.WriteAsync(text);
            }
        }
    }
}
