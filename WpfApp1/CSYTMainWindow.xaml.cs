using Oracle.ManagedDataAccess.Client;
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
    /// Interaction logic for CSYTMainWindow.xaml
    /// </summary>
    public partial class CSYTMainWindow : Window
    {
        OracleConnection con = new OracleConnection($"User Id={Login.usernameGlobal};Password={Login.passwordGlobal};Data Source=localhost:1521/xe");
        //bool con = Utils.Connect("CSYT1", "CSYT1");
        public CSYTMainWindow()
        {
            InitializeComponent();
        }
        private void radioTHEM_HSBA_Checked(object sender, RoutedEventArgs e)
        {
            con.Open();
            labelMABN.IsEnabled = true;
            txtboxMABN.IsEnabled = true;
            labelNGAY.IsEnabled = true;
            labelCHUANDOAN.IsEnabled = true;
            txtboxCHUANDOAN.IsEnabled = true;
            labelKETLUAN.IsEnabled = true;
            txtboxKETLUAN.IsEnabled = true;
            labelMABS.IsEnabled = true;
            txtboxMABS.IsEnabled = true;
            labelMAKHOA.IsEnabled = true;
            txtboxMAKHOA.IsEnabled = true;
            labelMACSYT.IsEnabled = true;
            MACSYT.IsEnabled = true;
            txtboxNGAY.Visibility = Visibility.Collapsed;
            labelMAHSBA.Visibility = Visibility.Collapsed;
            txtboxMAHSBA.Visibility = Visibility.Collapsed;
            btnTHEM.Visibility = Visibility.Visible;
            btnXOA.Visibility = Visibility.Collapsed;
            btnSEARCH.Visibility = Visibility.Collapsed;
            datepickNGAY.Visibility = Visibility.Visible;
            string query = "select user from dual";
            OracleCommand cmd = new OracleCommand(query, con);
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string csyt_id = reader.GetString(0);
                string id = csyt_id.Remove(0, 4);
                MACSYT.Content = id;
            }
            con.Close();
        }

        private void radioXOA_HSBA_Checked(object sender, RoutedEventArgs e)
        {
            labelMAHSBA.Visibility = Visibility.Visible;
            txtboxMAHSBA.Visibility = Visibility.Visible;
            labelMABN.IsEnabled = false;
            txtboxMABN.IsEnabled = false;
            labelNGAY.IsEnabled = false;
            labelCHUANDOAN.IsEnabled = false;
            txtboxCHUANDOAN.IsEnabled = false;
            labelKETLUAN.IsEnabled = false;
            txtboxKETLUAN.IsEnabled = false;
            labelMABS.IsEnabled = false;
            txtboxMABS.IsEnabled = false;
            labelMAKHOA.IsEnabled = false;
            txtboxMAKHOA.IsEnabled = false;
            labelMACSYT.IsEnabled = false;
            MACSYT.IsEnabled = false;
            txtboxNGAY.IsEnabled = false;
            txtboxNGAY.Visibility = Visibility.Visible;
            datepickNGAY.Visibility = Visibility.Collapsed;
            btnTHEM.Visibility = Visibility.Collapsed;
            btnSEARCH.Visibility = Visibility.Visible;
            btnXOA.Visibility = Visibility.Visible;
            btnXOA.Margin = new Thickness(20, 241, 0, 0);

        }

        private void radioTHEM_DV_Checked(object sender, RoutedEventArgs e)
        {
            labelMAKTV.IsEnabled = true;
            txtboxMAKTV.IsEnabled = true;
            labelKETQUA.IsEnabled = true;
            txtboxKETQUA.IsEnabled = true;
            btnTHEM_DV.Visibility = Visibility.Visible;
            btnXOA_DV.Visibility = Visibility.Collapsed;
            //txtboxNGAY_DV.Visibility = Visibility.Collapsed;
            datepickNGAY_DV.Visibility = Visibility.Visible;
            btnSEARCH_DV.Visibility = Visibility.Collapsed;
        }

        private void radioXOA_DV_Checked(object sender, RoutedEventArgs e)
        {
            labelMAKTV.IsEnabled = false;
            txtboxMAKTV.IsEnabled = false;
            labelKETQUA.IsEnabled = false;
            txtboxKETQUA.IsEnabled = false;
            btnTHEM_DV.Visibility = Visibility.Collapsed;
            btnXOA_DV.Visibility = Visibility.Visible;
            btnXOA_DV.Margin = new Thickness(0, 321, 0, 0);
            //txtboxNGAY_DV.Visibility = Visibility.Visible;
            //datepickNGAY_DV.Visibility = Visibility.Collapsed;
            btnSEARCH_DV.Visibility = Visibility.Visible;
        }

        private void btnTHEM_Click(object sender, RoutedEventArgs e)
        {
            con.Open();
            int mabn = Int32.Parse(txtboxMABN.Text);
            string ngay = datepickNGAY.Text;
            string chuandoan = txtboxCHUANDOAN.Text;
            string ketluan = txtboxKETLUAN.Text;
            int mabs = Int32.Parse(txtboxMABS.Text);
            int makhoa = Int32.Parse(txtboxMAKHOA.Text);
            int macsyt = Int32.Parse((string)MACSYT.Content);
            string sql = "INSERT INTO DBA_CSYT.HSBA VALUES(1,:bn,to_date(:ngayhsba,'MM-DD-YYYY'),:cd,:bs,:khoa,:csyt,:kl)";
            try
            {
                using (var cmd = new OracleCommand(sql, con))
                {
                    OracleParameter[] parameters = new OracleParameter[]
                    {
                        new OracleParameter("bn",mabn),
                        new OracleParameter("ngayhsba",ngay),
                        new OracleParameter("cd",chuandoan),
                        new OracleParameter("bs",mabs),
                        new OracleParameter("khoa",makhoa),
                        new OracleParameter("csyt",macsyt),
                        new OracleParameter("kl",ketluan)
                    };
                    cmd.Parameters.AddRange(parameters);
                    int n = cmd.ExecuteNonQuery();
                    if (n > 0)
                    {
                        sql = "commit";
                        var cmd2 = new OracleCommand(sql, con);
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Thêm hồ sơ bệnh án THÀNH CÔNG.");
                        txtboxMABN.Text = "";
                        datepickNGAY.Text = "";
                        txtboxCHUANDOAN.Text = "";
                        txtboxMABS.Text = "";
                        txtboxKETLUAN.Text = "";
                        txtboxMAKHOA.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            con.Close();
        }

        private void btnTHEM_DV_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                con.Open();
                int mahsbadv = Int32.Parse(txtboxMAHSBA_DV.Text);
                string ngay_dv = datepickNGAY_DV.Text;
                string ketqua = txtboxKETQUA.Text;
                int madv = Int32.Parse(txtboxMADV.Text);
                int maktv = Int32.Parse(txtboxMAKTV.Text);
                string sql = "INSERT INTO DBA_CSYT.HSBA_DV VALUES(:hsbadv,:dv,to_date(:ngayhsbadv,'MM-DD-YYYY'),:ktv,:kq)";
                using (var cmd = new OracleCommand(sql, con))
                {
                    cmd.Parameters.Add("hsbadv", OracleDbType.Int32).Value = mahsbadv;
                    cmd.Parameters.Add("madv", OracleDbType.Int32).Value = madv;
                    cmd.Parameters.Add("ngayhsbadv", OracleDbType.NVarchar2).Value = ngay_dv;
                    cmd.Parameters.Add("ktv", OracleDbType.Int32).Value = maktv;
                    cmd.Parameters.Add("kq", OracleDbType.NVarchar2).Value = ketqua;
                    int n = cmd.ExecuteNonQuery();
                    if (n > 0)
                    {
                        sql = "commit";
                        var cmd2 = new OracleCommand(sql, con);
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Thêm dịch vụ THÀNH CÔNG.");
                        txtboxMAHSBA_DV.Text = "";
                        datepickNGAY_DV.Text = "";
                        txtboxMADV.Text = "";
                        txtboxMAKTV.Text = "";
                        txtboxKETQUA.Text = "";
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            con.Close();
        }

        private void btnSEARCH_Click(object sender, RoutedEventArgs e)
        {
            con.Open();
            int ma_hsba = Int32.Parse(txtboxMAHSBA.Text);
            string sql = "SELECT * FROM DBA_CSYT.HSBA WHERE :p_hsba = \"Ma_HSBA\"";
            try
            {
                using (var cmd = new OracleCommand(sql, con))
                {
                    cmd.Parameters.Add("p_hsba", OracleDbType.Int32).Value = ma_hsba;
                    OracleDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtboxMABN.Text = reader.GetString(1);
                        txtboxNGAY.Text = reader.GetString(2);
                        txtboxCHUANDOAN.Text = reader.GetString(3);
                        txtboxMABS.Text = reader.GetString(4);
                        txtboxMAKHOA.Text = reader.GetString(5);
                        txtboxKETLUAN.Text = reader.GetString(7);
                    }
                    else
                    {
                        MessageBox.Show("HSBA này KHÔNG thuộc về CSYT của bạn hoặc KHÔNG tồn tại.");
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            con.Close();
        }

        private void btnSEARCH_DV_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                con.Open();
                int ma_hsba_dv = Int32.Parse(txtboxMAHSBA_DV.Text);
                int ma_dv = Int32.Parse(txtboxMADV.Text);
                string ngay_dv = datepickNGAY_DV.Text;
                string sql = "SELECT * FROM DBA_CSYT.HSBA_DV WHERE :p_hsba_dv = \"Ma_HSBA\" and :p_dv = \"Ma_DV\" and \"Ngay\" = to_date(:p_ngay_dv,'MM-DD-YYYY')";
                using (var cmd = new OracleCommand(sql, con))
                {
                    cmd.Parameters.Add("p_hsba", OracleDbType.Int32).Value = ma_hsba_dv;
                    cmd.Parameters.Add("p_dv", OracleDbType.Int32).Value = ma_dv;
                    cmd.Parameters.Add("p_ngay_dv", OracleDbType.Varchar2).Value = ngay_dv;
                    OracleDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        sql = "SELECT distinct \"Ma_CSYT\" from DBA_CSYT.HSBA ba join DBA_CSYT.HSBA_DV badv on ba.\"Ma_HSBA\" = badv.\"Ma_HSBA\" where ba.\"Ma_HSBA\" = :p_hsba_select";
                        var cmd2 = new OracleCommand(sql, con);
                        cmd2.Parameters.Add("p_hsba_select", OracleDbType.Int32).Value = ma_hsba_dv;
                        OracleDataReader reader2 = cmd2.ExecuteReader();
                        if (reader2.Read())
                        {
                            txtboxMAKTV.Text = reader.GetString(3);
                            txtboxKETQUA.Text = reader.GetString(4);

                        }
                        else MessageBox.Show("HSBA_DV này KHÔNG thuộc về CSYT của bạn.");
                    }
                    else
                    {
                        MessageBox.Show("HSBA_DV này KHÔNG tồn tại.");
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            con.Close();
        }

        private void btnXOA_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                con.Open();
                int ma_hsba = Int32.Parse(txtboxMAHSBA.Text);
                string sql = "DELETE FROM DBA_CSYT.HSBA WHERE \"Ma_HSBA\" = :p_hsba";
                using (var cmd = new OracleCommand(sql, con))
                {
                    cmd.Parameters.Add("p_hsba", OracleDbType.Int32).Value = ma_hsba;
                    int n = cmd.ExecuteNonQuery();
                    if (n > 0)
                    {
                        sql = "commit";
                        var cmd2 = new OracleCommand(sql, con);
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Xóa hồ sơ bệnh án THÀNH CÔNG.");
                        txtboxMAHSBA.Text = "";
                        txtboxMABN.Text = "";
                        datepickNGAY.Text = "";
                        txtboxCHUANDOAN.Text = "";
                        txtboxMABS.Text = "";
                        txtboxKETLUAN.Text = "";
                        txtboxMAKHOA.Text = "";
                    }
                    else MessageBox.Show("HSBA này không thuộc CSYT của bạn hoặc KHÔNG tồn tại.");
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            con.Close();
        }

        private void btnXOA_DV_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                con.Open();
                int ma_hsba_dv = Int32.Parse(txtboxMAHSBA_DV.Text);
                string ngay_dv = datepickNGAY_DV.Text;
                int madv = Int32.Parse(txtboxMADV.Text);
                string sql = "DELETE FROM DBA_CSYT.HSBA_DV WHERE \"Ma_HSBA\" = :p_hsbadv and \"Ma_DV\" = :p_dv and \"Ngay\" = to_date(:p_ngay_dv,'MM-DD-YYYY')";
                using (var cmd = new OracleCommand(sql, con))
                {
                    cmd.Parameters.Add("p_hsbadv", OracleDbType.Int32).Value = ma_hsba_dv;
                    cmd.Parameters.Add("p_dv", OracleDbType.Int32).Value = madv;
                    cmd.Parameters.Add("p_ngay_dv", OracleDbType.Varchar2).Value = ngay_dv;
                    int n = cmd.ExecuteNonQuery();
                    if (n > 0)
                    {
                        sql = "commit";
                        var cmd2 = new OracleCommand(sql, con);
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Xóa dịch vụ THÀNH CÔNG.");
                        txtboxMAHSBA_DV.Text = "";
                        datepickNGAY_DV.Text = "";
                        txtboxMADV.Text = "";
                        txtboxMAKTV.Text = "";
                        txtboxKETQUA.Text = "";
                    }
                    else MessageBox.Show("HSBA_DV này không thuộc CSYT của bạn hoặc KHÔNG tồn tại.");
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            con.Close();
        }
    }
}
