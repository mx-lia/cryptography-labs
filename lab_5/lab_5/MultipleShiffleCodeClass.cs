using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace lab_5
{
    class MultipleShiffleCodeClass
    {
        private static int[] CalculateSizeOfTable(string text, string columnKeyWord, string rowKeyWord)
        {
            int mul = columnKeyWord.Length * rowKeyWord.Length;
            int coef = (int)Math.Ceiling(Math.Sqrt(Math.Ceiling((double)text.Length / mul)));
            int rows = rowKeyWord.Length * coef;
            int columns = columnKeyWord.Length * coef;
            while (true)
            {
                int diff = rows * columns - text.Length;
                if (diff > 0 && diff > columns)
                    rows--;
                else
                    break;
            }
            return new int[] { rows, columns };
        }

        private static int[] GetKeyIndicies(string keyWord, int length)
        {
            string alphabet = "абвгдеёжзійклмнопрстуўфхцчшыьэюя";

            int?[] keyArray = new int?[length];
            for (int i = 0, k = 0; i < keyArray.Length; i++, k++)
            {
                if (k == keyWord.Length)
                    k = 0;
                keyArray[i] = alphabet.IndexOf(keyWord[k]);
            }

            int[] keyIndicies = new int[length];
            for (int i = 0; i < keyArray.Length; i++)
            {
                int index = Array.IndexOf(keyArray, keyArray.Min());
                keyIndicies[index] = i;
                keyArray[index] = null;
            }

            return keyIndicies;
        }

        private static char[,] FillTable(string text, int columns, int rows, bool reverse = false)
        {
            char[,] originalTable = new char[rows, columns];
            if (reverse) 
            {
                int temp = rows;
                rows = columns;
                columns = temp;
            }
            for (int i = 0, k = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++, k++)
                {
                    if (k < text.Length)
                        originalTable[reverse ? j : i, reverse ? i : j] = text[k];
                    else
                        originalTable[reverse ? j : i, reverse ? i : j] = '&';
                }
            }
            return originalTable;
        }

        public static char[,] GetTableForEncryption(string text, string columnKeyWord, string rowKeyWord)
        {
            int[] tableSize = CalculateSizeOfTable(text, columnKeyWord, rowKeyWord);
            int rows = tableSize[0], columns = tableSize[1];
            int[] columnKeyIndicies = GetKeyIndicies(columnKeyWord, columns);
            int[] rowKeyIndicies = GetKeyIndicies(rowKeyWord, rows);
            char[,] originalTable = FillTable(text, columns, rows);
            char[,] table = new char[rows, columns];

            for (int i = 0, k = 0; i < rowKeyIndicies.Length && k < text.Length; i++)
            {
                for (int j = 0; j < columnKeyIndicies.Length; j++, k++)
                {
                    int rowNumber = Array.IndexOf(rowKeyIndicies, i);
                    int columnNumber = Array.IndexOf(columnKeyIndicies, j);
                    table[i, j] = originalTable[rowNumber, columnNumber];
                }
            }

            return table;
        }


        private static char[,] GetTableForDecryption(string text, string columnKeyWord, string rowKeyWord)
        {
            string editedText = Regex.Replace(text, @"&", "");
            int[] tableSize = CalculateSizeOfTable(editedText, columnKeyWord, rowKeyWord);
            int rows = tableSize[0], columns = tableSize[1];
            int[] columnKeyIndicies = GetKeyIndicies(columnKeyWord, columns);
            int[] rowKeyIndicies = GetKeyIndicies(rowKeyWord, rows);
            char[,] originalTable = FillTable(text, columns, rows, true);
            char[,] table = new char[rows, columns];

            for (int i = 0, k = 0; i < rowKeyIndicies.Length && k < text.Length; i++)
            {
                for (int j = 0; j < columnKeyIndicies.Length; j++, k++)
                {
                    int rowNumber = rowKeyIndicies[i];
                    int columnNumber = columnKeyIndicies[j];
                    table[i, j] = originalTable[rowNumber, columnNumber];
                }
            }

            return table;
        }

        public static string EncodeMultipleShuffleCode(string text, string columnKeyWord, string rowKeyWord)
        {
            char[,] table = GetTableForEncryption(text, columnKeyWord, rowKeyWord);
            StringBuilder encodedText = new StringBuilder();
            for (int j = 0; j < table.GetUpperBound(1) + 1; j++)
            {
                for (int i = 0; i < table.GetUpperBound(0) + 1; i++)
                {
                    encodedText.Append(table[i, j]);
                }
            }
            return encodedText.ToString();
        }

        public static string DecodeMultipleShuffleCode(string encodedText, string columnKeyWord, string rowKeyWord)
        {
            char[,] table = GetTableForDecryption(encodedText, columnKeyWord, rowKeyWord);
            StringBuilder decodedText = new StringBuilder();
            for (int i = 0; i < table.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < table.GetUpperBound(1) + 1; j++)
                {
                    decodedText.Append(table[i, j]);
                }
                Console.WriteLine();
            }
            return decodedText.ToString();
        }
    }
}
