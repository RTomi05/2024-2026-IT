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

namespace szamologep
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int kapottOsszeg = 0;
            int a = Convert.ToInt32(aSzam.Text);
            int b = Convert.ToInt32(bSzam.Text);

            kapottOsszeg = a + b;

            osszeg.Content = kapottOsszeg;
        }
    }
}