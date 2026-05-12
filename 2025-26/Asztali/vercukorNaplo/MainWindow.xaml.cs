using System.Data;
using System.Security.Cryptography;
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

namespace vercukorNaplo
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

        private void kuldes_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(sorszam.Text) || string.IsNullOrEmpty(napszak.Text) || string.IsNullOrEmpty(etkezes.Text) || string.IsNullOrEmpty(ertek.Text))
                {
                    MessageBox.Show("Kérem töltse ki az összes mezőt!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt: " + ex.Message);
            }

            try
            {
                int napSorszam = int.Parse(sorszam.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kérem adjon meg egy érvényes számot a sorszám mezőbe!");
            }

            try
            {
                double mertErtek = double.Parse(ertek.Text);
                if (mertErtek < 0)
                {
                    MessageBox.Show("Az érték nem lehet negatív!\nAdjon meg érvényes értéket (0,0-40,0)!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adjon meg érvényes értéket! (0,0-40,0)");
            }
        }
    }
}