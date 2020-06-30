using System.Linq;
using System.Text;

namespace lab_4
{
    public static class CeasarCodeClass
    {
        private static string GetNewAlphabet(int position, string key_word, string alphabet)
        {
            key_word = new string(key_word.Distinct().ToArray());
            char[] new_alphabet = new char[alphabet.Length];
            for (int i = position, k = 0; k < key_word.Length; i++, k++)
            {
                new_alphabet[i] = key_word[k];
            }
            for (int i = 0, k = position + key_word.Length; i < alphabet.Length; i++)
            {
                if (!new_alphabet.Contains(alphabet[i]))
                {
                    if (k >= new_alphabet.Length)
                        k = 0;
                    new_alphabet[k] = alphabet[i];
                    k++;
                }
            }
            return new string(new_alphabet);
        }

        public static string CeasarCodeWithKeyWord(string text, int position, string key_word, string alphabet)
        {
            string new_alphabet = GetNewAlphabet(position, key_word, alphabet);
            StringBuilder encoded_text = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                encoded_text.Append(new_alphabet[alphabet.IndexOf(text[i])]);
            }
            return encoded_text.ToString();
        }

        public static string DecodeCeasarCode(string encoded_text, int position, string key_word, string alphabet)
        {
            string new_alphabet = GetNewAlphabet(position, key_word, alphabet);
            StringBuilder decoded_text = new StringBuilder();
            for (int i = 0; i < encoded_text.Length; i++)
            {
                decoded_text.Append(alphabet[new_alphabet.IndexOf(encoded_text[i])]);
            }
            return decoded_text.ToString();
        }
    }
}
