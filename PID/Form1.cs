using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PID
{
    public partial class Form1 : Form
    {
        enum RunningSpeed
        {
            slow = 200,
            normal = 100,
            fast = 30
        };


        bool isRunning = false;
        uint maxPointsInChart = 60;

        double currentValue
        {
            get
            {
                return this._currentValue;
            }
            set
            {
                this._currentValue = value;
                this.labelCurrentValue.Text = value.ToString();
            }
        }
        double setValue
        {
            set
            {
                this.trackBar1.Value = Convert.ToInt32(value);
            }
            get
            {
                return (double)this.trackBar1.Value;
            }
        }

        private double _currentValue = 0d;
        Random random = new Random(DateTime.Now.Millisecond);
        PIDController pidController = new PIDController(0d, 0d, 0d);

        public Form1()
        {
            InitializeComponent();


            this.label1.Text = this.trackBar1.Value.ToString();
            this.timerGlobal.Interval = Convert.ToInt32(RunningSpeed.normal);
            this.checkBox1_CheckedChanged(null, new EventArgs());

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.chart1.Series["set"].Points.Add(this.setValue);

            this.pidController.setValue = this.setValue;
            this.pidController.currentValue = this.currentValue;
            this.pidController.interval = this.timerGlobal.Interval / 1000d;
            this.currentValue = this.pidController.outputValue;
            this.chart1.Series["action"].Points.Add(this.currentValue);



            if (this.chart1.Series["set"].Points.Count >= 60)
            {
                this.chart1.Series["set"].Points.RemoveAt(0);
                this.chart1.Series["action"].Points.RemoveAt(0);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.label1.Text = this.trackBar1.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.isRunning == true)
            {
                this.button1.Text = "停止";
            }
            else
            {
                this.button1.Text = "运行";
            }
            this.isRunning = !this.isRunning;
            this.timerGlobal.Enabled = this.isRunning;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(this.radioButtonRunningSlow.Checked)
            {
                if (this.isRunning)
                {
                    this.timerGlobal.Enabled = false;
                }
                this.timerGlobal.Interval = Convert.ToInt32(RunningSpeed.slow);
                if (this.isRunning)
                {
                    this.timerGlobal.Enabled = true;
                }
            }
        }

        private void radioButtonRunningNormal_CheckedChanged(object sender, EventArgs e)
        {
            if(this.radioButtonRunningNormal.Checked)
            {
                if (this.isRunning)
                {
                    this.timerGlobal.Enabled = false;
                }
                this.timerGlobal.Interval = Convert.ToInt32(RunningSpeed.normal);
                if (this.isRunning)
                {
                    this.timerGlobal.Enabled = true;
                }
            }
        }

        private void radioButtonRunningFast_CheckedChanged(object sender, EventArgs e)
        {
            if(this.radioButtonRunningFast.Checked)
            {
                if (this.isRunning)
                {
                    this.timerGlobal.Enabled = false;
                }
                this.timerGlobal.Interval = Convert.ToInt32(RunningSpeed.fast);
                if (this.isRunning)
                {
                    this.timerGlobal.Enabled = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.chart1.Series["set"].Points.Clear();
            this.chart1.Series["action"].Points.Clear();
        }


        private void trackBarP_Scroll(object sender, EventArgs e)
        {
            this.pidController.p = (Convert.ToDouble(this.trackBarP.Value) * 0.01);
            this.labelP.Text = this.pidController.p.ToString();
        }

        private void trackBarI_Scroll(object sender, EventArgs e)
        {
            this.pidController.i = (Convert.ToDouble(this.trackBarI.Value) * 0.01);
            this.labelI.Text = this.pidController.i.ToString();
        }

        private void trackBarD_Scroll(object sender, EventArgs e)
        {
            this.pidController.d = (Convert.ToDouble(this.trackBarD.Value) * 0.01);
            this.labelD.Text = this.pidController.d.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.chart1.Series["set"].IsValueShownAsLabel = this.checkBox1.Checked;
            this.chart1.Series["action"].IsValueShownAsLabel = this.checkBox1.Checked;
        }
    }

    class PIDController
    {
        public double p = 0d;
        public double i = 0d;
        public double d = 0d;

        public double setValue = 0d;
        public double currentValue = 0d;
        public double interval;
        public double outputValue
        {
            get
            {
                double error = this.setValue - this.currentValue;
                this.intergrate += error + this.interval;
                return this.p * error + this.i * this.intergrate + this.d * error / this.interval;
            }
        }

        private double intergrate = 0d;

        public PIDController(double p, double i, double d, double interval = 1)
        {
            this.p = p;
            this.i = i;
            this.d = d;
            this.interval = interval;
        }
    }
}
