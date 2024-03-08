﻿using System.Collections.ObjectModel;
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
        //create collection
        public ObservableCollection<Book> books = new ObservableCollection<Book>();

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
    }

}