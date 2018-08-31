namespace AStart
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numericUpDownRow = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownColum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonSetNothing = new System.Windows.Forms.RadioButton();
            this.radioButtonSetBarrial = new System.Windows.Forms.RadioButton();
            this.radioButtonSetStart = new System.Windows.Forms.RadioButton();
            this.radioButtonSetTernimal = new System.Windows.Forms.RadioButton();
            this.buttonSetMap = new System.Windows.Forms.Button();
            this.buttonNavigate = new System.Windows.Forms.Button();
            this.checkBoxShowProgress = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColum)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(737, 548);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // numericUpDownRow
            // 
            this.numericUpDownRow.Location = new System.Drawing.Point(790, 64);
            this.numericUpDownRow.Name = "numericUpDownRow";
            this.numericUpDownRow.Size = new System.Drawing.Size(115, 21);
            this.numericUpDownRow.TabIndex = 1;
            this.numericUpDownRow.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDownColum
            // 
            this.numericUpDownColum.Location = new System.Drawing.Point(790, 91);
            this.numericUpDownColum.Name = "numericUpDownColum";
            this.numericUpDownColum.Size = new System.Drawing.Size(115, 21);
            this.numericUpDownColum.TabIndex = 2;
            this.numericUpDownColum.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(755, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "行数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(755, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "列数";
            // 
            // radioButtonSetNothing
            // 
            this.radioButtonSetNothing.AutoSize = true;
            this.radioButtonSetNothing.Checked = true;
            this.radioButtonSetNothing.Location = new System.Drawing.Point(757, 171);
            this.radioButtonSetNothing.Name = "radioButtonSetNothing";
            this.radioButtonSetNothing.Size = new System.Drawing.Size(59, 16);
            this.radioButtonSetNothing.TabIndex = 5;
            this.radioButtonSetNothing.TabStop = true;
            this.radioButtonSetNothing.Text = "（无）";
            this.radioButtonSetNothing.UseVisualStyleBackColor = true;
            this.radioButtonSetNothing.CheckedChanged += new System.EventHandler(this.radioButtonSetNothing_CheckedChanged);
            // 
            // radioButtonSetBarrial
            // 
            this.radioButtonSetBarrial.AutoSize = true;
            this.radioButtonSetBarrial.Location = new System.Drawing.Point(757, 193);
            this.radioButtonSetBarrial.Name = "radioButtonSetBarrial";
            this.radioButtonSetBarrial.Size = new System.Drawing.Size(59, 16);
            this.radioButtonSetBarrial.TabIndex = 6;
            this.radioButtonSetBarrial.Text = "障碍物";
            this.radioButtonSetBarrial.UseVisualStyleBackColor = true;
            this.radioButtonSetBarrial.CheckedChanged += new System.EventHandler(this.radioButtonSetBarrial_CheckedChanged);
            // 
            // radioButtonSetStart
            // 
            this.radioButtonSetStart.AutoSize = true;
            this.radioButtonSetStart.Location = new System.Drawing.Point(757, 215);
            this.radioButtonSetStart.Name = "radioButtonSetStart";
            this.radioButtonSetStart.Size = new System.Drawing.Size(47, 16);
            this.radioButtonSetStart.TabIndex = 7;
            this.radioButtonSetStart.Text = "起点";
            this.radioButtonSetStart.UseVisualStyleBackColor = true;
            this.radioButtonSetStart.CheckedChanged += new System.EventHandler(this.radioButtonSetStart_CheckedChanged);
            // 
            // radioButtonSetTernimal
            // 
            this.radioButtonSetTernimal.AutoSize = true;
            this.radioButtonSetTernimal.Location = new System.Drawing.Point(757, 237);
            this.radioButtonSetTernimal.Name = "radioButtonSetTernimal";
            this.radioButtonSetTernimal.Size = new System.Drawing.Size(47, 16);
            this.radioButtonSetTernimal.TabIndex = 8;
            this.radioButtonSetTernimal.Text = "终点";
            this.radioButtonSetTernimal.UseVisualStyleBackColor = true;
            this.radioButtonSetTernimal.CheckedChanged += new System.EventHandler(this.radioButtonSetTernimal_CheckedChanged);
            // 
            // buttonSetMap
            // 
            this.buttonSetMap.Location = new System.Drawing.Point(911, 66);
            this.buttonSetMap.Name = "buttonSetMap";
            this.buttonSetMap.Size = new System.Drawing.Size(73, 46);
            this.buttonSetMap.TabIndex = 9;
            this.buttonSetMap.Text = "设置地图";
            this.buttonSetMap.UseVisualStyleBackColor = true;
            this.buttonSetMap.Click += new System.EventHandler(this.buttonSetMap_Click);
            // 
            // buttonNavigate
            // 
            this.buttonNavigate.Location = new System.Drawing.Point(757, 496);
            this.buttonNavigate.Name = "buttonNavigate";
            this.buttonNavigate.Size = new System.Drawing.Size(227, 64);
            this.buttonNavigate.TabIndex = 10;
            this.buttonNavigate.Text = "寻路并显示";
            this.buttonNavigate.UseVisualStyleBackColor = true;
            this.buttonNavigate.Click += new System.EventHandler(this.buttonNavigate_Click);
            // 
            // checkBoxShowProgress
            // 
            this.checkBoxShowProgress.AutoSize = true;
            this.checkBoxShowProgress.Checked = true;
            this.checkBoxShowProgress.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowProgress.Location = new System.Drawing.Point(757, 317);
            this.checkBoxShowProgress.Name = "checkBoxShowProgress";
            this.checkBoxShowProgress.Size = new System.Drawing.Size(48, 16);
            this.checkBoxShowProgress.TabIndex = 11;
            this.checkBoxShowProgress.Text = "过程";
            this.checkBoxShowProgress.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 572);
            this.Controls.Add(this.checkBoxShowProgress);
            this.Controls.Add(this.buttonNavigate);
            this.Controls.Add(this.buttonSetMap);
            this.Controls.Add(this.radioButtonSetTernimal);
            this.Controls.Add(this.radioButtonSetStart);
            this.Controls.Add(this.radioButtonSetBarrial);
            this.Controls.Add(this.radioButtonSetNothing);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownColum);
            this.Controls.Add(this.numericUpDownRow);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownRow;
        private System.Windows.Forms.NumericUpDown numericUpDownColum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonSetNothing;
        private System.Windows.Forms.RadioButton radioButtonSetBarrial;
        private System.Windows.Forms.RadioButton radioButtonSetStart;
        private System.Windows.Forms.RadioButton radioButtonSetTernimal;
        private System.Windows.Forms.Button buttonSetMap;
        private System.Windows.Forms.Button buttonNavigate;
        private System.Windows.Forms.CheckBox checkBoxShowProgress;
        private System.Windows.Forms.Timer timer1;
    }
}

