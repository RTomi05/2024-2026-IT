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

namespace WPF_valami
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// nevek bekérése, mentsük el fájlba, gombnyomásra töltsük be sorba rendezve
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nev = textbox1.Text;

            StreamWriter sw  = new StreamWriter("nevek.txt", true, Encoding.UTF8);
            sw.WriteLine(nev);
            sw.Close();
            /*
            listbox1.Items.Add(nev);
            textbox1.Text = "";   
            */
            textbox1.Clear();
        }

        private void betoltes_Click(object sender, RoutedEventArgs e)
        {
               string[] nevek = File.ReadAllLines("nevek.txt", Encoding.UTF8);
            listbox1.Items.Clear();
            Array.Sort(nevek);
            foreach (string nev in nevek)
            {
                listbox1.Items.Add(nev);
            }
        }

        private void torles_Click(object sender, RoutedEventArgs e)
        {
            File.Delete("nevek.txt");
            listbox1.Items.Clear();
        }
    }
}