using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace 卡尔曼滤波
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        List<System.Windows.Shapes.Line> shapes = new List<System.Windows.Shapes.Line>();
        
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Draw_Click(object sender, RoutedEventArgs e)
        {
            Line a = new Line();
            a.Stroke = Brushes.CadetBlue;
            a.StrokeLineJoin = PenLineJoin.Round;
            a.StrokeThickness = 4;
            a.X1 = 30;
            a.X2 = 60;
            a.Y1 = 30;
            a.Y2 = 60;
            this.shapes.Add(a);
            this.canvas.Children.Add(a);
        }
    }
}
