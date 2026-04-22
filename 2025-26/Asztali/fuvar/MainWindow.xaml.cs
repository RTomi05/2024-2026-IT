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

namespace fuvar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            betolt();
        }

        List<Fuvar> fuvarok = new List<Fuvar>();
        void betolt()
        {
            string[] sorok = File.ReadAllLines("fuvar.csv");
            foreach (string sor in sorok.Skip(1))
            {
                Fuvar f = new Fuvar(sor);
                fuvarok.Add(f);
            }

            //taxiValaszto

            var taxisok = fuvarok
                .Select(x => x.azonosito)
                .Distinct()
                .OrderBy(e => e)
                .ToList();
            taxiValaszto.ItemsSource = taxisok;

            //MessageBox.Show("Adatok betöltve!");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            eredmeny3.Content = fuvarok.Count();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox kuldo = sender as ComboBox;
            //MessageBox.Show(kuldo.SelectedItem.ToString());

            double penz = 0;
            penz = fuvarok
                .Where(x => x.azonosito == (int)kuldo.SelectedItem)
                .Sum(x => x.viteldij + x.borravalo);
            eredmeny4Bevetel.Content = penz;
            eredmeny4Fuvarszam.Content = fuvarok.Where(x => x.azonosito == (int)kuldo.SelectedItem).Count();
        }
    }
}