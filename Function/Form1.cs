using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Function
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double a = -10, b = 10, h = 0.1, x, y;
            this.chart1.Series[0].Points.Clear();
            x = a;
            while (x <= b)
            {
                y = Math.Sin(x);
                this.chart1.Series[0].Points.AddXY(x, y);
                x += h;
            }
        }

        private void CheckSinx_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckSinx.Checked)
            {
                double a = double.Parse(aTB.Text);
                double b = double.Parse(bTB.Text);
                double h = double.Parse(stepTB.Text);
                double x, y;
                this.chart1.Series[1].Points.Clear();
                x = a;
                while (x <= b)
                {
                    y = Math.Sin(x);
                    this.chart1.Series[1].Points.AddXY(x, y);
                    x += h;
                }
            }
            else
            {

            }
        }

        private void CheckCosx_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckCosx.Checked)
            {
                double a = double.Parse(aTB.Text);
                double b = double.Parse(bTB.Text);
                double h = double.Parse(stepTB.Text);
                double x, y;
                this.chart1.Series[2].Points.Clear();
                x = a;
                while (x <= b)
                {
                    y = Math.Cos(x);
                    this.chart1.Series[2].Points.AddXY(x, y);
                    x += h;
                }
            }
            else
            {

            }
        }

        private void CheckSum_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckSum.Checked)
            {
                double a = double.Parse(aTB.Text);
                double b = double.Parse(bTB.Text);
                double h = double.Parse(stepTB.Text);
                double x, y;
                this.chart1.Series[3].Points.Clear();
                x = a;
                while (x <= b)
                {
                    y = Math.Sin(x)+Math.Cos(x);
                    this.chart1.Series[3].Points.AddXY(x, y);
                    x += h;
                }
            }
            else
            {

            }
        }
    }
}
