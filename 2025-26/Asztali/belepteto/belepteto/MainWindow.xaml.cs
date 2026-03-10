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
using System.Windows.Threading;

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

            if (elem.Name == "bal")
            {
                elso.Content = eredmeny.Count().ToString();
            }
            else
            {
                masodik.Content = eredmeny.Count().ToString();
            }
            if (elso.Content != "" && masodik.Content != "")
            {
                if (Convert.ToInt32(elso.Content) > Convert.ToInt32(masodik.Content))
                {
                    relacioJel.Content = ">";
                }
                else if (Convert.ToInt32(elso.Content) < Convert.ToInt32(masodik.Content))
                {
                    relacioJel.Content = "<";
                }
                else
                {
                    relacioJel.Content = "=";
                }
            }
        }
        private void id10t_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Mávos Bazsi megjelent");
        }
            DispatcherTimer timer;
        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += suliBelepes;
            timer.Start();

        }

        int aktualisIdo = 7*60+0;
        int lepes = 10; //perc
        void suliBelepes(object sender, EventArgs e)
        {
            var bement = adatok.Where(a => a <= aktualisIdo).ToList();
            szamlalo.Content = bement.Count();
            diakokBelep.ItemsSource = bement;
            ora.Content = (aktualisIdo / 60).ToString() + ":" + (aktualisIdo % 60).ToString();

            aktualisIdo += lepes;
            if(aktualisIdo > 19*60)
            {
                aktualisIdo = 7 * 60;
            }
        }
    }


}