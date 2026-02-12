using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace segedAblakos
{
    /// <summary>
    /// Interaction logic for ablak2.xaml
    /// </summary>
    public partial class ablak2 : Window
    {
        public ablak2()
        {
            InitializeComponent();
        }

        private void bezarGomb_Click(object sender, RoutedEventArgs e)
        {
            //ablak2 bezárása
            this.Close();
        }
    }
}
