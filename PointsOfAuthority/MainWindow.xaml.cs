using System.IO;
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

namespace PointsOfAuthority
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SkibidiReserve SkibidiReserve { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            kapcsolo.Visibility = Visibility.Collapsed;
            SkibidiReserve = new SkibidiReserve();
            this.DataContext = SkibidiReserve;
        }

        private void checkbox_Checked(object sender, RoutedEventArgs e)
        {
            kapcsolo.Visibility = Visibility.Visible;
        }

        private void checkbox_Unchecked(object sender, RoutedEventArgs e)
        {
            kapcsolo.Visibility = Visibility.Collapsed;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SkibidiReserve.Save(checkbox);
        }
    }
}