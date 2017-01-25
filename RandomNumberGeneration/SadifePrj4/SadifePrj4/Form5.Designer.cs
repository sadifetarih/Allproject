namespace SadifePrj4
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericXo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.numericC = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericM = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericA = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericRandom = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRandom)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox2.Controls.Add(this.numericXo);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.chart1);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnGenerate);
            this.groupBox2.Controls.Add(this.numericC);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numericM);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numericA);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numericRandom);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Yu Mincho Light", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox2.Location = new System.Drawing.Point(-3, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(838, 511);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Random Number Generator using Linear Congruential Method ";
            // 
            // numericXo
            // 
            this.numericXo.Location = new System.Drawing.Point(187, 28);
            this.numericXo.Name = "numericXo";
            this.numericXo.Size = new System.Drawing.Size(203, 29);
            this.numericXo.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(552, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 35);
            this.button1.TabIndex = 37;
            this.button1.Text = "Load Chart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(411, 34);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Ri";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(403, 312);
            this.chart1.TabIndex = 36;
            this.chart1.Text = "chart1";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(187, 261);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(133, 237);
            this.listView1.TabIndex = 35;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ri";
            this.columnHeader1.Width = 130;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.Location = new System.Drawing.Point(301, 210);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 32);
            this.btnExit.TabIndex = 34;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGenerate.Location = new System.Drawing.Point(187, 210);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(97, 32);
            this.btnGenerate.TabIndex = 33;
            this.btnGenerate.Text = "GENERATE";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // numericC
            // 
            this.numericC.Location = new System.Drawing.Point(187, 102);
            this.numericC.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericC.Name = "numericC";
            this.numericC.Size = new System.Drawing.Size(203, 29);
            this.numericC.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(62, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "C :";
            // 
            // numericM
            // 
            this.numericM.Location = new System.Drawing.Point(187, 135);
            this.numericM.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericM.Name = "numericM";
            this.numericM.Size = new System.Drawing.Size(203, 29);
            this.numericM.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(62, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "m :";
            // 
            // numericA
            // 
            this.numericA.Location = new System.Drawing.Point(187, 68);
            this.numericA.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericA.Name = "numericA";
            this.numericA.Size = new System.Drawing.Size(203, 29);
            this.numericA.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(62, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "a :";
            // 
            // numericRandom
            // 
            this.numericRandom.Location = new System.Drawing.Point(187, 167);
            this.numericRandom.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericRandom.Name = "numericRandom";
            this.numericRandom.Size = new System.Drawing.Size(203, 29);
            this.numericRandom.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(61, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Random No.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(62, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Xo :";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 509);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form5";
            this.Text = "Form5";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRandom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericRandom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox numericXo;
    }
}