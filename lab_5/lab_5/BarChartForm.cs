using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_5
{
    public partial class BarChartForm : Form
    {
        public BarChartForm(string originalText, string newText)
        {
            InitializeComponent();

            foreach (var item in Helper.GetFrequencyMap(originalText))
            {
                originalTextChart.Series["Alphabet"].Points.AddXY(item.Key.ToString(), item.Value);
            }

            foreach (var item in Helper.GetFrequencyMap(newText))
            {
                newTextChart.Series["Alphabet"].Points.AddXY(item.Key.ToString(), item.Value);
            }
        }
    }
}
