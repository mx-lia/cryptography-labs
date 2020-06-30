using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_4
{
    public partial class TrisemusTable : Form
    {
        public TrisemusTable(string text, string alphabet)
        {
            InitializeComponent();

            Stopwatch stopwatch = new Stopwatch();

            TextInfo.Text += "Start ENCODING text via TRISEMUS TABLE\n";
            stopwatch.Start();
            string encoded_text = TrisemusTableClass.TrisemusTableWithKeyWord(text, "юлія", alphabet);
            stopwatch.Stop();
            TextInfo.Text += $"Stop ENCODING text via TRISEMUS TABLE\nExecution time = {stopwatch.ElapsedMilliseconds} ms\n";
            Helper.WriteDataToFile(encoded_text, "TrisemusEncodedText.txt");

            TextInfo.Text += "Start DECODING text via TRISEMUS TABLE\n";
            stopwatch.Start();
            string decoded_text = TrisemusTableClass.DecodeTrisemusTable(encoded_text, "юлія", alphabet);
            stopwatch.Stop();
            TextInfo.Text += $"Stop DECODING text via TRISEMUS TABLE\nExecution time = {stopwatch.ElapsedMilliseconds} ms\n";
            Helper.WriteDataToFile(decoded_text, "TrisemusDecodedText.txt");

            foreach (var item in Helper.GetFrequencyMap(decoded_text))
            {
                decoded_chart.Series["Alphabet"].Points.AddXY(item.Key.ToString(), item.Value);
            }
            foreach (var item in Helper.GetFrequencyMap(encoded_text))
            {
                encoded_chart.Series["Alphabet"].Points.AddXY(item.Key.ToString(), item.Value);
            }
        }
    }
}
