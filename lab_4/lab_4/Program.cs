using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_4
{
    static class Program
    {
        public static string Text { get; set; }
        public static string Alphabet { get; set; } = "абвгдеёжзійклмнопрстуўфхцчшыьэюя";
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (StreamReader reader = new StreamReader("kazka.txt", Encoding.Default))
            {
                Text = Regex.Replace(reader.ReadToEnd().ToLower(), @"[^абвгдеёжзійклмнопрстуўфхцчшыьэюя]", "");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CeasarCode(Text, Alphabet));
            Application.Run(new TrisemusTable(Text, Alphabet));
        }
    }
}
