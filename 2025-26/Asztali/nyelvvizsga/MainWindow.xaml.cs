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

namespace nyelvvizsga
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

        List<Nyelv> sikeres = new List<Nyelv>();
        List<Nyelv> sikertelen = new List<Nyelv>();
        void betolt()
        {
            string[] sorok = File.ReadAllLines("sikeres.csv");
            foreach (string s in sorok.Skip(1))
            {
                sikeres.Add(new Nyelv(s));
            }

            sorok = File.ReadAllLines("sikertelen.csv");
            foreach (string s in sorok.Skip(1))
            {
                sikeres.Add(new Nyelv(s));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Dictionary<string, int> nyelvOsszes = new Dictionary<string, int>();
            foreach(Nyelv s in sikeres)
            {
                nyelvOsszes.Add(s.nyelv, s.osszesen());
            }
            foreach (Nyelv s in sikertelen)
            {
                nyelvOsszes[s.nyelv] += s.osszesen();
            }
            var eredmeny = nyelvOsszes.OrderByDescending(x => x.Value)
                                      .ToList();
            /*
            foreach(var nyelv in nyelvOsszes.Keys)
            {

            }
            */
        }
    }
}