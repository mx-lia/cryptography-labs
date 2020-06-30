using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace lab_5
{
    public partial class RouteShuffleCode : Form
    {
        private string text;
        private string newText;
        private string action = "encode";

        public RouteShuffleCode()
        {
            InitializeComponent();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                text = File.ReadAllText(openFileDialog1.FileName, Encoding.UTF8).ToLower();
               //text = Regex.Replace(File.ReadAllText(openFileDialog1.FileName, Encoding.UTF8).ToLower(), @"[^абвгдеёжзійклмнопрстуўфхцчшыьэюя]", "");
                fileName.Text = openFileDialog1.FileName;
                executeButton.Enabled = true;
            }
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            switch (action)
            {
                case "encode":
                    {
                        TextInfo.Text = "Start ENCODING text via ROUTE SHUFFLE CODE\n";
                        stopwatch.Start();
                        newText = RouteShuffleCodeClass.EncodeRouteShuffleCode(text);
                        stopwatch.Stop();
                        TextInfo.Text += $"Stop ENCODING text via ROUTE SHUFFLE CODE\nExecution time = {stopwatch.ElapsedMilliseconds} ms\n";
                    }
                    break;
                case "decode":
                    {
                        TextInfo.Text = "Start DECODING text via ROUTE SHUFFLE CODE\n";
                        stopwatch.Start();
                        newText = RouteShuffleCodeClass.DecodeRouteShuffleCode(text);
                        stopwatch.Stop();
                        TextInfo.Text += $"Stop DECODING text via ROUTE SHUFFLE CODE\nExecution time = {stopwatch.ElapsedMilliseconds} ms\n";
                    } break;
            }
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Helper.WriteDataToFile(newText, saveFileDialog1.FileName);
            }
            chartButton.Enabled = true;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                action = radioButton.Text;
            }
        }

        private void chartButton_Click(object sender, EventArgs e) => new BarChartForm(text, newText).ShowDialog();

        private void gotoButton_Click(object sender, EventArgs e)
        {
            MultipleShuffleCode child = new MultipleShuffleCode();
            child.FormClosed += new FormClosedEventHandler(child_FormClosed);
            child.Show();
            this.Hide();
        }

        void child_FormClosed(object sender, FormClosedEventArgs e) => this.Close();
    }
}
