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

namespace kockaDobas
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

        Random rand = new Random();
        private void kezdes_Click(object sender, RoutedEventArgs e)
        {
            int dobasokSzama = Convert.ToInt32(dobasSzam.Text);
            int osszeg = 0;
            int panni = 0;
            int anni = 0;
            int hanyszorFutottLe = 0;
            asztal.Children.Clear();
            hanyszorFutottLe = 0;
            for (int i = 0; i < dobasokSzama; i++)
            {
                string plusz = "+";
                WrapPanel panel = new WrapPanel();
                panel.Orientation = Orientation.Horizontal;
                for (int j = 0; j < 3; j++)
                {
                    int kocka = rand.Next(1, 7);
                    osszeg += kocka;
                    Image kep = new Image();
                    kep.Height = 50;
                    kep.Width = 50;
                    kep.Source = new BitmapImage(new Uri($"/images/kocka{kocka}.jpg", UriKind.Relative));
                    panel.Children.Add(kep);
                    if (j < 2)
                    {
                        panel.Children.Add(new Label() { Content = plusz, FontSize = 24, VerticalAlignment = VerticalAlignment.Center });
                        
                    }
                    else
                    {
                        panel.Children.Add(new Label() { Content = "=", FontSize = 24, VerticalAlignment = VerticalAlignment.Center });
                    }
                }
                if(osszeg >= 10)
                {
                    panni++;
                }
                else
                {
                anni++;
                }
                hanyszorFutottLe += 1;
                panel.Children.Add(new Label() { Content = osszeg, FontSize = 24, VerticalAlignment = VerticalAlignment.Center });
                osszeg = 0;
                asztal.Children.Add(panel);
            }
            //MessageBox.Show($"Hányszor futott le a ciklus? {hanyszorFutottLe}");
            MessageBox.Show($"Panni: {panni} db\nAnni: {anni} db");
            if (panni > anni)
            {
                MessageBox.Show("Panni nyert!");
            }
            else if (anni > panni)
            {
                MessageBox.Show("Anni nyert!");
            }
            else
            {
                MessageBox.Show("Döntetlen!");
            }
            asztal.Children.Add(new Label() { Content = "Anni: " + anni, FontSize = 24, VerticalAlignment = VerticalAlignment.Center });
            asztal.Children.Add(new Label() { Content = "Panni: " + panni, FontSize = 24, VerticalAlignment = VerticalAlignment.Center });
        }
    }
}