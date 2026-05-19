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

namespace varosiAutozas
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

        List <Gyorsulas> gyorsulasok = new List<Gyorsulas>();

        private void kuldes_Click(object sender, RoutedEventArgs e)
        {
            gyorsulasok.Clear();
            string azonosito = azon.Text;
            string[] sorok = File.ReadAllLines(azonosito+".txt");
            foreach (string s in sorok)
            {
                gyorsulasok.Add(new Gyorsulas(s,gyorsulasok.LastOrDefault(new Gyorsulas(0,0,0))));
            }
        }

        private void f2Lekeres_Click(object sender, RoutedEventArgs e)
        {
            indulas.Text = gyorsulasok.First().kezdes.ToString() + " s";
            vegsebesseg.Text = gyorsulasok.Last().sebesseg.ToString() + " m/s";
        }

        private void f3Ellenorzes_Click(object sender, RoutedEventArgs e)
        {
            bool atlepte = gyorsulasok.Where(e => e.sebesseg > 14).Count() > 0;
            atlepteE.Text = atlepte ? "Igen" : "Nem";
        }

        private void f4Kuldes_Click(object sender, RoutedEventArgs e)
        {
            var allas = new { kezdet = 0, veg = 0, tartam = 0};
            for(int i  = 0; i < gyorsulasok.Count; i++)
            {
                if (gyorsulasok[i].sebesseg == 0)
                {
                    int tartam = gyorsulasok[i + 1].kezdes - gyorsulasok[i].veg;
                    if(allas.tartam < tartam)
                    {
                        allas = new
                        {
                            kezdet = gyorsulasok[i].veg,
                            veg = gyorsulasok[i + 1].kezdes,
                            tartam = tartam
                        };
                    }
                    
                }
            }
            allasido.Text = $"{allas.kezdet} és {allas.veg} között volt.";
        }

        private void f5Szamitas_Click(object sender, RoutedEventArgs e)
        {
            int ido = int.Parse(idopont.Text);
            var keresett = gyorsulasok.Where(e => (
                (ido >= e.kezdes
                && ido <= e.veg)
                || (e.elozo.veg <= ido
                && e.kezdes >= ido))).ToList();
            if (keresett.Count > 0)
            {
                seb.Text = keresett.First().pillanatnyiSebesseg(ido).ToString() + " m/s";
            }
        }
    }
}