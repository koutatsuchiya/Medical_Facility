using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for AddPatient.xaml
    /// </summary>
    public partial class AddPatient : Window
    {
        public AddPatient()
        {
            InitializeComponent();
            //test
            Utils.Connect("DBA_CSYT", "DBA_CSYT");
        }

        private void AddPatientButton_Click(object sender, RoutedEventArgs e)
        {

            string sql = "alter session set \"_ORACLE_SCRIPT\"=true";
            Utils.ExcuteSql(sql);

            sql = $"begin\ncreate_benh_nhan({int.Parse(csytTextBox.Text)}, '{NameTextBox.Text}', '{IdCardTextBox.Text}', '{birthPicker.SelectedDate.Value.Date.ToString("yyyy/MM/dd")}'," +
                $" '{HomeNumberTextBox.Text}', '{StreetTextBox.Text}', '{DistrictTextBox.Text}', '{CityTextBox.Text}', '{HisotryTextBox.Text}'," +
                $" '{FamilyHisotryTextBox.Text}', '{AllergyTextBox.Text}');\nend;";
            Utils.ExcuteSql(sql);
            MessageBox.Show($"Thêm bệnh nhân thành công!");
            Close();
            Utils.LoadUserPage(MainWindow.userPage);
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
