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

            for (int i = 0; i < 36; i++)
            {
                kor(100, 100, 100, i * 10);
                canvas.Children.Clear();
                
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