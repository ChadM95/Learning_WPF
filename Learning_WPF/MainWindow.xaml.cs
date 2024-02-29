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
        bool running = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            //generate a random number
            int diceRoll;
            Random random = new Random();

            diceRoll = random.Next(0, 7);


            //display in textbox
            tb1.Text = diceRoll.ToString();

        }
    }
}
