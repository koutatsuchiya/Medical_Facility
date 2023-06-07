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
    /// Interaction logic for NCV_HSBA.xaml
    /// </summary>
    
    public partial class NCV_HSBA : Page
    {
        public DataTable tbl_hsba;
        DataTable tbl_hsba_dv = new DataTable();
        DataTable tbl_userInfo = new DataTable();
        public void loadDataHSBA(string searchKey ="")
        {
            try
            {
                // load infomation of current user
                tbl_userInfo.Clear();
             
                string sqlCommand = "select \"Ho_Ten\",\"CSYT\", \"Chuyen_Khoa\", \"Ngay_Sinh\", \"Que_Quan\", \"SDT\" from DBA_CSYT.\"Nhan_Vien\"";
                tbl_userInfo = Utils.GetDataToTable(sqlCommand);

                string CS = tbl_userInfo.Rows[0][1].ToString();
                string CK  = tbl_userInfo.Rows[0][2].ToString();
                
                // load data from table HSBA
                tbl_hsba = new DataTable();
                sqlCommand = "select \"Ma_HSBA\" , \"Ngay\" ,\"Chan_Doan\",\"Ket_Luan\",\"Ma_Khoa\", \"Ma_CSYT\" from DBA_CSYT.\"HSBA\" ";
                if (searchKey != "")
                    sqlCommand = sqlCommand + " where \"Chan_Doan\" like '%" + searchKey +"%'";
                tbl_hsba = Utils.GetDataToTable(sqlCommand);
                dgv_hsba.DataContext = tbl_hsba;
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public NCV_HSBA()
        {
            InitializeComponent();
            loadDataHSBA();

        }

        private void search_btn_Click(object sender, RoutedEventArgs e)
        {
            loadDataHSBA(SearchTextBox.Text);
        }

       
        private void dgv_hsba_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            string HSBA_ID = tbl_hsba.Rows[dgv_hsba.SelectedIndex][0].ToString();
            string sqlCommand = "select \"Ma_DV\", \"Ngay\", \"Ket_Qua\" from DBA_CSYT.\"HSBA_DV\" where \"Ma_HSBA\" = " + HSBA_ID;
            
            tbl_hsba_dv = Utils.GetDataToTable(sqlCommand);
            dgv_hsba_dv.DataContext = tbl_hsba_dv;
        }
    }
}
