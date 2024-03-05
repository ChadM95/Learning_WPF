using System.Collections.ObjectModel;
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

        //define a collection
        ObservableCollection<Expense> expenses = new ObservableCollection<Expense>();
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Expense e1 = new Expense() { Category = "Travel", Cost = 50m, DateIncurred = new DateTime(2019 / 01 / 01) };
            Expense e2 = new Expense() { Category = "Entertainment", Cost = 60m, DateIncurred = new DateTime(2018 / 01 / 01) };
            Expense e3 = new Expense() { Category = "Office", Cost = 70m, DateIncurred = new DateTime(2020 / 01 / 01) };

            //add exoense objects to collection
            expenses.Add(e1);
            expenses.Add(e2);
            expenses.Add(e3);


            lbx1.ItemsSource = expenses;

        }

        //add new expense
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Expense e4 = new Expense() { Category = "Entertainment", Cost = 45, DateIncurred = new DateTime(2021 / 01 / 01) };

            expenses.Add(e4);
        }
    }

}
    