using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateDeterminant(3, 100000000);
        }

        public static void CalculateDeterminant(int size, double times)
        {
            Random rnd = new Random();
            double[,] matrix = new double[size, size];
            double det = 0;
            int i, j, k;
            int counter = 0;

            if (size <= 0)
            {
                MessageBox.Show("There is no element inside of the matrix.");
            }
            else
            {
                for (k = 1; k <= times; k++)
                {
                    for (i = 0; i < size; i++)
                    {
                        for (j = 0; j < size; j++)
                        {
                            if (i == j)
                            {
                                matrix[i, j] = rnd.NextDouble();
                            }
                            else
                            {
                                matrix[i, j] = rnd.NextDouble() * (-1);
                            }
                        }
                    }
                    det = matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) - matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]) + matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
                    if (det >= 0)
                    {
                        counter++;
                    }
                }
                MessageBox.Show("Number of positive determinants are : " + counter);
                double ratio = (double)(counter / times);
                MessageBox.Show("The ratio of positive determinant : " + ratio);
            }
        }
    }
}


