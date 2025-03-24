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
        DispatcherTimer oraTimer = new DispatcherTimer();

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
            oraTimer.Interval = TimeSpan.FromSeconds(1);
            oraTimer.Tick += oraIdozit;
            oraTimer.Start();
            //oraRajzol(0, 0, 200);

        }

        void oraIdozit(object sender, EventArgs e)
        {
            oraRajzol(0, 0, 200);
        }

        void oraRajzol(int x, int y, int meret)
        {
            canvas.Children.Clear();
            int x1 = x + meret / 2;
            int y1 = y + meret / 2;
            szamlap(x, y, meret / 2);

            int ora = DateTime.Now.Hour;
            int perc = DateTime.Now.Minute;
            int mp = DateTime.Now.Second;

            mutato(x1, y1, "kismutató", (360/12*ora) - 90, (int)(meret / 2 * 0.5));
            mutato(x1, y1, "nagymutató", (360/60*perc) - 90, (int)(meret / 2 * 0.8));
            mutato(x1, y1, "másodpercmutató", (360/60*mp) - 90, (int)(meret / 2 * 0.95));
        }

        void mutato(int x, int y, string fajta, int szog, int hossz)
        {
            Line vonal = new Line();

            switch (fajta)
            {
                case "kismutató":
                    vonal.Stroke = Brushes.Blue;
                    vonal.StrokeThickness = 5;
                    break;
                case "nagymutató":
                    vonal.Stroke = Brushes.Green;
                    vonal.StrokeThickness = 4;
                    break;
                case "másodpercmutató":
                    vonal.Stroke = Brushes.Black;
                    vonal.StrokeThickness = 3;
                    break;
                default:
                    vonal.Stroke = Brushes.Red;
                    vonal.StrokeThickness = 1;
                    break;
            }

            double dY = hossz * Math.Sin(szog / 180.0 * Math.PI);
            double dX = hossz * Math.Cos(szog / 180.0 * Math.PI);


            vonal.X1 = x;
            vonal.Y1 = y;
            vonal.X2 = x + dX;
            vonal.Y2 = y + dY;

            canvas.Children.Add(vonal);
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

                double dY = r * Math.Sin(i * 30 / 180.0 * Math.PI);
                double dX = r * Math.Cos(i * 30 / 180.0 * Math.PI);

                /*
                double dY1 = (r - 10) * Math.Sin(i * 30 / 180.0 * Math.PI);
                double dX1 = (r - 10) * Math.Cos(i * 30 / 180.0 * Math.PI);
                double dY2 = (r + 10) * Math.Sin(i * 30 / 180.0 * Math.PI);
                double dX2 = (r + 10) * Math.Cos(i * 30 / 180.0 * Math.PI);
                */

                double kisR1 = 7 / 8.0 * r;
                double kisR2 = 9 / 8.0 * r;

                double dY1 = kisR1 * Math.Sin(i * 30 / 180.0 * Math.PI);
                double dX1 = kisR1 * Math.Cos(i * 30 / 180.0 * Math.PI);
                double dY2 = kisR2 * Math.Sin(i * 30 / 180.0 * Math.PI);
                double dX2 = kisR2 * Math.Cos(i * 30 / 180.0 * Math.PI);

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

            if (szogAllas >= 360)
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