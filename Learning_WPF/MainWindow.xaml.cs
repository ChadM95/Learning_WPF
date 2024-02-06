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
        public MainWindow()
        {
            InitializeComponent();
        }

        bool running = false;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (running)
            {
                //stop
                tbToggle.Text = "Stopped";
                btn.Content = "Run";
            }

            else
            {
                //run
                tbToggle.Text = "Running...";
                btn.Content = "Stop";
            }
#
            //flips boolean
            running = !running;
        }
    }
}