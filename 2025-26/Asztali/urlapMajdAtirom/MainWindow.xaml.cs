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

namespace urlapMajdAtirom
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //minden indításkor betölt egy fájlt
            //minden adatbekéréskor felülírja azt a fájlt, hogy mindig aktuális legyen
            //lehessen készíteni mentést a fájlról gombnyomásra
            //a mentés fájl neve: save_datum_ido értékek
            //adatok: dátumválasztó, napszak választó radio gomb, SYS, DIA, PULSE értékek
            //beíráskor ellenőrizze, hogy a SYS, DIA, PULSE értékek számok-e, 40-nél alacsonyabb ne legyen egyik se
            //mentéskor egy listBoxban jelenítse meg az adatokat (dátum szerint csökkenő sorrendben)
            //listaelemre kattintva töltse be az adatokat az űrlapba
        }
    }
}