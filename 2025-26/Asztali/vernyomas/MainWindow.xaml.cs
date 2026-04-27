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
        }

        private void rogzites_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(sorszam.Text) || string.IsNullOrEmpty(napszak.Text) || string.IsNullOrEmpty(sys.Text) || string.IsNullOrEmpty(dia.Text) || string.IsNullOrEmpty(pulse.Text))
                {
                    MessageBox.Show("Kérem töltse ki az összes mezőt!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt az adatok ellenőrzése során: " + ex.Message);
            }
            try
            {
                int napSorszam = int.Parse(sorszam.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adjon meg érvényes nap sorszámot! (1-31)");
            }
            try
            {
                int szisztoles = int.Parse(sys.Text);
                if(szisztoles < 0 )
                {
                    MessageBox.Show("A szisztolés érték nem lehet negatív!\nAdjon meg érvényes értéket (1-299)");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adjon meg érvényes szisztolés értéket! (1-299)");
            }
            try
            {
                int diasztoles = int.Parse(dia.Text);
                if (diasztoles < 0)
                {
                    MessageBox.Show("A diasztolés érték nem lehet negatív!\nAdjon meg érvényes értéket (1-299)");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adjon meg érvényes diasztolés értéket! (1-299)");
            }
            try
            {
                int pulzus = int.Parse(pulse.Text);
                if (pulzus < 0)
                {
                    MessageBox.Show("A pulzus érték nem lehet negatív!\nAdjon meg érvényes értéket (30-250)");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adjon meg érvényes pulzus értéket! (30-250)");
            }
        }
    }
}