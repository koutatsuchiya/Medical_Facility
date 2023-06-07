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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public static string usernameGlobal;
        public static string passwordGlobal;
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Password;
            usernameGlobal = username;
            passwordGlobal = password;
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username không thể để trống!");
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password không thể để trống!");
            }

            //Dùng để đăng nhập nhanh (chỉ dùng khi test)
            bool isConnect = Utils.Connect(username, password);
            if (isConnect)
            {
                
                MessageBox.Show("Đăng nhập thành công!");
                if(username.Equals("DBA_CSYT"))
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                }
                else if (username.Contains("YBS"))
                {
                    Doctor doctor = new Doctor();
                    doctor.Show();
                }
                else if (username.Contains("NC"))
                {
                    NVCMainWindow nvcScreen = new NVCMainWindow();
                    nvcScreen.Show();
                }
                else if (username.Contains("BN"))
                {
                    BenhNhanMainWindow benhNhanScreen = new BenhNhanMainWindow();
                    benhNhanScreen.Show();
                }
                else if (username.Contains("TT"))
                {
                    ThanhTraMainWindow thanhTraScreen = new ThanhTraMainWindow();
                    thanhTraScreen.Show();
                }
                else if (username.Contains("CSYT"))
                {
                    CSYTMainWindow csytScreen = new CSYTMainWindow();
                    csytScreen.Show();
                }
                
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
        }
    }
}
