using System.Text;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace rgb_gyakorlas
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

            List<List<Pixel>> pixelek = new List<List<Pixel>>();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string[] sorok = File.ReadAllLines("kep-1.txt");
            for (int i = 0; i < sorok.Length; i++)
            {
                string[] vag = sorok[i].Split(" ");
                List<Pixel> temp = new List<Pixel>();
                for (int k = 0; k < vag.Length; k+=3)
                {
                    temp.Add(new Pixel(
                        int.Parse(vag[k]),
                        int.Parse(vag[k + 1]),
                        int.Parse(vag[k + 2])));
                }
                pixelek.Add(temp);
            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            }
            catch
            {

            }
            int sor = int.Parse(textBox.Text);
            int oszlop = int.Parse(textBox1.Text);
        }

    }
}