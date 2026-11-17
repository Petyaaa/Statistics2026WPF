using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Statistics2026WPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnchart_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            var number = txtNumbers.Text.Split(' ').Select(n => double.Parse(n)).ToArray();
            chart1.Series.Add("Numbers");
            chart1.Series["Numbers"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            foreach (var n in number)
            {
                chart1.Series["Numbers"].Points.AddXY(n, n);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            var numbers = txtNumbers.Text.Split(' ').Select(double.Parse).ToList();
            var average = numbers.Average();
            lblOutput.Text = "Answer: " + average;
        }

        private void btnpie_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            var number = txtNumbers.Text.Split(' ').Select(n => double.Parse(n)).ToArray();
            chart1.Series.Add("Numbers");
            chart1.Series["Numbers"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            foreach (var n in number)
            {
                chart1.Series["Numbers"].Points.AddXY(n, n);
            }

        }
        

        private void btnline_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            var number = txtNumbers.Text.Split(' ').Select(n => double.Parse(n)).ToArray();
            chart1.Series.Add("Numbers");
            chart1.Series["Numbers"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            foreach (var n in number)
            {
                chart1.Series["Numbers"].Points.AddXY(n, n);
            }

        }
        

        private void txtNumbers_TextChanged(object sender, EventArgs e)
        {
            int numbers = txtNumbers.Text.Split(' ').Length;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMedian_Click(object sender, EventArgs e)
        {
            var numbers = txtNumbers.Text.Split(' ').Select(double.Parse).ToList();
            numbers.Sort();
            double median;
            int count = numbers.Count;
            if (count % 2 == 0)
            {
                median = (numbers[count / 2 - 1] + numbers[count / 2]) / 2;
            }
            else
            {
                median = numbers[count / 2];
            }
            lblOutput.Text = "Answer: " + median;
        }

        private void btbMode_Click(object sender, EventArgs e)
        {
            var numbers = txtNumbers.Text.Split(' ').Select(double.Parse).ToList();

 int maxCount = numbers.GroupBy(n => n).Max(g => g.Count());

 var modes = numbers.GroupBy(n => n)
     .Where(g => g.Count() == maxCount)
     .Select(g => g.Key)
     .ToList();

 lblOutput.Text = "Answer: " + string.Join(", ", modes);
        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
