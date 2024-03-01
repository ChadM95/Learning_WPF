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
        //random object
        Random random = new Random();
        int randomNum1, randomNum2;

        //start game button click event
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            randomNum1 = random.Next(0,21);
            answer1.Text = Convert.ToString(randomNum1);

        }


        //second number button click event
        private void btnGuess_Click(object sender, RoutedEventArgs e)
        {
            randomNum2 = random.Next(0, 21);
            answer2.Text = Convert.ToString(randomNum2);


            //check radio buttons against answer

            bool biggerSelected = rbBigger.IsChecked.Equals(true);
            bool smallerSelected = rbSmaller.IsChecked.Equals(true);

            if (biggerSelected && randomNum1 < randomNum2)
                MessageBox.Show("YOU WIN!!");
            else if (biggerSelected && randomNum1 > randomNum2)
                MessageBox.Show("YOU LOSE!!");
            else if (smallerSelected && randomNum1 > randomNum2)
                MessageBox.Show("YOU WIN!!");
            else if (smallerSelected && randomNum1 < randomNum2)
                MessageBox.Show("YOU LOSE!!");

        }

    }
}
