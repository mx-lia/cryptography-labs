using System.Linq;
using System.Text;

namespace lab_4
{
    public static class TrisemusTableClass
    {
        private static char[,] GetTrisemusTable(string key_word, string alphabet)
        {
            key_word = new string(key_word.Distinct().ToArray());
            alphabet = new string(alphabet.Insert(0, key_word).Distinct().ToArray());
            char[,] trisemus_table = new char[8, 4];
            int rows = trisemus_table.GetUpperBound(0) + 1;
            int columns = trisemus_table.Length / rows;
            int k = 0;
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    trisemus_table[i, j] = alphabet[k];
                    k++;
                }
            return trisemus_table;
        }

        private static int?[] GetIndicies(char[,] table, char symbol)
        {
            int rows = table.GetUpperBound(0) + 1;
            int columns = table.Length / rows;
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    if (table[i, j] == symbol)
                        return new int?[] { i, j };
                }
            return null;
        }

        public static string TrisemusTableWithKeyWord(string text, string key_word, string alphabet)
        {
            char[,] trisemus_table = GetTrisemusTable(key_word, alphabet);
            StringBuilder encoded_text = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                int?[] indicies = GetIndicies(trisemus_table, text[i]);
                if (indicies != null && indicies[0].Value != trisemus_table.GetUpperBound(0))
                    encoded_text.Append(trisemus_table[indicies[0].Value + 1, indicies[1].Value]);
                else if (indicies[0].Value == trisemus_table.GetUpperBound(0))
                    encoded_text.Append(trisemus_table[0, indicies[1].Value]);
            }
            return encoded_text.ToString();
        }

        public static string DecodeTrisemusTable(string encoded_text, string key_word, string alphabet)
        {
            char[,] trisemus_table = GetTrisemusTable(key_word, alphabet);
            StringBuilder decoded_text = new StringBuilder();
            for (int i = 0; i < encoded_text.Length; i++)
            {
                int?[] indicies = GetIndicies(trisemus_table, encoded_text[i]);
                if (indicies != null && indicies[0].Value != 0)
                    decoded_text.Append(trisemus_table[indicies[0].Value - 1, indicies[1].Value]);
                else if (indicies[0].Value == 0)
                    decoded_text.Append(trisemus_table[trisemus_table.GetUpperBound(0), indicies[1].Value]);
            }
            return decoded_text.ToString();
        }
    }
}
