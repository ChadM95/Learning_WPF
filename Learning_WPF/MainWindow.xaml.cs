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
        //define collection
        ObservableCollection<Member> members = new ObservableCollection<Member>();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //populate combo box
            cbx1.ItemsSource = new string[] { "Full", "Off Peak", "Student", "OAP" };

            //populate listbox with collection
            lbxMembers.ItemsSource = members;

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

            string name = tbxName.Text;
            string type = (string)cbx1.SelectedItem ;

            //random date
            int year, month, day;
            Random random = new Random();

            year = random.Next(2000,2016);
            month = random.Next(1,13);
            day = random.Next(1,30);

            DateTime dateJoined = new DateTime(year,month,day);

            //create new object
            Member m1 = new Member(name,type,dateJoined);

            //add to collection
            members.Add(m1);

            //display number of members
            int noOfMembers = 0;

            foreach (Member m in members)
            {
                noOfMembers++;
            }


            tblkNoOfMembers.Text = Convert.ToString(noOfMembers);
        }




    }

}