using System.Collections.ObjectModel;
using System.IO;
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
using Newtonsoft.Json;

namespace Learning_WPF
{

    public partial class MainWindow : Window
    {
        //expenses collection
        public ObservableCollection<Expense> expenses = new ObservableCollection<Expense>();

        //search matches collection
        ObservableCollection<Expense> matchingExpenses = new ObservableCollection<Expense>();

        //Categories string array
        string[] categories = new string[] { "Travel", "Office", "Entertainment" };

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //listbox contents = expenses collection
            lbxExpenses.ItemsSource = expenses;


            //populate combo box
            cbxFilter.ItemsSource = categories;
        }

        //opens new window to add expense object
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //create new window object reference
            AddExpenseWindow addExp = new AddExpenseWindow();

            //give reference to new window
            addExp.Owner = this;

            //display new window
            addExp.ShowDialog();

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

        //reverts listbox back to showing all items
        private void btnShowAll_Click(object sender, RoutedEventArgs e)
        {
            lbxExpenses.ItemsSource = expenses;

        }

        //filters list
        private void cbxFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //determine what the user selected
            string selectedItem = cbxFilter.SelectedItem as string;

            if (selectedItem != null)
            {
                //clear previous search results collection
                matchingExpenses.Clear();

                //search collection for matches
                foreach (var exp in expenses)
                {
                    string expCategory = exp.Category;

                    if (expCategory == selectedItem)
                    {
                        //add matches to new collection
                        matchingExpenses.Add(exp);
                    }
                }

                //update display
                lbxExpenses.ItemsSource = matchingExpenses;
            }

        }

        //save expense objects / JSON
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //get string of objects - JSON formatted
            string json = JsonConvert.SerializeObject(expenses,Formatting.Indented);

            //write to file
            using (StreamWriter sw = new StreamWriter(@"c:\temp\expenses.json"))
            {
                sw.Write(json);
            }

        }

        //loads json file
        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            //connect to a file
            using (StreamReader sr = new StreamReader(@"c:\temp\expenses.json"))
            {
                //read text
                string json = sr.ReadToEnd();

                //convert from JSON to objects
                expenses = JsonConvert.DeserializeObject<ObservableCollection<Expense>>(json);

                //refresh display
                lbxExpenses.ItemsSource = expenses;

            }

        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            expenses.Clear();
        }
    }

}