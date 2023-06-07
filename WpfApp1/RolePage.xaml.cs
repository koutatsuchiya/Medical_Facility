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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for RolePage.xaml
    /// </summary>
    public partial class RolePage : Page
    {
        public RolePage()
        {
            InitializeComponent();
        }

        private void AddRoleButton_Click(object sender, RoutedEventArgs e)
        {
            var addRoleScreen = new AddRole();
            addRoleScreen.Show();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string keyword = keywordTextbox.Text;
            Utils.LoadRolePage(MainWindow.rolePage, keyword);
        }


        private void DropRoleButton_Click(object sender, RoutedEventArgs e)
        {
            string sql = "alter session set \"_ORACLE_SCRIPT\"=true";
            Utils.ExcuteSql(sql);
            string role = (sender as Button).Tag.ToString();
            sql = $"drop role \"{role}\"";
            Utils.ExcuteSql(sql);
            MessageBox.Show($"Xóa role {role} thành công!");
            Utils.LoadRolePage(MainWindow.rolePage);
        }

        private void AllPrivilegeButton_Click(object sender, RoutedEventArgs e)
        {
            string role = (sender as Button).Tag.ToString();
            AllPrivilegeOfRole allPrivilegeOfRolecreen = new AllPrivilegeOfRole(role);
            allPrivilegeOfRolecreen.Show();
        }
    }
}
