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
using System.Windows.Forms.DataVisualization.Charting;

namespace lab_4
{
    public partial class CeasarCode : Form
    {
        public CeasarCode(string text, string alphabet)
        {
            InitializeComponent();

            Stopwatch stopwatch = new Stopwatch();

            TextInfo.Text += "Start ENCODING text via CEASAR CODE\n";
            stopwatch.Start();
            string encoded_text = CeasarCodeClass.CeasarCodeWithKeyWord(text, 2, "інфарматыка", alphabet);
            stopwatch.Stop();
            TextInfo.Text += $"Stop ENCODING text via CEASAR CODE\nExecution time = {stopwatch.ElapsedMilliseconds} ms\n";
            Helper.WriteDataToFile(encoded_text, "CeasarEncodedText.txt");

            TextInfo.Text += "Start DECODING text via CEASAR CODE\n";
            stopwatch.Start();
            string decoded_text = CeasarCodeClass.DecodeCeasarCode(encoded_text, 2, "інфарматыка", alphabet);
            stopwatch.Stop();
            TextInfo.Text += $"Stop DECODING text via CEASAR CODE\nExecution time = {stopwatch.ElapsedMilliseconds} ms\n";
            Helper.WriteDataToFile(decoded_text, "CeasarDecodedText.txt");

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
