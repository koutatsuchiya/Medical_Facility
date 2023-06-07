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
    /// Interaction logic for AllPrivilegeOfRole.xaml
    /// </summary>
    public partial class AllPrivilegeOfRole : Window
    {
        private string privilageRevoke = "";
        public AllPrivilegeOfRole(string role)
        {
            try
            {
                InitializeComponent();
                roleTextBox.Text = role;
                updatePrivilegeTables(role);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex);
            }
        }
        private void updatePrivilegeTables(string role)
        {
            Utils.LoadPrivileges("select", viewlistBox, role);
            // delete table
            Utils.LoadPrivileges("delete", deletelistBox, role);
            // update table
            Utils.LoadPrivileges("update", updatelistBox, role);
            // insert table
            Utils.LoadPrivileges("insert", insertlistBox, role);

            //role privilege
            Utils.LoadPrivileges("role", roleListBox, role);

            //sys privilege
            Utils.LoadPrivileges("sys", sysPrivilegeListBox, role);
        }


        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void GrantButton_Click(object sender, RoutedEventArgs e)
        {
            string role = roleTextBox.Text;
            GrantPrivilege grantPrivilegeScreen = new GrantPrivilege(role);
            grantPrivilegeScreen.Show();

            //updatePrivilegeTables(role);
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
            if (privilege != null)
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
            string role = roleTextBox.Text;
            if (!privilageRevoke.Equals(""))
            {
                privilageRevoke += role;
                Utils.ExcuteSql(privilageRevoke);
                MessageBox.Show("Thu hồi quyền thành công!");
                updatePrivilegeTables(role);
            }
        }
    }
}
