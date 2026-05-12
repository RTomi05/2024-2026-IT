using System;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
using System.Security.Cryptography;
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

namespace vercukorNaplo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Entry> amitHozzaadok = new ObservableCollection<Entry>();
        public MainWindow()
        {
            InitializeComponent();
            datagrid.ItemsSource = amitHozzaadok;
        }

        private void kuldes_Click(object sender, RoutedEventArgs e)
        {
            bool mehet = true;
            try
            {
                if (string.IsNullOrEmpty(sorszam.Text) || string.IsNullOrEmpty(napszak.Text) || string.IsNullOrEmpty(etkezes.Text) || string.IsNullOrEmpty(ertek.Text))
                {
                    MessageBox.Show("Kérem töltse ki az összes mezőt!");
                    mehet = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt: " + ex.Message);
            }

            try
            {
                int napSorszamIde = int.Parse(sorszam.Text);
                if (napSorszamIde < 1 || napSorszamIde > 31)
                {
                    MessageBox.Show("A sorszámnak 1 és 30 között kell lennie!\nAdjon meg érvényes sorszámot!");
                    mehet = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kérem adjon meg egy érvényes számot a sorszám mezőbe!");
            }

            try
            {
                double ertekIde = double.Parse(ertek.Text);
                if (ertekIde < 0)
                {
                    MessageBox.Show("Az érték nem lehet negatív!\nAdjon meg érvényes értéket (0,0-40,0)!");
                    mehet = false;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Adjon meg érvényes értéket! (0,0-40,0)");
            }


            if (mehet)
            {
                string napszakText = (napszak.SelectedItem as ComboBoxItem)?.Content?.ToString() ?? "";
                string etkezesText = (etkezes.SelectedItem as ComboBoxItem)?.Content?.ToString() ?? "";
                double mertErtek = double.Parse(ertek.Text);
                int napSorszam = int.Parse(sorszam.Text);

                bool duplicate = amitHozzaadok.Any(x =>
                    x.Sorszam == napSorszam &&
                    string.Equals(x.Napszak, napszakText, System.StringComparison.OrdinalIgnoreCase) &&
                    string.Equals(x.Etkezes, etkezesText, System.StringComparison.OrdinalIgnoreCase)
                );

                if (duplicate)
                {
                    MessageBox.Show("Ugyanahhoz a naphoz, napszakhoz és alkalomhoz már van bejegyzés!");
                    return;
                }

                amitHozzaadok.Add(new Entry
                {
                    Sorszam = napSorszam,
                    Napszak = napszakText,
                    Etkezes = etkezesText,
                    Ertek = mertErtek
                });
            }
        }

        private void ertek_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
            double ertekIde = double.Parse(ertek.Text);
                if (ertekIde > 7.8)
                {
                    visszajelzes.Foreground = Brushes.Red;
                    visszajelzes.Content = "magas";
                }
                if (ertekIde < 3.9)
                {
                    visszajelzes.Foreground = Brushes.Red;
                    visszajelzes.Content = "alacsony";
                }
                if(ertekIde >= 3.9 && ertekIde <= 7.8)
                {
                    
                    visszajelzes.Content = "";
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public class Entry
        {
            public int Sorszam { get; set; }
            public string Napszak { get; set; }
            public string Etkezes { get; set; }
            public double Ertek { get; set; }
        }

        private void fajlbaMentes_Click(object sender, RoutedEventArgs e)
        {
            if (!amitHozzaadok.Any())
            {
                MessageBox.Show("Nincs mit menteni.");
            }

            try
            {
                List<string> lines = new List<string>();

                foreach (var item in amitHozzaadok)
                {
                    string line = $"{item.Sorszam},{item.Napszak},{item.Etkezes},{item.Ertek}";
                    lines.Add(line);
                }

                File.WriteAllLines("adatok.txt", lines, Encoding.UTF8);
                MessageBox.Show($"Mentve: adatok.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba: " + ex.Message);
            }
        }
    }
}