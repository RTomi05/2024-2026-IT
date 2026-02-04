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

namespace afeladatazlenne
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// Kérjünk be szöveget, de "a" karaktert nem fogadhat el!
    /// </summary>
    public partial class MainWindow : Window
    {
        private int hanyA = 0;
        private string hianyA = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            foreach (char c in textbox1.Text)
            {
                if (c == 'a' || c == 'A')
                {
                    textbox1.Text = textbox1.Text.Replace(c.ToString(), "");
                    hanyA++;
                    hianyA += c;
                }
                
                textbox1.SelectionStart = textbox1.Text.Length;
            }
        }

        private void kuldes_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text = "";
            hanyAkarakter.Content = $"Az 'a' karakterek száma: {hanyA}";
            hanyA = 0;
            aBetuk.Content = "";
        }

        private void textbox1_GotFocus(object sender, RoutedEventArgs e)
        {
            hanyAkarakter.Content = "";
            aBetuk.Content = "";
            hianyA = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(hianyA != "")
            {
                aBetuk.Content = $"Itt vannak na... {hianyA.ToUpper()}";
            }
            else
            {
                aBetuk.Content = "Sok értelme volt...";
            }
            
        }
    }
}