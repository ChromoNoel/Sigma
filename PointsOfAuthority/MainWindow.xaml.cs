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
        public MainWindow()
        {
            InitializeComponent();
            kapcsolo.Visibility = Visibility.Collapsed;
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
            StreamWriter writer = new StreamWriter("adatok.txt", true);

            if (checkbox.IsChecked ?? true && Convert.ToInt32(szemszam.Text) != 0)
            {
                writer.WriteLine(nev.Text + ";" + kezd.Text + ";" + veg.Text + ";" + box.Text + ";" + szemszam.Text);
            } else
            {
                writer.WriteLine(nev.Text + ";" + kezd.Text + ";" + veg.Text + ";" + box.Text + ";0");
            }

            writer.Close();
        }
    }
}