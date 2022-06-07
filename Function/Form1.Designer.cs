
namespace Function
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckSum = new System.Windows.Forms.CheckBox();
            this.CheckCosx = new System.Windows.Forms.CheckBox();
            this.CheckSinx = new System.Windows.Forms.CheckBox();
            this.oneTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.twoTB = new System.Windows.Forms.TextBox();
            this.threeTB = new System.Windows.Forms.TextBox();
            this.aTB = new System.Windows.Forms.TextBox();
            this.bTB = new System.Windows.Forms.TextBox();
            this.stepTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Alignment = System.Drawing.StringAlignment.Center;
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(-26, 12);
            this.chart1.Name = "chart1";
            series9.BorderWidth = 3;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Legend = "Legend1";
            series9.LegendText = "Вариации синуса";
            series9.Name = "Series0";
            series10.BorderWidth = 3;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Legend = "Legend1";
            series10.LegendText = "y=sinx()";
            series10.Name = "series1";
            series11.BorderWidth = 3;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series11.Legend = "Legend1";
            series11.LegendText = "y=cos(x)";
            series11.Name = "Series2";
            series12.BorderWidth = 3;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Legend = "Legend1";
            series12.LegendText = "y=sin(x)+cos(x)";
            series12.Name = "Series3";
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Size = new System.Drawing.Size(736, 347);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(500, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Расчёт только sin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CheckSum);
            this.groupBox1.Controls.Add(this.CheckCosx);
            this.groupBox1.Controls.Add(this.CheckSinx);
            this.groupBox1.Location = new System.Drawing.Point(12, 395);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 43);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Графики";
            // 
            // CheckSum
            // 
            this.CheckSum.AutoSize = true;
            this.CheckSum.Location = new System.Drawing.Point(144, 20);
            this.CheckSum.Name = "CheckSum";
            this.CheckSum.Size = new System.Drawing.Size(95, 17);
            this.CheckSum.TabIndex = 2;
            this.CheckSum.Text = "y=sin(x)+cos(x)";
            this.CheckSum.UseVisualStyleBackColor = true;
            this.CheckSum.CheckedChanged += new System.EventHandler(this.CheckSum_CheckedChanged);
            // 
            // CheckCosx
            // 
            this.CheckCosx.AutoSize = true;
            this.CheckCosx.Location = new System.Drawing.Point(73, 20);
            this.CheckCosx.Name = "CheckCosx";
            this.CheckCosx.Size = new System.Drawing.Size(65, 17);
            this.CheckCosx.TabIndex = 1;
            this.CheckCosx.Text = "y=cos(x)";
            this.CheckCosx.UseVisualStyleBackColor = true;
            this.CheckCosx.CheckedChanged += new System.EventHandler(this.CheckCosx_CheckedChanged);
            // 
            // CheckSinx
            // 
            this.CheckSinx.AutoSize = true;
            this.CheckSinx.Location = new System.Drawing.Point(6, 19);
            this.CheckSinx.Name = "CheckSinx";
            this.CheckSinx.Size = new System.Drawing.Size(61, 17);
            this.CheckSinx.TabIndex = 0;
            this.CheckSinx.Text = "y=sin(x)";
            this.CheckSinx.UseVisualStyleBackColor = true;
            this.CheckSinx.CheckedChanged += new System.EventHandler(this.CheckSinx_CheckedChanged);
            // 
            // oneTB
            // 
            this.oneTB.Location = new System.Drawing.Point(73, 367);
            this.oneTB.Name = "oneTB";
            this.oneTB.Size = new System.Drawing.Size(29, 20);
            this.oneTB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "y= sin (          x +            ) +               a:            b:              " +
    "               Шаг:";
            // 
            // twoTB
            // 
            this.twoTB.Location = new System.Drawing.Point(137, 367);
            this.twoTB.Name = "twoTB";
            this.twoTB.Size = new System.Drawing.Size(29, 20);
            this.twoTB.TabIndex = 5;
            // 
            // threeTB
            // 
            this.threeTB.Location = new System.Drawing.Point(197, 367);
            this.threeTB.Name = "threeTB";
            this.threeTB.Size = new System.Drawing.Size(29, 20);
            this.threeTB.TabIndex = 6;
            // 
            // aTB
            // 
            this.aTB.Location = new System.Drawing.Point(269, 367);
            this.aTB.Name = "aTB";
            this.aTB.Size = new System.Drawing.Size(29, 20);
            this.aTB.TabIndex = 7;
            // 
            // bTB
            // 
            this.bTB.Location = new System.Drawing.Point(331, 367);
            this.bTB.Name = "bTB";
            this.bTB.Size = new System.Drawing.Size(29, 20);
            this.bTB.TabIndex = 8;
            // 
            // stepTB
            // 
            this.stepTB.Location = new System.Drawing.Point(478, 365);
            this.stepTB.Name = "stepTB";
            this.stepTB.Size = new System.Drawing.Size(29, 20);
            this.stepTB.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 450);
            this.Controls.Add(this.stepTB);
            this.Controls.Add(this.bTB);
            this.Controls.Add(this.aTB);
            this.Controls.Add(this.threeTB);
            this.Controls.Add(this.twoTB);
            this.Controls.Add(this.oneTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "График";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CheckSum;
        private System.Windows.Forms.CheckBox CheckCosx;
        private System.Windows.Forms.CheckBox CheckSinx;
        private System.Windows.Forms.TextBox oneTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox twoTB;
        private System.Windows.Forms.TextBox threeTB;
        private System.Windows.Forms.TextBox aTB;
        private System.Windows.Forms.TextBox bTB;
        private System.Windows.Forms.TextBox stepTB;
    }
}

