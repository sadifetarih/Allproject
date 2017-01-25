using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SadifePrj4
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            double Ri = 0;
            double xi = 0;
            int a = Convert.ToInt32(numericA.Value);
            double x0 = Convert.ToDouble(numericXo.Text);
            int c = Convert.ToInt32(numericC.Value);
            int m = Convert.ToInt32(numericM.Value);

            for (int i = 1; i <= numericRandom.Value; i++)
            {
                xi = (a * x0 + c) % m;
                Ri = (double)xi / Convert.ToInt32(numericM.Value);
                x0 = xi;
                listView1.Items.Add(Ri.ToString());
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.chart1.Series["Ri"].Points.AddXY(result);
            int counter = 0;
            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;
            int counter5 = 0;
            int counter6 = 0;
            int counter7 = 0;
            int counter8 = 0;
            int counter9 = 0;
            int counter10 = 0;
            int counter11 = 0;
            int counter12 = 0;
            int counter13 = 0;
            int counter14 = 0;
            int counter15 = 0;
            int counter16 = 0;
            int counter17 = 0;
            int counter18 = 0;
            int counter19 = 0;

            this.chart1.ChartAreas["ChartArea1"].AxisX.Minimum = 0;
            this.chart1.ChartAreas["ChartArea1"].AxisX.Maximum = 1;
            this.chart1.ChartAreas["ChartArea1"].AxisY.Minimum = 0;
            this.chart1.ChartAreas["ChartArea1"].AxisY.Maximum = 1000;
            this.chart1.ChartAreas["ChartArea1"].AxisX.Interval = 0.05;
            this.chart1.ChartAreas["ChartArea1"].AxisY.Interval = 20;

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                string Ri = (listView1.Items[i]).Text;
                double converted = Convert.ToDouble(Ri);

                if (converted <= 0.05)
                {
                    counter++;
                    this.chart1.Series["Ri"].Points.AddXY(0.05, counter);
                }
                else if (converted <= 0.1)
                {
                    counter1++;
                    this.chart1.Series["Ri"].Points.AddXY(0.1, counter1);
                }
                else if (converted <= 0.15)
                {
                    counter2++;
                    this.chart1.Series["Ri"].Points.AddXY(0.15, counter2);
                }
                else if (converted <= 0.2)
                {
                    counter3++;
                    this.chart1.Series["Ri"].Points.AddXY(0.2, counter3);
                }
                else if (converted <= 0.25)
                {
                    counter4++;
                    this.chart1.Series["Ri"].Points.AddXY(0.25, counter4);
                }
                else if (converted <= 0.3)
                {
                    counter5++;
                    this.chart1.Series["Ri"].Points.AddXY(0.3, counter5);
                }

                else if (converted <= 0.35)
                {
                    counter6++;
                    this.chart1.Series["Ri"].Points.AddXY(0.35, counter6);
                }

                else if (converted <= 0.4)
                {
                    counter7++;
                    this.chart1.Series["Ri"].Points.AddXY(0.4, counter7);
                }
                else if (converted <= 0.45)
                {
                    counter8++;
                    this.chart1.Series["Ri"].Points.AddXY(0.45, counter8);
                }
                else if (converted <= 0.5)
                {
                    counter9++;
                    this.chart1.Series["Ri"].Points.AddXY(0.5, counter9);
                }
                else if (converted <= 0.55)
                {
                    counter10++;
                    this.chart1.Series["Ri"].Points.AddXY(0.55, counter10);
                }
                else if (converted <= 0.6)
                {
                    counter11++;
                    this.chart1.Series["Ri"].Points.AddXY(0.6, counter11);
                }
                else if (converted <= 0.65)
                {
                    counter12++;
                    this.chart1.Series["Ri"].Points.AddXY(0.65, counter12);
                }
                else if (converted <= 0.7)
                {
                    counter13++;
                    this.chart1.Series["Ri"].Points.AddXY(0.7, counter13);
                }
                else if (converted <= 0.75)
                {
                    counter14++;
                    this.chart1.Series["Ri"].Points.AddXY(0.75, counter14);
                }
                else if (converted <= 0.8)
                {
                    counter15++;
                    this.chart1.Series["Ri"].Points.AddXY(0.8, counter15);
                }
                else if (converted <= 0.85)
                {
                    counter16++;
                    this.chart1.Series["Ri"].Points.AddXY(0.85, counter16);
                }
                else if (converted <= 0.9)
                {
                    counter17++;
                    this.chart1.Series["Ri"].Points.AddXY(0.9, counter17);
                }
                else if (converted <= 0.95)
                {
                    counter18++;
                    this.chart1.Series["Ri"].Points.AddXY(0.95, counter18);
                }
                else if (converted <= 1)
                {
                    counter19++;
                    this.chart1.Series["Ri"].Points.AddXY(1, counter19);
                }
            }
        }
    }
}
