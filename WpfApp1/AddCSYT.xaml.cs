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
    /// Interaction logic for AddCSYT.xaml
    /// </summary>
    public partial class AddCSYT : Window
    {
        public AddCSYT()
        {
            InitializeComponent();
        }

        private void AddCSYTButton_Click(object sender, RoutedEventArgs e)
        {
            string sql = "alter session set \"_ORACLE_SCRIPT\"=true";
            Utils.ExcuteSql(sql);
            sql = "begin create_csyt( ";

            string name = NameTextBox.Text;
            string address = AddressTextBox.Text;
            string phoneNumber = PhoneNumberTextBox.Text;
            sql += "'" + name  + "', '" + address + "','" + phoneNumber + "'); end;";
            Utils.ExcuteSql(sql);
            this.Close();
            Utils.LoadCSYTPage(MainWindow.csytPage);
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
