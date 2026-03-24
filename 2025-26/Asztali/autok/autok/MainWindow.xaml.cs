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
            string keresettRendszam = rendszamBeir.Text.Trim();
            var jarmuJelzesei = adatok.Where(a => a.rendszam == keresettRendszam).OrderBy(a => a.ora * 60 + a.perc).ToList();

            if (jarmuJelzesei.Count == 0)
            {
                rendszamJelzesei.Content = "Nincs ilyen rendszámú jármű a listában!";
                return;
            }

            double tav = 0.0;
            int elozoOra = jarmuJelzesei[0].ora;
            int elozoPerc = jarmuJelzesei[0].perc;
            rendszamJelzesei.Content += $"{jarmuJelzesei[0].ora}:{jarmuJelzesei[0].perc:00} - {tav:0.0} km\n";

            for (int i = 1; i < jarmuJelzesei.Count; i++)
            {
                int aktOra = jarmuJelzesei[i].ora;
                int aktPerc = jarmuJelzesei[i].perc;
                int elteltPerc = (aktOra - elozoOra) * 60 + (aktPerc - elozoPerc);
                double elteltOra = elteltPerc / 60.0;
                tav += jarmuJelzesei[i - 1].sebesseg * elteltOra;
                rendszamJelzesei.Content += $"{aktOra}:{aktPerc:00} - {tav:0.0} km\n";
                elozoOra = aktOra;
                elozoPerc = aktPerc;
            }
        }

        private void fajlLetrehozGomb_Click(object sender, RoutedEventArgs e)
        {
            var rendszamok = adatok.GroupBy(a => a.rendszam).Select(g => new
                {
                    Rendszam = g.Key,
                    Elso = g.OrderBy(x => x.ora * 60 + x.perc).First(),
                    Utolso = g.OrderBy(x => x.ora * 60 + x.perc).Last()
                });

            using (var sw = new System.IO.StreamWriter("ido.txt", false, Encoding.UTF8))
            {
                foreach (var jarmu in rendszamok)
                {
                    sw.WriteLine($"{jarmu.Rendszam} {jarmu.Elso.ora}:{jarmu.Elso.perc:00} {jarmu.Utolso.ora}:{jarmu.Utolso.perc:00}");
                }
            }
            fajlVisszajelez.Content = "Fájl létrehozva";
        }
    }
}