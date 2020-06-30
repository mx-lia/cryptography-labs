using System;
using System.Text;

namespace lab_5
{
    class RouteShuffleCodeClass
    {
        private static char[][] GetTableForEncryption(string text)
        {
            char[][] table = new char[2][];
            table[0] = new char[text.Length / 2];
            table[1] = new char[text.Length - table[0].Length];
            int k = 0;
            for (int i = 0; i < table.Length; i++)
            {
                for (int j = 0; j < table[i].Length && k < text.Length; j++, k++)
                {
                    table[i][j] = text[k];
                }
            }
            return table;
        }

        private static char[][] GetTableForDecryption(string text)
        {
            char[][] table = new char[2][];
            table[0] = new char[text.Length / 2];
            table[1] = new char[text.Length - table[0].Length];
            int k = 0;
            for (int i = 0, j = 0; i < table[j].Length; i++, j = 0)
            {
                for (; j < table.Length; j++, k++)
                {
                    table[j][i] = text[k];
                }
            }
            return table;
        }

        public static string EncodeRouteShuffleCode(string text)
        {
            char[][] table = GetTableForEncryption(text);
            StringBuilder encodedText = new StringBuilder();
            for (int i = 0, k = 0; i < table[k].Length; i++, k = 0)
            {
                for (; k < table.Length; k++)
                {
                    encodedText.Append(table[k][i]);
                }
            }
            return encodedText.ToString();
        }

        public static string DecodeRouteShuffleCode(string encodedText)
        {
            char[][] table = GetTableForDecryption(encodedText);
            StringBuilder decodedText = new StringBuilder();
            for (int i = 0; i < table.Length; i++)
            {
                for (int j = 0; j < table[i].Length; j++)
                {
                    decodedText.Append(table[i][j]);
                }
                Console.WriteLine();
            }
            return decodedText.ToString();
        }
    }
}
