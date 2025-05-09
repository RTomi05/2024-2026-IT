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

namespace balkezesek
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

        List<Jatekos> jatekosok = new List<Jatekos>();

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            string[] sorok = File.ReadAllLines("balkezesek.csv");

            for (int i = 1; i < sorok.Length; i++)
            {
                jatekosok.Add(Jatekos.Factory(sorok[i]));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            szovegdoboz.Text = jatekosok.Count.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<string> elemek = new List<string>();
            
            for (int i = 0; i < jatekosok.Count; i++)
            {
                if (jatekosok[i].utolsoDatum < DateOnly.Parse("1999-11-01"))
                {
                    elemek.Add(jatekosok[i].nev + " " + jatekosok[i].magassagCentimeterben);
                }
            }
            listBox.ItemsSource = elemek;
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //label3.Content = textBox.Text;
            label3.Content = "";
            try
            {
                int szam = int.Parse(textBox.Text);
                if(szam < 1990 || szam > 1999)
                {
                    throw new Exception();
                }
            }
            catch 
            {
                label3.Content = "Hibás adat! Kérek egy 1990 és 1999 közötti évszámot!";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            List<int> sulyok = new List<int>();
            for (int i = 0;i < jatekosok.Count; i++)
            {
                if (jatekosok[i].jatszottE(int.Parse(textBox.Text)))
                {
                    sulyok.Add(jatekosok[i].suly);
                }
            }
        }
    }

}