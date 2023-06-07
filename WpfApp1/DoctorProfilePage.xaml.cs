using Oracle.DataAccess.Client;
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
    /// Interaction logic for DoctorProfilePage.xaml
    /// </summary>
    public partial class DoctorProfilePage : Page
    {
        public DoctorProfilePage()
        {
            InitializeComponent();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //string sql;
                //alter session for the date format
                //sql = "alter session set nls_date_format = 'dd/MM/yyyy'";
                //Utils.ExcuteSql(sql);
                //sql update all attribute
                string sql = "update DBA_CSYT.\"Nhan_Vien\" set" +
                    $" \"Ma_Nhan_Vien\" = {int.Parse(IdTextBox.Text)}," +
                    $" \"Ho_Ten\" = '{NameTextBox.Text}'," +
                    $" \"Phai\" = '{GenderComboBox.Text}'," +
                    $" \"CMND\" = '{IdCardTextBox.Text}'," +
                    $" \"Ngay_Sinh\" = TO_DATE('{DOBPicker.Text}', 'mm/dd/yyyy')," +
                    $" \"Que_Quan\" = '{HomeTownTextBox.Text}'," +
                    $" \"SDT\" = '{PhoneTextBox.Text}'," +
                    $" \"CSYT\" = {int.Parse(HospitalBox.Text)}";
                Utils.ExcuteSql(sql);
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
