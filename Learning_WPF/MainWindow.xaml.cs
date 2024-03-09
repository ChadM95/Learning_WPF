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
using System.IO;

namespace Learning_WPF
{

    public partial class MainWindow : Window
    {
        //create collection
        public ObservableCollection<Book> books = new ObservableCollection<Book>();
        ObservableCollection<Book> matchingBooks = new ObservableCollection<Book>();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lbxBooks.ItemsSource = books;

            cbxFilter.ItemsSource = new string[] { "Fiction", "Non Fiction"};

        }
        
        //open new window to add new book
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //create new window reference
            AddBookWindow addBookWindow = new AddBookWindow();

            //set owner of new window
            addBookWindow.Owner = this;

            //open new window
            addBookWindow.ShowDialog();

        }

        //searches by title
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            //read search term
            string searchTerm = tbxSearch.Text;

            if (searchTerm != null)
            {
                //clear previous search results
                matchingBooks.Clear();

                //run through collection
                foreach (var book in books)
                { 
                    if(searchTerm == book.Title)

                    //add matches to new collection
                    matchingBooks.Add(book);

                    //display matches
                    lbxBooks.ItemsSource = matchingBooks;
                
                }
            }
        }

        private void btnShowAll_Click(object sender, RoutedEventArgs e)
        {
            lbxBooks.ItemsSource = books;
        }

        private void cbxFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //read selection
            string filterTerm = cbxFilter.SelectedValue.ToString();

            if (filterTerm != null)
            {
                //clear previous search results
                matchingBooks.Clear();

                foreach (var book in books)
                {
                    //compare to collection
                    if (filterTerm == book.Genre)
                    {
                        //add matches to new collection
                        matchingBooks.Add(book);
                    }
                }
                //change listbox display
                lbxBooks.ItemsSource = matchingBooks;
            }


        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            books.Clear();

        }
        
        //saves to JSON File
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //get json formatted objects
            string json = JsonConvert.SerializeObject(books, Formatting.Indented);

            //write to file
            using (StreamWriter sw = new StreamWriter(@"c:\temp\books.json"))
            {
                sw.Write(json);
            }
        }

        //Loads JSON File
        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {

            //read from file
            using (StreamReader sr = new StreamReader(@"c:\temp\books.json"))
            {
                string json = sr.ReadToEnd();
            

            //get objects from JSON
            books = JsonConvert.DeserializeObject<ObservableCollection<Book>>(json);
            
            }

            lbxBooks.ItemsSource = books;

        }
    }

}