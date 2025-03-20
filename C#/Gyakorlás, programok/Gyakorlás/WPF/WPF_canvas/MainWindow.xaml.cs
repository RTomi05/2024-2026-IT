using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WPF_canvas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        DispatcherTimer timer = new DispatcherTimer();

        private void canvas_Loaded(object sender, RoutedEventArgs e)
        {
            // Add a Line Element
            /*
            Line myLine = new Line();
            myLine.Stroke = Brushes.Red;
            myLine.X1 = 1;
            myLine.X2 = 50;
            myLine.Y1 = 1;
            myLine.Y2 = 50;
            //myLine.HorizontalAlignment = HorizontalAlignment.Left;
            //myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 5;
            canvas.Children.Add(myLine);
            */

            
            timer.Interval = TimeSpan.FromMilliseconds(40);
            timer.Tick += korRajzol;
            //timer.Start();
            /*
            for (int i = 0; i < 36; i++)
            {
                kor(100, 100, 100, i * 10);
                canvas.Children.Clear();
            }
            */

            szamlap(0, 0, 100);
        }
        void szamlap(int x, int y, int r)
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Width = 2 * r;
            ellipse.Height = 2 * r;
            ellipse.Stroke = Brushes.Black;
            ellipse.StrokeThickness = 5;
            ellipse.Margin = new Thickness(x, y, 0, 0);
            canvas.Children.Add(ellipse);

            for (int i = 0; i < 12; i++)
            {
                Line vonal = new Line();
                vonal.Stroke = Brushes.Black;
                vonal.X1 = x + r;
                vonal.Y1 = y + r;

                double dY = r * Math.Sin(i * 30 / 180.0 * Math.PI);
                double dX = r * Math.Cos(i * 30 / 180.0 * Math.PI);

                /*
                double dY1 = (r - 10) * Math.Sin(i * 30 / 180.0 * Math.PI);
                double dX1 = (r - 10) * Math.Cos(i * 30 / 180.0 * Math.PI);
                double dY2 = (r + 10) * Math.Sin(i * 30 / 180.0 * Math.PI);
                double dX2 = (r + 10) * Math.Cos(i * 30 / 180.0 * Math.PI);
                */

                double dY1 = 7 / 8.0 * r * Math.Sin(i * 30 / 180.0 * Math.PI);
                double dX1 = 7 / 8.0 * r * Math.Cos(i * 30 / 180.0 * Math.PI);
                double dY2 = 9 / 8.0 * r * Math.Sin(i * 30 / 180.0 * Math.PI);
                double dX2 = 9 / 8.0 * r * Math.Cos(i * 30 / 180.0 * Math.PI);

                vonal.X2 = x + r + dX;
                vonal.Y2 = y + r + dY;

                vonal.X1 = x + r + dX1;
                vonal.Y1 = y + r + dY1;
                vonal.X2 = x + r + dX2;
                vonal.Y2 = y + r + dY2;


                canvas.Children.Add(vonal);
            }
        }

        int szogAllas = 0;

        void korRajzol(object sender, EventArgs e)
        {
            canvas.Children.Clear();
            kor(100, 100, 100, szogAllas * 10);
            
            szogAllas++;
            
            if(szogAllas >= 360)
            {
                szogAllas -= 360;
                timer.Stop();
            }
            
        }

        void kor(int x, int y, int sugar, int szog)
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Width = 2 * sugar;
            ellipse.Height = 2 * sugar;
            ellipse.Stroke = Brushes.Blue;
            ellipse.Margin = new Thickness(x, y, 0, 0);
            canvas.Children.Add(ellipse);

            Line vonal = new Line();
            vonal.Stroke = Brushes.Black;
            vonal.X1 = x + sugar;
            vonal.Y1 = y + sugar;

            double dY = sugar * Math.Sin(szog / 180.0 * Math.PI);
            double dX = sugar * Math.Cos(szog / 180.0 * Math.PI);

            vonal.X2 = x + sugar + dX;
            vonal.Y2 = y + sugar + dY;


            canvas.Children.Add(vonal);

            //Hf.: Olyan képlet / URL, ami a koordinátás rajzolásra, vonalak, szögek kapcsán (45 fokos sugár pl.) működik
        }
    }
}