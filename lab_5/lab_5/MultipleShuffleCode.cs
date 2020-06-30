using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace lab_5
{
    public partial class MultipleShuffleCode : Form
    {
        private string text;
        private string newText;
        private string action = "encode";

        public MultipleShuffleCode()
        {
            InitializeComponent();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                text = File.ReadAllText(openFileDialog1.FileName, Encoding.UTF8).ToLower();
                fileName.Text = openFileDialog1.FileName;
            }
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            switch (action)
            {
                case "encode":
                    {
                        //text = Regex.Replace(text, @"[^абвгдеёжзійклмнопрстуўфхцчшыьэюя]", "");
                        TextInfo.Text = "Start ENCODING text via MULTIPLE SHUFFLE CODE\n";
                        stopwatch.Start();
                        newText = MultipleShiffleCodeClass.EncodeMultipleShuffleCode(text, keyWord1.Text, keyWord2.Text);
                        stopwatch.Stop();
                        TextInfo.Text += $"Stop ENCODING text via MULTIPLE SHUFFLE CODE\nExecution time = {stopwatch.ElapsedMilliseconds} ms\n";
                    }
                    break;
                case "decode":
                    {
                        TextInfo.Text = "Start DECODING text via MULTIPLE SHUFFLE CODE\n";
                        stopwatch.Start();
                        newText = MultipleShiffleCodeClass.DecodeMultipleShuffleCode(text, keyWord1.Text, keyWord2.Text);
                        stopwatch.Stop();
                        TextInfo.Text += $"Stop DECODING text via MULTIPLE SHUFFLE CODE\nExecution time = {stopwatch.ElapsedMilliseconds} ms\n";
                    }
                    break;
            }
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Helper.WriteDataToFile(newText, saveFileDialog1.FileName);
            }
            chartButton.Enabled = text != "" && newText != "";
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
            RouteShuffleCode child = new RouteShuffleCode();
            child.FormClosed += new FormClosedEventHandler(child_FormClosed);
            child.Show();
            this.Hide();
        }

        void child_FormClosed(object sender, FormClosedEventArgs e) => this.Close();

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            executeButton.Enabled = keyWord1.Text != "" && keyWord2.Text != "" && text != "";
        }
    }
}
