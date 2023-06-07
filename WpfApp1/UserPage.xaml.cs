using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        public UserPage()
        {
            InitializeComponent();
        }

        private void AddUserButton_Click(object sender, RoutedEventArgs e)
        {
            var addUserScreen = new AddUser();
            addUserScreen.Show();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string keyword = keywordTextbox.Text;
            Utils.LoadUserPage(MainWindow.userPage, keyword);
        }

        private void DropUserButton_Click(object sender, RoutedEventArgs e)
        {
            string sql = "alter session set \"_ORACLE_SCRIPT\"=true";
            Utils.ExcuteSql(sql);
            string username = (sender as Button).Tag.ToString();
            sql = $"drop user \"{username}\"";
            Utils.ExcuteSql(sql);
            MessageBox.Show($"Xóa user {username} thành công!");
            Utils.LoadUserPage(MainWindow.userPage);
        }

        private void AllPrivilegeButton_Click(object sender, RoutedEventArgs e)
        {
            string username = (sender as Button).Tag.ToString();
            AllPrivilegeOfUser allPrivilegeOfUserScreen = new AllPrivilegeOfUser(username);
            allPrivilegeOfUserScreen.Show();
        }

        private void UserInformationButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
