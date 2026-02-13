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

namespace szorzasos
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
        }

        private void kep_GotFocus(object sender, RoutedEventArgs e)
        { 
        }

        private void kep_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            int elsoSzam = int.Parse(elso.Text);
            int masodikSzam = int.Parse(masodik.Text);
            int harmadikSzam = int.Parse(harmadik.Text);
            int szorzat = 0;
            List<int> szamok = new List<int>() { elsoSzam, masodikSzam, harmadikSzam };

            szamok.Sort();
            szorzat = szamok[0] * szamok[1];
            kiiras.Content = $"A két legkisebb szám szorzata: {szorzat}";
        }

        private void kep_IsMouseDirectlyOverChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
        }
    }
}