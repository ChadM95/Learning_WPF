using System.Collections.ObjectModel;
using System.Reflection;
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

    public partial class MainWindow : Window
    {
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //populate combo box
            cbx1.ItemsSource = new string[] { "Full", "Off Peak", "Student", "OAP" };


        }
    }

}