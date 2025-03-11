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

namespace Gyak_03._07
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<string> list = new List<string>();
            list.Add("Pá rizs!");
            list.Add("London-don-don-don");
            list.Add("AmstelDamn");
            list.Add("Kappanhágó");

            comboBox.ItemsSource = list;
        }



        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            szamHelye.Text = csuszka.Value.ToString();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                csuszka.Value = Convert.ToDouble(szamHelye.Text);
            }
            catch { 
            
            }
        }
    }
}