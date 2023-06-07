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
    /// Interaction logic for AddRole.xaml
    /// </summary>
    public partial class AddRole : Window
    {
        public AddRole()
        {
            InitializeComponent();
        }

        private void AddRoleButton_Click(object sender, RoutedEventArgs e)
        {
            string sql = "alter session set \"_ORACLE_SCRIPT\"=true";
            Utils.ExcuteSql(sql);
            string role = RoleTextBox.Text;
            string password = PasswordTextBox.Password;
            if (password != "")
                sql = $"create role {role} identified by {password}";
            else
                sql = $"create role {role}";
            Utils.ExcuteSql(sql);
            MessageBox.Show($"Thêm role {role} thành công!");
            this.Close();
            Utils.LoadRolePage(MainWindow.rolePage);
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
