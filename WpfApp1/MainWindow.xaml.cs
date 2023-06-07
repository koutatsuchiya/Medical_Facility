using System;
using System.ComponentModel;
using System.Data;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //BindingList<User> ListUsers = new BindingList<User>();
        public static UserPage userPage = new UserPage();
        public static RolePage rolePage = new RolePage();
        public static CSYTPage csytPage = new CSYTPage();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Main.Content = userPage;
            Utils.LoadUserPage(userPage);  
        }
        
        private void UserButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = userPage;
            Utils.LoadUserPage(userPage);
        }

        private void RoleButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = rolePage;
            Utils.LoadRolePage(rolePage);
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            Utils.Disconnect();
            Login loginScreen = new Login();
            loginScreen.Show();
            this.Close();
        }

        private void CSYTButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = csytPage;
            Utils.LoadCSYTPage(csytPage);
        }
    }
}
