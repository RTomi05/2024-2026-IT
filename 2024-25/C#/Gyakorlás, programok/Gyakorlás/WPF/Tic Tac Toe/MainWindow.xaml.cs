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

namespace WpfApp2
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

        string ezvoltelobb = "O";
        string[,] allas = new string[3, 3];

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;



            if (ezvoltelobb == "O")
            {
                b.Content = "X";
                ezvoltelobb = "X";
            }
            else
            {
                {
                    b.Content = "O";
                    ezvoltelobb = "O";
                }
            }


            b.IsEnabled = false;

            int index = Convert.ToInt32(b.Name.Substring(6));
            //MessageBox.Show(""+index);

            allas[index / 3, index % 3] = ezvoltelobb;



        }

        bool check()
        {
            int[,,] nyero = new int[,,] { 
                { 
                    { 0, 0 }, 
                    { 0, 1 }, 
                    { 0, 2 } 
                },
                { { 0, 0 }, { 0, 1 }, { 0, 2 } },
                { { 0, 0 }, { 0, 1 }, { 0, 2 } },             
            };


        }

    }
}