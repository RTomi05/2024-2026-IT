using System.IO;
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

namespace latin_tanc_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //1. feladat
            var adatok = File.ReadAllLines("tancrend.txt");
            List<Tanc> tancok = new List<Tanc>();
            var adatok2Chunk = adatok.Chunk(3).ToList();

            foreach (var adat in adatok2Chunk)
            {
                tancok.Add(new Tanc(adat.ToList()));
            }
            elsoTancKiir.Content = tancok[0].tancNev;
            utolsoTancKiir.Content = tancok[tancok.Count - 1].tancNev;

            int sambaSzamlalo = 0;
            sambaSzamlalo = tancok.Where(x => x.tancNev == "samba").Count();
        }

        private void legtobbTanc_Click(object sender, RoutedEventArgs e)
        {
            var psi = new System.Diagnostics.ProcessStartInfo("https://www.youtube.com/watch?v=9xp1XWmJ_Wo")
            {
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(psi);
        }
    }
}