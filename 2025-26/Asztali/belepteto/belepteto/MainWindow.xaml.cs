using belepteto;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace belepteto_erettsegi_feladat
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
        List<string> kesok = new List<string>();
        void betoltes()
        {
            string[] sorok = File.ReadAllLines("bedat.txt");

            foreach (var sor in sorok)
            {
                adatok.Add(new Adat(sor));
            }



        }

        private void Elso_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radio = sender as RadioButton;

            if (radio.Name == "Elso")
            {
                kiir2.Text = adatok.First().ido;

            }

            if (radio.Name == "Utolso")
            {
                kiir2.Text = adatok.Last().ido;
            }

        }

        private void kereses_Click(object sender, RoutedEventArgs e)
        {
            bool isGood = true;

            string innen = Innen.Text;

            string idaig = Idaig.Text;



            Regex minta = new Regex(@"^([01]?\d|2[0-3]):[0-5]\d$");


            if (minta.IsMatch(innen))
            {
                Innen.Foreground = Brushes.Black;
            }
            else
            {
                Innen.Foreground = Brushes.Red;
                Innen.Focus();
                isGood = false;
            }

            if (minta.IsMatch(idaig))
            {
                Idaig.Foreground = Brushes.Black;


            }
            else
            {
                Idaig.Foreground = Brushes.Red;
                Idaig.Focus();
                isGood = false;
            }

            kesok = adatok.Where(adat => adat >= innen && adat <= idaig).Select(x => x.ido + " " + x.kod).ToList();

            listView.ItemsSource = kesok;

        }

        private void fajlbaIr_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllLines("kesok.txt", kesok.ToArray());

            MessageBox.Show("Sikeres mentés!\nFájl létrehozva!");
        }

        enum kodok
        {
            Belepes = 1,
            Kilepes = 2,
            Menza = 3,
            Konyvtar = 4
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox elem = sender as ComboBox;

            var eredmeny = adatok.Where(e => e.esemenyKod == elem.SelectedIndex + 1).ToList();

            szama.Text = eredmeny.Count().ToString();

        }
    }


}