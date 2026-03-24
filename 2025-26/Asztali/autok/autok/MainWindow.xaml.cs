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

namespace autok
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

        List<AutoAdat> adatok = new List<AutoAdat>();
        void betoltes()
        {
            string[] sorok = System.IO.File.ReadAllLines("jeladas.txt");

            foreach (var sor in sorok)
            {
                adatok.Add(new AutoAdat(sor));
            }
        }

        private void utolsoJeladasLekeres_Click(object sender, RoutedEventArgs e)
        {
            AutoAdat utolso = adatok.Last();
            utolsoJeladasErtek.Text = $" {utolso.rendszam}, {utolso.ora} : {utolso.perc}";
        }

        private void elsokentJarmu_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void ElsokentJarmuGomb_Click(object sender, RoutedEventArgs e)
        {
            AutoAdat elso = adatok.First();
            foreach (var item in adatok)
            {
                if (item.rendszam == elso.rendszam)
                {
                    elsokentJarmu.Text += $" {item.ora}:{item.perc} ";
                }
            }
        }

        private void idopontLekeres_Click_1(object sender, RoutedEventArgs e)
        {
            int ora = int.Parse(oraInput.Text);
            int perc = int.Parse(percInput.Text);
            int jeladasokSzama = 0;

            foreach (var item in adatok)
            {
                if (item.ora == ora)
                {
                    if (item.perc == int.Parse(percInput.Text))
                    {
                        jeladasokSzama++;
                        jeladasSzam.Text = jeladasokSzama.ToString();
                    }
                }
            }
        }

        private void jeladasSzam_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int maxSebesseg = 0;
            foreach (var item in adatok)
            {
                if (item.sebesseg > maxSebesseg)
                {
                    maxSebesseg = item.sebesseg;
                }
            }
            maxSebessegErtek.Content = maxSebesseg.ToString() + " km/h";
            foreach (var item in adatok)
            {
                if (maxSebesseg == item.sebesseg)
                {
                    legnagyobbalMent.Text += " " + item.rendszam;
                }
            }
        }

        private void rendszamLekeres_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in adatok)
            {
                if (item.rendszam == rendszamBeir.Text)
                {
                    foreach (var item2 in adatok)
                    {
                        if (item.rendszam == item2.rendszam)
                        {
                            rendszamJelzesei.Content += $" {item2.sebesseg}, {item2.ora}:{item2.perc} ";
                        }
                    }
                }
            }
        }
    }
}