using System;
using System.ComponentModel;
using System.Data;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for BenhNhanMainWindow.xaml
    /// </summary>
    public partial class ThanhTraMainWindow : Window
    {
        public static ThanhTraPage thanhTraPage;
        public ThanhTraMainWindow()
        {
            InitializeComponent();
            //bool isConnect = Utils.Connect("TT2", "TT2");
            //test conn with BN1
            //Utils.Connect("TT2", "TT2");
            //remove this part when u combine the code
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                thanhTraPage = new ThanhTraPage(1);
                Main.Content = thanhTraPage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            Utils.Disconnect();
            Login loginScreen = new Login();
            loginScreen.Show();
            Close();
        }

        private void hsbaButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                thanhTraPage = new ThanhTraPage(1);
                Main.Content = thanhTraPage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void hsba_dvButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                thanhTraPage = new ThanhTraPage(2);
                Main.Content = thanhTraPage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bnButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                thanhTraPage = new ThanhTraPage(3);
                Main.Content = thanhTraPage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void csytButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                thanhTraPage = new ThanhTraPage(4);
                Main.Content = thanhTraPage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nvButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                thanhTraPage = new ThanhTraPage(5);
                Main.Content = thanhTraPage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
