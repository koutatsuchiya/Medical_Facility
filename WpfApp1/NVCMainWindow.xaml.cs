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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for NVCMainWindow.xaml
    /// </summary>
    public partial class NVCMainWindow : Window
    {
        public static NCV_Profile Profile = new NCV_Profile();
        public static NCV_HSBA hsba = new NCV_HSBA();
        public NVCMainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Main.Content = Profile;
            //Utils.LoadUserPage(Profile);  
        }
        private void ProfileButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = Profile;
            //Utils.LoadUserPage(Profile);
        }

        private void HSBAButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = hsba;
            //Utils.LoadRolePage(rolePage);
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            Utils.Disconnect();
            Login loginScreen = new Login();
            loginScreen.Show();
            this.Close();
        }
    }
    
}
