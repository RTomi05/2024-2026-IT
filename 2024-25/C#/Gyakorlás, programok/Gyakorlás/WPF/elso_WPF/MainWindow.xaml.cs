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

namespace elso_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            listBox.ItemsSource = adatok;
        }

        List<string> adatok = new List<string>();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*
            string csere = nev.Text;
            nev.Text = jelszo.Text;
            jelszo.Text = csere;
            */

            adatok.Add(nev.Text + ":" + jelszo.Text);
        }
        /*
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
        */


    }
}