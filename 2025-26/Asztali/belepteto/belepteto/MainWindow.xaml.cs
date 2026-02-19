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
using System.IO;
using System.Text.RegularExpressions;

namespace belepteto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            betoltes();
        }

        List<Adat> adatok = new List<Adat>();

        void betoltes()
        {
            string[] sorok = File.ReadAllLines("bedat.txt");
            foreach (string egySor in sorok)
            {
                adatok.Add(new Adat(egySor));
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Name == "elsoGomb")
            {
                idopontSzoveg.Text = adatok.First().ido;
            }
            else if(rb.Name == "masodikGomb")
            {
                idopontSzoveg.Text = adatok.Last().ido;
            }
        }

        private void masodikGomb_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string innen = textbox.Text;
            string eddig = textbox1.Text;
            Regex idoMinta = new Regex(@"^([01]\d|2\d):[0-5]\d$");
            if(idoMinta.IsMatch(innen))
            {
                textbox.Foreground = Brushes.Black;
            }
            else if(!idoMinta.IsMatch(innen))
            {
                textbox.Foreground = Brushes.Red;
                textbox.Focus();

            }
        }
    }
}