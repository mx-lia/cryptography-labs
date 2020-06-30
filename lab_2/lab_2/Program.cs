using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string en_text = "";
            string ru_text = "";

            using (StreamReader reader = new StreamReader("en.txt"))
            {
                en_text = Regex.Replace(reader.ReadToEnd(), @"[^A-Za-z]", "").ToLower();
            }
            using (StreamReader reader = new StreamReader("ru.txt"))
            {
                ru_text = Regex.Replace(reader.ReadToEnd(), @"[^А-Яа-я]", "").ToLower();
            }

            byte[] bytes = Encoding.ASCII.GetBytes(en_text);
            var bits = new BitArray(bytes);
            StringBuilder ASCII = new StringBuilder();
            foreach (bool b in bits)
                ASCII.Append(b ? 1 : 0);

            using (StreamWriter sw = new StreamWriter("bin.txt", false, Encoding.ASCII))
            { sw.Write(ASCII); }

            double ru_entropy = Entropy.CalculateShannonEntropy(ru_text);
            double en_entropy = Entropy.CalculateShannonEntropy(en_text);
            double bin_entropy = Entropy.CalculateShannonEntropy(ASCII.ToString());

            Console.WriteLine($"Entropy of english alphabet = {en_entropy}");
            Console.WriteLine($"Entropy of russian alphabet = {ru_entropy}");
            Console.WriteLine($"Entropy of binary alphabet = {bin_entropy}");

            string ru_name = "максимчиковаюлиясергеевна";
           // ru_entropy = Entropy.CalculateShannonEntropy(ru_name);

            Console.WriteLine($"\nAmount of information in ru_name = {Entropy.GetAmountOfInformation(ru_name, ru_entropy)}");

            Console.WriteLine($"\nWith conditional error probability 0.1 = {Entropy.GetAmountOfInformationWithMistake(ru_name, ru_entropy, 0.1)}");
            Console.WriteLine($"With conditional error probability 0.5 = {Entropy.GetAmountOfInformationWithMistake(ru_name, ru_entropy, 0.5)}");
            Console.WriteLine($"With conditional error probability 1 = {Entropy.GetAmountOfInformation(ru_name, ru_entropy)}");

            bytes = Encoding.ASCII.GetBytes(ru_name);
            ASCII = new StringBuilder();
            bits = new BitArray(bytes);
            foreach (bool b in bits)
                ASCII.Append(b ? 1 : 0);

            //bin_entropy = Entropy.CalculateShannonEntropy(ASCII.ToString());

            Console.WriteLine($"\nAmount of information in ASCII = {Entropy.GetAmountOfInformation(ASCII.ToString(), 1)}");

            Console.WriteLine($"\nWith conditional error probability 0.1 = {Entropy.GetAmountOfInformationWithMistake(ASCII.ToString(), 0.1)}");
            Console.WriteLine($"With conditional error probability 0.5 = {Entropy.GetAmountOfInformationWithMistake(ASCII.ToString(), 0.5)}");
            Console.WriteLine($"With conditional error probability 1 = {Entropy.GetAmountOfInformation(ASCII.ToString(), 1)}");

            Console.ReadKey();
        }
    }
}
