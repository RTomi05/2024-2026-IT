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

namespace gombosCucc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// szövegbekérés és egy gomb, amire kattintva megjelenik egy labelben a bekért szöveg
    /// hf.: gomb -> nem engedi, elteleportál
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int marginErtek = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Label cimke = new Label();
            grid.Children.Remove(cimke);
            cimke.Content = szovegDoboz.Text;
            grid.Children.Add(cimke);
            cimke.FontSize = 30;
            cimke.Foreground = Brushes.Red;
            cimke.HorizontalAlignment = HorizontalAlignment.Center;
            cimke.VerticalAlignment = VerticalAlignment.Center;
            cimke.Margin = new Thickness(0,marginErtek,0,0);
            marginErtek += 50;
        }

        private void Button_IsMouseDirectlyOverChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            Background = Brushes.Green;
        }

        private void Button_MouseMove(object sender, MouseEventArgs e)
        {
            Background = Brushes.Red;
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Background
                = Brushes.Green;
        }
    }
}