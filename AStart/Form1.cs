using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AStart
{
    public partial class Form1 : Form
    {
        enum GridState
        {
            Occupied,
            Empty,
            Start,
            Terminal
        };

        private GridState[,] gridStates;
        private GridState mapClickMode = GridState.Empty;
        private Point startPoint;
        private Point termPoint;

        private Bitmap map;
        private Graphics graphics;
        private Pen gridPen = Pens.DarkGray;
        private Brush startBrush = Brushes.LightGreen;
        private Brush terminalBrush = Brushes.LightPink;
        private Brush barrialBrush = Brushes.Red;
        private SolidBrush clearBrush = new SolidBrush(Control.DefaultBackColor);

        public Form1()
        {
            InitializeComponent();
            this.map = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            this.graphics = Graphics.FromImage(map);
            this.graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
        }

        private void buttonSetMap_Click(object sender, EventArgs e)
        {
            if(this.numericUpDownColum.Value == 0 || this.numericUpDownRow.Value == 0)
            {
                MessageBox.Show("Must set column and row.");
            }
            else
            {
                int cellWidth = this.pictureBox1.Width / (int)this.numericUpDownColum.Value;
                int cellHeight = this.pictureBox1.Height / (int)this.numericUpDownRow.Value;

                this.graphics.Clear(Control.DefaultBackColor);
                for(int a = 0; a < this.numericUpDownColum.Value + 1; a++)
                {
                    this.graphics.DrawLine(this.gridPen, a * cellWidth, 0, a * cellWidth, this.map.Height);
                }
                for(int a = 0; a < this.numericUpDownRow.Value + 1; a++)
                {
                    this.graphics.DrawLine(gridPen, 0, a * cellHeight, this.map.Width, a * cellHeight);
                }
            }
            this.pictureBox1.Image = this.map;

            this.gridStates = new GridState[(int)this.numericUpDownRow.Value, (int)this.numericUpDownColum.Value];
            for(int a = 0; a < this.numericUpDownRow.Value; a++)
            {
                for(int b = 0; b < this.numericUpDownColum.Value; b++)
                {
                    this.gridStates[a, b] = GridState.Empty;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Point p = (e as MouseEventArgs).Location;
            MouseButtons b = (e as MouseEventArgs).Button;

            int cellWidth = this.pictureBox1.Width / (int)this.numericUpDownColum.Value;
            int cellHeight = this.pictureBox1.Height / (int)this.numericUpDownRow.Value;
            int column = p.X / cellWidth;
            int row = p.Y / cellHeight;



            if (b == MouseButtons.Left)
            {
                switch (this.mapClickMode)
                {
                    case GridState.Empty:
                        break;
                    case GridState.Start:
                        if (this.startPoint.IsEmpty)
                        {
                            this.startPoint = new Point(column, row);
                            this.gridStates[row, column] = GridState.Start;
                            this.graphics.FillRectangle(this.startBrush, column * cellWidth, row * cellHeight, cellWidth, cellHeight);
                        }
                        else
                        {
                            MessageBox.Show("只能设置一个Start");
                        }
                        break;
                    case GridState.Terminal:
                        if (this.termPoint.IsEmpty)
                        {
                            this.termPoint = new Point(column, row);
                            this.gridStates[row, column] = GridState.Terminal;
                            this.graphics.FillRectangle(this.terminalBrush, column * cellWidth, row * cellHeight, cellWidth, cellHeight);
                        }
                        else
                        {
                            MessageBox.Show("只能设置一个End");
                        }
                        break;
                    case GridState.Occupied:
                        this.gridStates[row, column] = GridState.Occupied;
                        this.graphics.FillRectangle(this.barrialBrush, column * cellWidth, row * cellHeight, cellWidth, cellHeight);
                        break;
                    default:
                        break;
                }
            }
            else if(b == MouseButtons.Right)
            {
                
                this.graphics.FillRectangle(new SolidBrush(Control.DefaultBackColor), column * cellWidth, row * cellHeight, cellWidth, cellHeight);
                this.graphics.DrawRectangle(gridPen, column * cellWidth, row * cellHeight, cellWidth, cellHeight);
                if(this.gridStates[row,column] == GridState.Start)
                {
                    this.startPoint = new Point();
                }
                else if(this.gridStates[row, column] == GridState.Terminal)
                {
                    this.termPoint = new Point();
                }
                this.gridStates[row, column] = GridState.Empty;
            }

            this.pictureBox1.Image = this.map;
        }

        private void radioButtonSetNothing_CheckedChanged(object sender, EventArgs e)
        {
            if((sender as RadioButton).Checked)
            {
                this.mapClickMode = GridState.Empty;
            }
        }

        private void radioButtonSetBarrial_CheckedChanged(object sender, EventArgs e)
        {
            if((sender as RadioButton).Checked)
            {
                this.mapClickMode = GridState.Occupied;
            }
        }

        private void radioButtonSetStart_CheckedChanged(object sender, EventArgs e)
        {
            if((sender as RadioButton).Checked)
            {
                this.mapClickMode = GridState.Start;
            }
        }

        private void radioButtonSetTernimal_CheckedChanged(object sender, EventArgs e)
        {
            if((sender as RadioButton).Checked)
            {
                this.mapClickMode = GridState.Terminal;
            }
        }

        private void buttonNavigate_Click(object sender, EventArgs e)
        {
        }
    }

    public abstract class Map
    {

    }
}
