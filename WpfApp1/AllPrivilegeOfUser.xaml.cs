using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    /// Interaction logic for AllPrivilegeOfUser.xaml
    /// </summary>
    public partial class AllPrivilegeOfUser : Window
    {
        private string privilageRevoke = "";
        public AllPrivilegeOfUser(string username)
        {
            try
            {
                InitializeComponent();
                string sql = "select username, account_status, created from dba_users where username = '" + username + "'";
                DataTable table = Utils.GetDataToTable(sql);
                usernameTextBox.Text = table.Rows[0].Field<string>(0);
                statustextBox.Text = table.Rows[0].Field<string>(1);
                updatePrivilegeTables(username);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex);
            }
        }
        private void updatePrivilegeTables(string username)
        {
            Utils.LoadPrivileges("select", viewlistBox, username);
            // delete table
            Utils.LoadPrivileges("delete", deletelistBox, username);
            // update table
            Utils.LoadPrivileges("update", updatelistBox, username);
            // insert table
            Utils.LoadPrivileges("insert", insertlistBox, username);

            //role privilege
            Utils.LoadPrivileges("role", roleListBox, username);

            //sys privilege
            Utils.LoadPrivileges("sys", sysPrivilegeListBox, username);
        }


        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void GrantButton_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameTextBox.Text;
            GrantPrivilege grantPrivilegeScreen = new GrantPrivilege(username);
            grantPrivilegeScreen.Show();

            updatePrivilegeTables(username);
        }


        private void viewlistBox_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            string tableName = viewlistBox.SelectedItem as string;
            if (tableName != null)
            {
                privilageRevoke = $"REVOKE SELECT ON {tableName} FROM ";
                RevokeButton.IsEnabled = true;
            }
        }
        private void deletelistBox_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            string tableName = deletelistBox.SelectedItem as string;
            if (tableName != null)
            {
                privilageRevoke = $"REVOKE DELETE ON {tableName} FROM ";
                RevokeButton.IsEnabled = true;
            }
        }

        private void insertlistBox_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            string tableName = insertlistBox.SelectedItem as string;
            if (tableName != null)
            {
                privilageRevoke = $"REVOKE INSERT ON {tableName} FROM ";
                RevokeButton.IsEnabled = true;
            }
        }
        private void updatelistBox_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            string tableName = updatelistBox.SelectedItem as string;
            if (tableName != null)
            {
                privilageRevoke = $"REVOKE UPDATE ON {tableName} FROM ";
                RevokeButton.IsEnabled = true;
            }
        }
        private void sysPrivilegeListBox_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            string privilege = sysPrivilegeListBox.SelectedItem as string;
            if(privilege != null)
            {
                privilageRevoke = $"REVOKE {privilege} FROM ";
                RevokeButton.IsEnabled = true;
            }
        }
        private void roleListBox_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            string role = roleListBox.SelectedItem as string;
            if (role != null)
            {
                privilageRevoke = $"REVOKE {role} FROM ";
                RevokeButton.IsEnabled = true;
            }
        }

        private void RevokeButton_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameTextBox.Text;
            if (!privilageRevoke.Equals(""))
            {
                privilageRevoke += username;
                Utils.ExcuteSql(privilageRevoke);
                MessageBox.Show("Thu hồi quyền thành công!");
                updatePrivilegeTables(username);
            }
        }

    }
}
