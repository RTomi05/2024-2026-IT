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
            //MessageBox.Show("Adatok betöltve!");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            eredmeny3.Content = fuvarok.Count();
        }
    }
}