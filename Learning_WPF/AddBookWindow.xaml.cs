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
    /// Interaction logic for AddBookWindow.xaml
    /// </summary>
    public partial class AddBookWindow : Window
    {
        

        public AddBookWindow()
        {
            InitializeComponent();
        }

        private void addBook_Click(object sender, RoutedEventArgs e)
        {
            //reference main window as owner
            MainWindow main = Owner as MainWindow;

            //create new object
            string title = tbxTitle.Text;
            string genre = tbxGenre.Text;

            Book b1 = new Book(title,genre);

            //add object to collection
            main.books.Add(b1);

            //close this window
            this.Close();
        }
    }
}
