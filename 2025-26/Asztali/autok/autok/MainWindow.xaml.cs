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
            /*
         * Állapítsa meg, hogy milyen időpontban történt a legutolsó jeladás, és írja a képernyőre
           az időpontot, valamint az utoljára jelet adó autó rendszámát!
         */
            AutoAdat utolso = adatok.Last();
            utolsoJeladasErtek.Text = $" {utolso.rendszam}, {utolso.ora} : {utolso.perc}";
        }

        private void elsokentJarmu_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void ElsokentJarmuGomb_Click(object sender, RoutedEventArgs e)
        {
            /*
             * Írja ki a bemeneti állományban elsőként szereplő jármű rendszámát, valamint azt, hogy
               milyen időpontokban adott jelzést! Az időpontokat óra:perc formátumban, szóközzel
               elválasztva, egy sorban jelenítse meg!
             */
            AutoAdat elso = adatok.First();
            foreach (var item in adatok)
            {
                if (item.rendszam == elso.rendszam)
                {
                    elsokentJarmu.Text += $" {item.ora}:{item.perc} ";
                }
            }
        }
    }
}