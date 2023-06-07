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
    /// Interaction logic for AddEmployee.xaml
    /// </summary>
    public partial class AddEmployee : Window
    {
        public AddEmployee()
        {
            InitializeComponent();
            //test
            //Utils.Connect("DBA_CSYT", "DBA_CSYT");
        }

        private void AddEmployeeButton_Click(object sender, RoutedEventArgs e)
        {

            string sql = "alter session set \"_ORACLE_SCRIPT\"=true";
            Utils.ExcuteSql(sql);

            string p_type;
            if (roleCbBox.Text.Equals("Thanh tra"))
                p_type = "TT";
            else if (roleCbBox.Text.Equals("Y sĩ/Bác sĩ"))
                p_type = "YBS";
            else
                p_type = "NC";

            sql = $"begin\ncreate_nhan_vien('{p_type}', '{NameTextBox.Text}','{GenderCbBox.Text}', " +
                $"'{birthPicker.SelectedDate.Value.Date.ToString("yyyy/MM/dd")}', " +
                $"'{IdCardTextBox.Text}', '{HomeTownTextBox.Text}', '{PhoneNumberTextBox.Text}', {int.Parse(csytTextBox.Text)}," +
                $" '{roleCbBox.Text}', {int.Parse(SpecialistTextBox.Text)});\nend;";
            Utils.ExcuteSql(sql);
            MessageBox.Show($"Thêm nhân viên thành công!");
            Close();
            Utils.LoadUserPage(MainWindow.userPage);
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
