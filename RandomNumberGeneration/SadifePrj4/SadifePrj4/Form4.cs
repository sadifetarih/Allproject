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
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
            

        }

        private void checkM_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {


        }

        private void numericM_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericN_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericRandom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private int[] arr = null;
        private decimal[] result = null;
        private void btnCreate_Click_2(object sender, EventArgs e)
        {
            if (numericN.Value == 0)
            {
                MessageBox.Show("Please enter a number for n!!!");
            }
            else
            {
                btnGenerate.Visible = true;
                //List<TextBox> t = new List<TextBox>();
                //for (int i = 1; i <= (int)numericN.Value; i++)
                //{
                //    TextBox tb = new TextBox();
                //    tb.Text = "txt" + i;
                //    tb.Name = "txtN" + i;
                //    t.Add(tb);
                //}
                // TextBox[] arr = new TextBox[(int)numericN.Value];
                arr = new int[(int)numericN.Value*100000];
                for (int i = 0; i < (int)numericN.Value; i++)
                {
                    TextBox text = new TextBox();                    
                    //arr[i].TextChanged += new EventHandler(textBox_TextChanged);
                    text.Text = ""+i;
                    text.Name = "txt"+i;
                    text.Top = i * 25;
                    groupBox2.Controls.Add(text);
                    //text.TextChanged += new EventHandler(textBox_TextChanged);
                    //arr[i] = int.Parse(text.Text);                    
                }        
            }
        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.Text = t.Text;     
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < (int)numericN.Value; i++)
            {
                TextBox tt = (TextBox)groupBox2.Controls.Find("txt" + i, true)[0];
                arr[i] = int.Parse(tt.Text);
            }
            result = new decimal[(int)numericRandom.Value];
            for (int i = 0; i < numericRandom.Value; i++)
            {
                arr[(int)numericN.Value + i] = (arr[i] + arr[i+4]) % (int)numericM.Value;
                result[i] = (decimal)arr[5 + i]  / (int)numericM.Value;
            }
            listView1.Items.Clear();
            for (int i = 0; i < numericRandom.Value; i++)
            {
                
                listView1.Items.Add(result[i].ToString());
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            btnGenerate.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
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
            this.chart1.ChartAreas["ChartArea1"].AxisY.Interval = 40;

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                double converted = Convert.ToDouble((listView1.Items[i]).Text);

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

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
