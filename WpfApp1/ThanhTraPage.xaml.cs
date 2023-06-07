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
    /// Interaction logic for ThanhTraPage.xaml
    /// </summary>
    public partial class ThanhTraPage : Page
    {
        private int db_mode;    //to tell which table to sel in db
        //column name of each table
        string[] hsbaCols = { "MÃ HSBA", "MÃ BN", "NGÀY", "CHẨN ĐOÁN", "MÃ BS", "MÃ KHOA", "MÃ CSYT", "KẾT LUẬN" };
        string[] hsba_dvCols = { "MÃ HSBA", "MÃ DỊCH VỤ", "NGÀY", "MÃ KTV", "KẾT QUẢ" };
        string[] bnCols = { "MÃ BN", "MÃ CSYT", "HỌ TÊN", "CMND", "NGÀY SINH", "SỐ NHÀ", "TÊN ĐƯỜNG", "QUẬN, HUYỆN",
                            "TỈNH, THÀNH PHỐ", "TIỀN SỬ BỆNH", "TIỀN SỬ BỆNH GĐ", "DỊ ỨNG THUỐC" };
        string[] csytCols = { "MÃ CSYT", "TÊN CSYT", "ĐỊA CHỈ", "SĐT" };
        string[] nvCols = { "MÃ NV", "HỌ TÊN", "PHÁI", "NGÀY SINH", "CMND", "QUÊ QUÁN", "SĐT", "CSYT", "VAI TRÒ", "CHUYÊN KHOA" };
        public ThanhTraPage(int db_mode)
        {
            InitializeComponent();
            this.db_mode = db_mode;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                string sql = "";
                string[] cols = { };
                //choose the appropriate sql string
                switch (db_mode)
                {
                    case 1:
                        sql = "select * from DBA_CSYT.\"HSBA\"";
                        cols = hsbaCols;
                        break;
                    case 2:
                        sql = "select * from DBA_CSYT.\"HSBA_DV\"";
                        cols = hsba_dvCols;
                        break;
                    case 3:
                        sql = "select * from DBA_CSYT.\"Benh_Nhan\"";
                        cols = bnCols;
                        break;
                    case 4:
                        sql = "select * from DBA_CSYT.\"CSYT\"";
                        cols = csytCols;
                        break;
                    case 5:
                        sql = "select * from DBA_CSYT.\"Nhan_Vien\"";
                        cols = nvCols;
                        break;
                    default:
                        break;
                }
                var tbl = Utils.GetDataToTable(sql);
                //changing col name
                for (int i = 0; i < cols.Length; i++)
                  tbl.Columns[i].ColumnName = cols[i];
                tbl.AcceptChanges();
                /*string dateCol = "";
                if (db_mode == 1 ||db_mode == 2)
                    dateCol = "Ngay";
                else if (db_mode == 3 || db_mode == 5)
                    dateCol = "Ngay_Sinh";
                
                
                    //var dates = tbl.AsEnumerable().Select(r => r.Field<DateTime>(dateCol)).ToList();
                    var col = tbl.Columns[dateCol];
                    foreach (DataRow row in tbl.Rows)
                    {
                        row[dateCol] = String.Format("{0:dd/mm/yyyy}", row[dateCol].ToString());
                    //Convert.ToDateTime(row[dateCol]).Date.ToString("MM/dd/yyyy");

                }
                tbl.AcceptChanges();*/



                dgMain.ItemsSource = tbl.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
