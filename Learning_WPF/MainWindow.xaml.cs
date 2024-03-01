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

namespace Learning_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            bool biggerSelected = rbBig.IsChecked.Equals(true);
            bool smallerSelected = rbSmall.IsChecked.Equals(true);

            if (biggerSelected)
                MessageBox.Show("You selected bigger");

            else
                MessageBox.Show("You selected smaller");

        }
    }
}
