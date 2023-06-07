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
    /// Interaction logic for GrantPrivilege.xaml
    /// </summary>
    public partial class GrantPrivilege : Window
    {
        private string username;
        string[] tablePris = { "SELECT","UPDATE","DELETE","INSERT"};
        string[] sysPris = {"ALTER ANY INDEX", "ALTER ANY CACHE GROUP", "ADMIN",
            "ALTER ANY MATERIALIZED VIEW","ALTER ANY PROCEDURE","ALTER ANY SEQUENCE","ALTER ANY TABLE","ALTER ANY VIEW",
            "CACHE_MANAGER","CREATE ANY CACHE GROUP","CREATE ANY INDEX","CREATE ANY MATERIALIZED VIEW","CREATE ANY PROCEDURE",
            "CREATE ANY SEQUENCE","CREATE ANY SYNONYM","CREATE ANY TABLE","CREATE ANY VIEW","CREATE MATERIALIZED VIEW",
            "CREATE PROCEDURE","CREATE PUBLIC SYNONYM","CREATE SEQUENCE","CREATE SESSION","CREATE SYNONYM","CREATE TABLE",
            "CREATE VIEW","DELETE ANY TABLE","DROP ANY CACHE GROUP","DROP ANY INDEX","DROP ANY MATERIALIZED VIEW",
            "DROP ANY PROCEDURE","DROP ANY SEQUENCE","DROP ANY SYNONYM","DROP ANY TABLE","DROP ANY VIEW","DROP PUBLIC SYNONYM",
            "EXECUTE ANY PROCEDURE","FLUSH ANY CACHE GROUP","INSERT ANY TABLE","LOAD ANY CACHE GROUP","REFRESH ANY CACHE GROUP",
            "SELECT ANY SEQUENCE","SELECT ANY TABLE","UNLOAD ANY CACHE GROUP","UPDATE ANY TABLE","XLA"};
        public GrantPrivilege(string _username)
        {
            InitializeComponent();
            username = _username;
            pCombo.ItemsSource = tablePris;
            try
            {
                Utils.LoadRoles(rCombo);
                Utils.LoadTables(tCombo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grantBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string with = "";
                if (wCheck.IsChecked == true)
                    with = " with grant option";
                //Privilege to use
                if (puR.IsChecked == true || PriTableToUser.IsChecked == true)
                {
                    string pri = pCombo.Text.ToLower();
                    string table = tCombo.Text;

                    string sql = "";
                    if (!pri.Equals("select") && !pri.Equals("insert") && !pri.Equals("update") && !pri.Equals("delete"))
                        sql = string.Format("grant {0} to {1}" + with, pri, username);
                    //else if (!col.Equals("") && (pri.Equals("select") || pri.Equals("update")))
                    //    sql = string.Format("grant {0} {1} on {2} to {3}" + with, pri, "(" + col + ")", table, username);
                    else
                        sql = string.Format("grant {0} on {1} to {2}" + with, pri, table, username);
                    try
                    {
                        Utils.ExcuteSql(sql);
                        MessageBox.Show("Cấp quyền thành công!");
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message);
                    }
                }
                else if (ruR.IsChecked == true)
                {
                    string role = rCombo.Text;
                    string sql = string.Format("grant {0} to {1}" + with, role, username);
                    try
                    {
                        Utils.ExcuteSql(sql);
                        MessageBox.Show("Cấp role thành công!");
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void ruR_Checked(object sender, RoutedEventArgs e)
        {
            tCombo.Visibility = Visibility.Collapsed;
            pCombo.Visibility = Visibility.Collapsed;
            rCombo.Visibility = Visibility.Visible;
        }

        private void puR_Checked(object sender, RoutedEventArgs e)
        {
            rCombo.Visibility = Visibility.Collapsed;
            pCombo.Visibility = Visibility.Visible;
            tCombo.Visibility = Visibility.Collapsed;
            pCombo.ItemsSource = sysPris;
        }

        private void PriTableToUser_Checked(object sender, RoutedEventArgs e)
        {
            if(rCombo != null) 
                rCombo.Visibility = Visibility.Collapsed;
            if (pCombo != null)
                pCombo.Visibility = Visibility.Visible;
            if (tCombo != null)
                tCombo.Visibility = Visibility.Visible;
            if (pCombo != null)
                pCombo.ItemsSource = tablePris;
        }
    }
}
