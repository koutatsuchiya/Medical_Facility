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
using Oracle.ManagedDataAccess.Client;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for NCV_Profile.xaml
    /// </summary>
    public partial class NCV_Profile : Page
    {
        DataTable tbl_userInfo = new DataTable();   
        public void getInfo()
        {
            try
            {
                tbl_userInfo.Clear();
                string sqlCommand = "select  \"Ho_Ten\",\"CSYT\", \"Chuyen_Khoa\", \"Ngay_Sinh\", \"Que_Quan\", \"SDT\", \"Ma_Nhan_Vien\" from DBA_CSYT.\"Nhan_Vien\"";
                tbl_userInfo = Utils.GetDataToTable(sqlCommand);

                
                FullNameTextBox.Text = tbl_userInfo.Rows[0][0].ToString();
                CSTextBox.Text = tbl_userInfo.Rows[0][1].ToString();
                CKTextBox.Text = tbl_userInfo.Rows[0][2].ToString();
                NSDatePicker.Text = tbl_userInfo.Rows[0][3].ToString();
                QQTextBox.Text = tbl_userInfo.Rows[0][4].ToString();
                DTTextBox.Text = tbl_userInfo.Rows[0][5].ToString();
                UsernameTextBox.Text = "NV" + tbl_userInfo.Rows[0][6].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
   
        public NCV_Profile()
        {
            InitializeComponent();
            getInfo();  
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                string sqlCommand = "update DBA_CSYT.\"Nhan_Vien\" set \"Ho_Ten\" = '" + FullNameTextBox.Text + "' ,\"CSYT\" = " + CSTextBox.Text + " , \"Chuyen_Khoa\" = '" + CKTextBox.Text + "' , \"Ngay_Sinh\" = TO_DATE('" + NSDatePicker.Text + "','DD/MM/YYYY'), \"Que_Quan\" = '" + QQTextBox.Text + "', \"SDT\" = '" + DTTextBox.Text;
                Utils.ExcuteSql(sqlCommand);
                MessageBox.Show("Cập nhật thông tin thành công!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
