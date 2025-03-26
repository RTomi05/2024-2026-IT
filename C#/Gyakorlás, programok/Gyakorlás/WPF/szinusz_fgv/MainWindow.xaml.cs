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

namespace szinusz_fgv
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    /// https://www.youtube.com/watch?v=Q55T6LeTvsA
    /// 
    /// Amiket meg kell csinálnunk:
    /// -koordináta-rendszer
    /// -körív
    /// -magasság (szinuszérték / piros függőleges vonal
    /// -nagy, vékony keretes kör
    /// fekete pont (aktuális x hely)
    /// -belső szög körív
    /// -fekete sugár
    /// -kék vízszintes, vastag vonal
    /// -infodoboz


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sinus_Loaded(object sender, RoutedEventArgs e)
        {
            /// Amiket meg kell csinálnunk:
            /// -koordináta-rendszer
            /// -körív
            /// -magasság (szinuszérték / piros függőleges vonal
            /// -nagy, vékony keretes kör
            /// fekete pont (aktuális x hely)
            /// -belső szög körív
            /// -fekete sugár
            /// -kék vízszintes, vastag vonal
            /// -infodoboz
            origoX = r;
            origoY = (int)(sinus.ActualHeight / 2);
            koordinataRendszer();

        }

        int origoX = 0;
        int origoY = 0;
        int r = 100;

        void koordinataRendszer()
        {
            Line xTengely = new Line();
            xTengely.Stroke = Brushes.Black;
            xTengely.X1 = 0;
            xTengely.Y1 = origoY;
            xTengely.X2 = sinus.ActualWidth;
            xTengely.Y2 = origoY;

            sinus.Children.Add(xTengely);

            Line yTengely = new Line();
            yTengely.Stroke = Brushes.Black;
            yTengely.X1 = origoX;
            yTengely.Y1 = 0;
            yTengely.X2 = origoX;
            yTengely.Y2 = sinus.ActualHeight;

            sinus.Children.Add(yTengely);
        }
    }
}