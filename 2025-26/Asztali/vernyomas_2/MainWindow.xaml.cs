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

namespace vernyomas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            try
            {
                File.ReadAllLines("adatok.txt");
                //MessageBox.Show("Adatok betöltve!");
            }
            catch (Exception ex)
            {
                File.WriteAllText("adatok.txt", string.Empty);
                MessageBox.Show("Adatok betöltve!");
            }


            //minden indításkor betölt egy fájlt DONE
            //minden adatbekéréskor felülírja azt a fájlt, hogy mindig aktuális legyen DONE
            //lehessen készíteni mentést a fájlról gombnyomásra DONE
            //a mentés fájl neve: save_datum_ido értékek DONE
            //adatok: dátumválasztó, napszak választó radio gomb, SYS, DIA, PULSE értékek DONE
            //beíráskor ellenőrizze, hogy a SYS, DIA, PULSE értékek számok-e, 40-nél alacsonyabb ne legyen egyik se DONE
            //mentéskor egy listBoxban jelenítse meg az adatokat (dátum szerint csökkenő sorrendben)
            //listaelemre kattintva töltse be az adatokat az űrlapba
        }

        private void rogzites_Click(object sender, RoutedEventArgs e)
        {
            bool mehet = true;
            try
            {
                int szisztoles = int.Parse(sys.Text);
                if (szisztoles < 40)
                {
                    MessageBox.Show("Adjon meg érvényes szisztolés értéket (40-299)");
                    mehet = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adjon meg érvényes szisztolés értéket! (40-299)");
            }
            try
            {
                int diasztoles = int.Parse(dia.Text);
                if (diasztoles < 40)
                {
                    MessageBox.Show("Adjon meg érvényes diasztolés értéket (40-299)");
                    mehet = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adjon meg érvényes diasztolés értéket! (40-299)");
            }
            try
            {
                int pulzus = int.Parse(pulse.Text);
                if (pulzus < 40)
                {
                    MessageBox.Show("Adjon meg érvényes pulzus értéket! (40-250)");
                    mehet = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adjon meg érvényes pulzus értéket! (40-250)");
            }
            
            MessageBox.Show(mehet.ToString());

            if (mehet)
            {
                File.AppendAllText("adatok.txt", $"{datumValaszto.SelectedDate.Value.ToShortDateString()};{(reggel.IsChecked == true ? "reggel" : "este")};{sys.Text};{dia.Text};{pulse.Text}" + System.Environment.NewLine);
            }
        }

        private void biztonsagiMentes_Click(object sender, RoutedEventArgs e)
        {
            File.Copy("adatok.txt", $"save_{DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss")}.txt");
        }
    }
}