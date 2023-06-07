using System;
using System.ComponentModel;
using System.Data;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for BenhNhanMainWindow.xaml
    /// </summary>
    public partial class BenhNhanMainWindow : Window
    {
        public static BenhNhanPage benhNhanPage = new BenhNhanPage();
        public BenhNhanMainWindow()
        {

            InitializeComponent();
            //bool isConnect = Utils.Connect("BN2", "BN2");
            Utils.loadPatient(benhNhanPage);
            //test conn with BN1
            //Utils.Connect("BN2", "BN2");
            //remove this part when u combine the code
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                Main.Content = benhNhanPage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void xem_suaButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Utils.loadPatient(benhNhanPage);
                Main.Content = benhNhanPage;
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

    }
}
