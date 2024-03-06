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
        //expenses collection
        ObservableCollection<Expense> expenses = new ObservableCollection<Expense>();

        //search matches collection
        ObservableCollection<Expense> matchingExpenses = new ObservableCollection<Expense>();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //listbox contents = expenses collection
            lbxExpenses.ItemsSource = expenses;

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //add new random expense
            string category;
            decimal amount;
            DateTime Date;

            //new random object
            Random rand = new Random();

            //category
            string[] categories = new string[] {"Travel","Office","Entertainment"};

            int i = rand.Next(0,3);
            category = categories[i];

            //amount
            amount = rand.Next(0,101);

            //date
            int year, month, day;

            year = rand.Next(2020,2024);
            month = rand.Next(1,12);
            day = rand.Next(1,31);

            Date = new DateTime(year,month,day);

            //create object
            Expense e1 = new Expense(category,amount,Date);

            //add to collection
            expenses.Add(e1);
        }

        //searches expenses by category
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            //read from screen
            string searchTerm = tbxSearch.Text;

            //clear collection
            matchingExpenses.Clear();
            
            if (!string.IsNullOrEmpty(searchTerm))
            {
                //search collection for matches

                foreach (var exp in expenses)
                {
                    string expenseType = exp.Category;

                    if (expenseType.Equals(searchTerm))
                    {
                        matchingExpenses.Add(exp);
                    }
                }

                //display matches on screen
                lbxExpenses.ItemsSource = matchingExpenses;
            }

        }

        private void btnShowAll_Click(object sender, RoutedEventArgs e)
        {
            lbxExpenses.ItemsSource = expenses;

        }
    }

}