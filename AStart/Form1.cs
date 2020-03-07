using System;
using System.Collections.Generic;
using System.Collections;
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
            Terminal,
            Trace
        };

        struct Trace
        {
            public Point point;
            public Point parent;
            public float distanceToTarget;
            public float moveCost;
            public Trace(Point p, Point pa, float d, float m)
            {
                point = p;
                parent = pa;
                distanceToTarget = d;
                moveCost = m;
            }
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
        private Brush traceBrush = Brushes.Yellow;
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
            if (this.numericUpDownColum.Value == 0 || this.numericUpDownRow.Value == 0)
            {
                MessageBox.Show("Must set column and row.");
            }
            else
            {
                int cellWidth = this.pictureBox1.Width / (int)this.numericUpDownColum.Value;
                int cellHeight = this.pictureBox1.Height / (int)this.numericUpDownRow.Value;

                this.graphics.Clear(Control.DefaultBackColor);
                for (int a = 0; a < this.numericUpDownColum.Value + 1; a++)
                {
                    this.graphics.DrawLine(this.gridPen, a * cellWidth, 0, a * cellWidth, this.map.Height);
                }
                for (int a = 0; a < this.numericUpDownRow.Value + 1; a++)
                {
                    this.graphics.DrawLine(gridPen, 0, a * cellHeight, this.map.Width, a * cellHeight);
                }
            }
            this.pictureBox1.Image = this.map;

            this.gridStates = new GridState[(int)this.numericUpDownRow.Value, (int)this.numericUpDownColum.Value];
            for (int a = 0; a < this.numericUpDownRow.Value; a++)
            {
                for (int b = 0; b < this.numericUpDownColum.Value; b++)
                {
                    this.gridStates[a, b] = GridState.Empty;
                }
            }
            this.startPoint = Point.Empty;
            this.termPoint = Point.Empty;
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
                this.SetGridState(new Point(column, row), this.mapClickMode);
              
            }
            else if (b == MouseButtons.Right)
            {
                this.SetGridState(new Point(column, row), GridState.Empty);
            }

        }

        private void radioButtonSetNothing_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                this.mapClickMode = GridState.Empty;
            }
        }

        private void radioButtonSetBarrial_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                this.mapClickMode = GridState.Occupied;
            }
        }

        private void radioButtonSetStart_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                this.mapClickMode = GridState.Start;
            }
        }

        private void radioButtonSetTernimal_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                this.mapClickMode = GridState.Terminal;
            }
        }

        private void buttonNavigate_Click(object sender, EventArgs e)
        {
            Stack<Point> openList = new Stack<Point>();
            Stack<Point> closeList = new Stack<Point>();
            Dictionary<Point, Point> parent = new Dictionary<Point, Point>();
            Dictionary<Point, float> moveCost = new Dictionary<Point, float>();
            Dictionary<Point, float> distance = new Dictionary<Point, float>();

            openList.Push(this.startPoint);
            parent.Add(this.startPoint, this.startPoint);
            for(int r = 0; r <= this.gridStates.GetUpperBound(0); r++)
            {
                for(int c = 0; c <= this.gridStates.GetUpperBound(1); c++)
                {
                    moveCost.Add(new Point(c, r), float.PositiveInfinity);
                }
            }
            distance.Add(this.startPoint, this.Distance(this.startPoint, this.termPoint));

            moveCost[this.startPoint] = 0f;
            this.StartTrace(openList, closeList, parent, moveCost, distance);
            if (this.checkBoxShowProgress.Checked)
            {
                if (parent.ContainsKey(this.termPoint))
                {
                    Point p = parent[this.termPoint];
                    while (p != this.startPoint)
                    {
                        this.SetGridState(p, GridState.Trace);
                        p = parent[p];
                    }
                }
            }
        }

        private void StartTrace(Stack<Point> openList, Stack<Point> closeList, Dictionary<Point, Point> parent, Dictionary<Point, float> moveCost, Dictionary<Point, float> distance)
        {

            while(openList.Count() != 0)
            {
                Point c = openList.Pop();
                if(c == this.termPoint)
                {
                    return;
                }
                HashSet<Point> neibors = this.GetNeibors(c, method:8);
                Dictionary<Point, float> nd = new Dictionary<Point, float>();
                foreach(Point p in neibors)
                {
                    nd.Add(p, this.Distance(p, this.termPoint));
                }
                var neighbors = from node in nd orderby node.Value descending select node.Key;
                closeList.Push(c);

                foreach(Point n in neighbors)
                {
                    if(this.gridStates[n.Y, n.X] == GridState.Occupied || closeList.Contains(n))
                    {
                        continue;
                    }
                    if(!openList.Contains(n))
                    {
                        openList.Push(n);
                    }
                    if (moveCost[c] + this.CostOf(c, n) > moveCost[n])  // Judgement of G value
                    {
                        continue;
                    }
                    else
                    {
                        if (parent.Keys.Contains(n))
                        {
                            parent[n] = c;
                        }
                        else
                        {
                            parent.Add(n, c);
                        }
                        moveCost[n] = moveCost[c] + this.CostOf(c, n);

                        if (distance.Keys.Contains(n))
                        {
                            distance[n] = this.Distance(n, this.termPoint);
                        }
                        else
                        {
                            distance.Add(n, this.Distance(n, this.termPoint));
                        }
                    }
                }
            }

        }

        private float Distance(Point p1, Point p2, int method = 4)
        {
            return Math.Abs(p1.X - p2.X) + Math.Abs(p1.Y - p2.Y);
        }

        private float CostOf(Point p1, Point p2)
        {
            return 1;
        }


        private HashSet<Point> GetNeibors(Point point, int method = 4)
        {
            int left = point.X <= 0 ? 0 : point.X - 1;
            int up = point.Y <= 0 ? 0 : point.Y - 1;
            int right = point.X >= this.gridStates.GetLength(0) - 1 ? this.gridStates.GetLength(0) - 1 : point.X + 1;
            int down = point.Y >= this.gridStates.GetLength(1) - 1 ? this.gridStates.GetLength(1) - 1 : point.Y + 1;

            HashSet<Point> neibors = new HashSet<Point>();


            neibors.Add(new Point(point.X, up));
            neibors.Add(new Point(point.X, down));
            neibors.Add(new Point(left, point.Y));
            neibors.Add(new Point(right, point.Y));
            if (method == 8)
            {
                neibors.Add(new Point(left, up));
                neibors.Add(new Point(right, up));
                neibors.Add(new Point(left, down));
                neibors.Add(new Point(right, down));
            }

            if (neibors.Contains(point))
            {
                neibors.Remove(point);
            }
            return neibors;
        }

        private void SetGridState(Point p, GridState state)
        {
            int cellWidth = this.pictureBox1.Width / (int)this.numericUpDownColum.Value;
            int cellHeight = this.pictureBox1.Height / (int)this.numericUpDownRow.Value;

            switch (state)
            {
                case GridState.Empty:
                    this.graphics.FillRectangle(new SolidBrush(Control.DefaultBackColor), p.X * cellWidth, p.Y * cellHeight, cellWidth, cellHeight);
                    this.graphics.DrawRectangle(gridPen, p.X * cellWidth, p.Y * cellHeight, cellWidth, cellHeight);
                    if (this.gridStates[p.Y, p.X] == GridState.Start)
                    {
                        this.startPoint = Point.Empty;
                    }
                    else if (this.gridStates[p.Y, p.X] == GridState.Terminal)
                    {
                        this.termPoint = Point.Empty;
                    }

                    break;
                case GridState.Start:
                    if (this.startPoint.IsEmpty)
                    {
                        this.startPoint = new Point(p.X, p.Y);
                        this.graphics.FillRectangle(this.startBrush, p.X * cellWidth, p.Y * cellHeight, cellWidth, cellHeight);
                    }
                    else
                    {
                        MessageBox.Show("只能设置一个Start");
                    }
                    break;
                case GridState.Terminal:
                    if (this.termPoint.IsEmpty)
                    {
                        this.termPoint = new Point(p.X, p.Y);
                        this.graphics.FillRectangle(this.terminalBrush, p.X * cellWidth, p.Y * cellHeight, cellWidth, cellHeight);
                    }
                    else
                    {
                        MessageBox.Show("只能设置一个End");
                    }
                    break;
                case GridState.Occupied:
                    this.graphics.FillRectangle(this.barrialBrush, p.X * cellWidth, p.Y * cellHeight, cellWidth, cellHeight);
                    break;

                case GridState.Trace:
                    this.graphics.FillRectangle(this.traceBrush, p.X * cellWidth, p.Y * cellHeight, cellWidth, cellHeight);
                    break;
                default:
                    break;
            }

            this.gridStates[p.Y, p.X] = state;
            this.pictureBox1.Image = this.map;
        }
    }

    public abstract class Map
    {

    }
}
