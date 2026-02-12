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

namespace segedAblakos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int szamlalo = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window segedAblak = new ablak2();
            segedAblak.WindowStartupLocation = WindowStartupLocation.Manual;
            segedAblak.Left = 300; // Távolság a bal széltől
            segedAblak.Top = 300;  // Távolság a tetejétől
            segedAblak.Show();
            szamlalo++;
        }
    }
}