namespace PID
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timerGlobal = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonRunningFast = new System.Windows.Forms.RadioButton();
            this.radioButtonRunningNormal = new System.Windows.Forms.RadioButton();
            this.radioButtonRunningSlow = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.labelCurrentValue = new System.Windows.Forms.Label();
            this.trackBarP = new System.Windows.Forms.TrackBar();
            this.trackBarI = new System.Windows.Forms.TrackBar();
            this.trackBarD = new System.Windows.Forms.TrackBar();
            this.labelP = new System.Windows.Forms.Label();
            this.labelI = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarD)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.AxisY.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Wave;
            chartArea2.AxisY.ScaleBreakStyle.Enabled = true;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "set";
            series3.SmartLabelStyle.Enabled = false;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "action";
            series4.SmartLabelStyle.Enabled = false;
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(776, 370);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // timerGlobal
            // 
            this.timerGlobal.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 20;
            this.trackBar1.Location = new System.Drawing.Point(797, 1);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = -100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 359);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(851, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(999, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "运行";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonRunningFast);
            this.groupBox1.Controls.Add(this.radioButtonRunningNormal);
            this.groupBox1.Controls.Add(this.radioButtonRunningSlow);
            this.groupBox1.Location = new System.Drawing.Point(848, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 95);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Running Speed";
            // 
            // radioButtonRunningFast
            // 
            this.radioButtonRunningFast.AutoSize = true;
            this.radioButtonRunningFast.Location = new System.Drawing.Point(6, 64);
            this.radioButtonRunningFast.Name = "radioButtonRunningFast";
            this.radioButtonRunningFast.Size = new System.Drawing.Size(47, 16);
            this.radioButtonRunningFast.TabIndex = 2;
            this.radioButtonRunningFast.Text = "Fast";
            this.radioButtonRunningFast.UseVisualStyleBackColor = true;
            this.radioButtonRunningFast.CheckedChanged += new System.EventHandler(this.radioButtonRunningFast_CheckedChanged);
            // 
            // radioButtonRunningNormal
            // 
            this.radioButtonRunningNormal.AutoSize = true;
            this.radioButtonRunningNormal.Checked = true;
            this.radioButtonRunningNormal.Location = new System.Drawing.Point(6, 42);
            this.radioButtonRunningNormal.Name = "radioButtonRunningNormal";
            this.radioButtonRunningNormal.Size = new System.Drawing.Size(59, 16);
            this.radioButtonRunningNormal.TabIndex = 1;
            this.radioButtonRunningNormal.TabStop = true;
            this.radioButtonRunningNormal.Text = "Normal";
            this.radioButtonRunningNormal.UseVisualStyleBackColor = true;
            this.radioButtonRunningNormal.CheckedChanged += new System.EventHandler(this.radioButtonRunningNormal_CheckedChanged);
            // 
            // radioButtonRunningSlow
            // 
            this.radioButtonRunningSlow.AutoSize = true;
            this.radioButtonRunningSlow.Location = new System.Drawing.Point(6, 20);
            this.radioButtonRunningSlow.Name = "radioButtonRunningSlow";
            this.radioButtonRunningSlow.Size = new System.Drawing.Size(47, 16);
            this.radioButtonRunningSlow.TabIndex = 0;
            this.radioButtonRunningSlow.Text = "Slow";
            this.radioButtonRunningSlow.UseVisualStyleBackColor = true;
            this.radioButtonRunningSlow.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(854, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 24);
            this.button2.TabIndex = 5;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelCurrentValue
            // 
            this.labelCurrentValue.AutoSize = true;
            this.labelCurrentValue.Location = new System.Drawing.Point(1006, 114);
            this.labelCurrentValue.Name = "labelCurrentValue";
            this.labelCurrentValue.Size = new System.Drawing.Size(41, 12);
            this.labelCurrentValue.TabIndex = 7;
            this.labelCurrentValue.Text = "label3";
            // 
            // trackBarP
            // 
            this.trackBarP.LargeChange = 10;
            this.trackBarP.Location = new System.Drawing.Point(882, 132);
            this.trackBarP.Maximum = 100;
            this.trackBarP.Name = "trackBarP";
            this.trackBarP.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarP.Size = new System.Drawing.Size(45, 243);
            this.trackBarP.TabIndex = 8;
            this.trackBarP.TickFrequency = 5;
            this.trackBarP.Scroll += new System.EventHandler(this.trackBarP_Scroll);
            // 
            // trackBarI
            // 
            this.trackBarI.LargeChange = 10;
            this.trackBarI.Location = new System.Drawing.Point(948, 132);
            this.trackBarI.Maximum = 100;
            this.trackBarI.Name = "trackBarI";
            this.trackBarI.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarI.Size = new System.Drawing.Size(45, 243);
            this.trackBarI.TabIndex = 9;
            this.trackBarI.TickFrequency = 5;
            this.trackBarI.Scroll += new System.EventHandler(this.trackBarI_Scroll);
            // 
            // trackBarD
            // 
            this.trackBarD.LargeChange = 10;
            this.trackBarD.Location = new System.Drawing.Point(1008, 132);
            this.trackBarD.Maximum = 100;
            this.trackBarD.Name = "trackBarD";
            this.trackBarD.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarD.Size = new System.Drawing.Size(45, 243);
            this.trackBarD.TabIndex = 10;
            this.trackBarD.TickFrequency = 5;
            this.trackBarD.Scroll += new System.EventHandler(this.trackBarD_Scroll);
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Location = new System.Drawing.Point(865, 274);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(11, 12);
            this.labelP.TabIndex = 11;
            this.labelP.Text = "0";
            // 
            // labelI
            // 
            this.labelI.AutoSize = true;
            this.labelI.Location = new System.Drawing.Point(931, 274);
            this.labelI.Name = "labelI";
            this.labelI.Size = new System.Drawing.Size(11, 12);
            this.labelI.TabIndex = 12;
            this.labelI.Text = "0";
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Location = new System.Drawing.Point(982, 274);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(11, 12);
            this.labelD.TabIndex = 13;
            this.labelD.Text = "0";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(865, 411);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 16);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Show Label";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelI);
            this.Controls.Add(this.labelP);
            this.Controls.Add(this.trackBarD);
            this.Controls.Add(this.trackBarI);
            this.Controls.Add(this.trackBarP);
            this.Controls.Add(this.labelCurrentValue);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timerGlobal;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonRunningFast;
        private System.Windows.Forms.RadioButton radioButtonRunningNormal;
        private System.Windows.Forms.RadioButton radioButtonRunningSlow;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelCurrentValue;
        private System.Windows.Forms.TrackBar trackBarP;
        private System.Windows.Forms.TrackBar trackBarI;
        private System.Windows.Forms.TrackBar trackBarD;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.Label labelI;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

