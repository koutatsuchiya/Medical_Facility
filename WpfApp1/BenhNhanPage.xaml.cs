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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class BenhNhanPage : Page
    {
        public BenhNhanPage()
        {
            InitializeComponent();
        }
        
        private void xemBut_Click(object sender, RoutedEventArgs e)
        {
            Utils.loadPatient(this);
        }

        private void suaBut_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string sql;
                //alter session for the date format
                sql = "alter session set nls_date_format = 'dd/MM/yyyy'";
                Utils.ExcuteSql(sql);
                //sql update all attribute
                sql = "update DBA_CSYT.\"Benh_Nhan\" set" +
                    $" \"Ma_Benh_Nhan\" = {int.Parse(maBnTBox.Text)}," +
                    $" \"Ten_Benh_Nhan\" = '{tenBnTBox.Text}'," +
                    $" \"CMND\" = '{cmndTBox.Text}'," +
                    $" \"Ngay_Sinh\" = '{birthTBox.Text}'," +
                    $" \"So_Nha\" = '{soNhaTBox.Text}'," +
                    $" \"Ten_Duong\" = '{tenDuongTBox.Text}'," +
                    $" \"Quan_Huyen\" = '{quanHuyenTBox.Text}'," +
                    $" \"Tinh_TP\" = '{tinhtpTBox.Text}'," +
                    $" \"Ma_CSYT\" = {int.Parse(csytTBox.Text)}," +
                    $" \"Tieu_Su_Benh\" = '{tiensSuBenhTBox.Text}'," +
                    $" \"Tieu_Su_Benh_GD\" = '{diUngThuocTBox.Text}'," +
                    $" \"Di_Ung_Thuoc\" = '{tienSuBenhGdTBox.Text}'";
                Utils.ExcuteSql(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Utils.loadPatient(this);
        }
    }
}
