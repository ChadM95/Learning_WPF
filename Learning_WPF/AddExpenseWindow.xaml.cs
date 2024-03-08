using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Learning_WPF
{
    /// <summary>
    /// Interaction logic for AddExpenseWindow.xaml
    /// </summary>
    public partial class AddExpenseWindow : Window
    {
        public AddExpenseWindow()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAddExp_Click(object sender, RoutedEventArgs e)
        {
            //read in object data and 
            string type = cbxType.SelectedItem.ToString();

            decimal amt = Convert.ToDecimal(tbxAmt.Text);

            DateTime date = datePicker.SelectedDate.Value;

            //create new object
            Expense newExp = new Expense(type,amt,date);

            //reference main window
            MainWindow main = Owner as MainWindow;

            //add to collection
            main.expenses.Add(newExp);

            //close window
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            cbxType.ItemsSource = new string[] {"Travel","Office","Entertainment"} ;

        }
    }
}
