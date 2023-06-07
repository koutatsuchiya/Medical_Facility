using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    class Utils
    {
       
        public static OracleConnection Con;  //Khai báo đối tượng kết nối

        public static bool Connect(string username, string password)
        {
           
            string host = "localhost";
            string port = "1521";
            string sid = "xe";

            string strConn = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
            + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
            + sid + ")));Password=" + password + ";User ID=" + username;


            Con = new OracleConnection(strConn);

            try
            {
                if (Con == null)
                {
                    Con = new OracleConnection(strConn);
                }
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                    //MessageBox.Show("Đăng nhập thành công");
                    return true;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            return false;
        }

        public static void Disconnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();   	
                Con.Dispose(); 	
                Con = null;
                MessageBox.Show("Đã ngắt kết nối");
            }
        }

        public static DataTable GetDataToTable(string sql)
        {
            OracleDataAdapter dataAdapter = new OracleDataAdapter();
            dataAdapter.SelectCommand = new OracleCommand();
            dataAdapter.SelectCommand.Connection = Con;
            dataAdapter.SelectCommand.CommandText = sql; 
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            return table;
        }

        public static void ExcuteSql(string sql)
        {
            OracleCommand cmd;
            cmd = new OracleCommand(sql, Con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Debug.WriteLine(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
        public static void LoadUserPage(UserPage userPage, string keyword="")
        {
            BindingList<User> ListUsers = new BindingList<User>();
            try
            {
                string sql;
                sql = "SELECT USER_ID, USERNAME, ACCOUNT_STATUS, CREATED, EXPIRY_DATE, LAST_LOGIN " +
                        "FROM DBA_USERS WHERE DEFAULT_TABLESPACE = 'USERS'";
                if (keyword.Length > 0)
                {
                    sql += $" and USER_ID like '%{keyword}%' or USERNAME like '%{keyword}%'";
                    //sql += $" where \"Ma_Benh_Nhan\" like '%{keyword}%' or CMND like '%{keyword}%'";
                }
                var tableUser = Utils.GetDataToTable(sql);
                ListUsers.Clear();
                for (int i = 0; i < tableUser.Rows.Count; i++)
                {
                    User user = new User();
                    user.Id = Convert.ToInt32(tableUser.Rows[i]["USER_ID"]);
                    user.Username = tableUser.Rows[i]["Username"].ToString();
                    user.AccountStatus = tableUser.Rows[i]["ACCOUNT_STATUS"].ToString();
                    user.Created = tableUser.Rows[i]["CREATED"].ToString();
                    user.ExpiryDate = tableUser.Rows[i]["EXPIRY_DATE"].ToString();
                    user.LastLogin = tableUser.Rows[i]["LAST_LOGIN"].ToString();
                    ListUsers.Add(user);
                }
                userPage.ListViewUser.ItemsSource = ListUsers;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void LoadRolePage(RolePage rolePage, string keyword = "")
        {
            BindingList<Role> ListRoles = new BindingList<Role>();
            try
            {
                string sql;
                sql = "SELECT ROLE_ID, ROLE, PASSWORD_REQUIRED, AUTHENTICATION_TYPE, COMMON, INHERITED, IMPLICIT " +
                        "FROM DBA_ROLES";
                if (keyword.Length > 0)
                {
                    sql += $" where \"ROLE_ID\" like '%{keyword}%' or \"ROLE\" like '%{keyword}%'";
                    //sql += $" where \"Ma_Benh_Nhan\" like '%{keyword}%' or CMND like '%{keyword}%'";
                }
                var tableRole = Utils.GetDataToTable(sql);
                ListRoles.Clear();
                for (int i = 0; i < tableRole.Rows.Count; i++)
                {
                    Role role = new Role();
                    role.Id = Convert.ToInt32(tableRole.Rows[i]["ROLE_ID"]);
                    role.RoleName = tableRole.Rows[i]["ROLE"].ToString();
                    role.AuthenticationType = tableRole.Rows[i]["PASSWORD_REQUIRED"].ToString();
                    role.PasswordRequired = tableRole.Rows[i]["AUTHENTICATION_TYPE"].ToString();
                    role.Common = tableRole.Rows[i]["COMMON"].ToString();
                    role.Inherited = tableRole.Rows[i]["INHERITED"].ToString();
                    role.Implicit = tableRole.Rows[i]["IMPLICIT"].ToString();
                    ListRoles.Add(role);
                }
                rolePage.ListViewRole.ItemsSource = ListRoles;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void LoadTables(ComboBox tableComboBox)
        {
            BindingList<string> ListTables = new BindingList<string>();
            try
            {
                string sql;
                sql = "select table_name from user_tables";
                var tables = Utils.GetDataToTable(sql);
                ListTables.Clear();
                for (int i = 0; i < tables.Rows.Count; i++)
                {
                    string table = tables.Rows[i]["table_name"].ToString();
                    ListTables.Add(table);
                }
                tableComboBox.ItemsSource = ListTables;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void LoadRoles(ComboBox roleComboBox)
        {
            BindingList<string> ListRoles = new BindingList<string>();
            try
            {
                string sql;
                sql = "select role from dba_roles";
                var tables = Utils.GetDataToTable(sql);
                ListRoles.Clear();
                for (int i = 0; i < tables.Rows.Count; i++)
                {
                    string role = tables.Rows[i]["role"].ToString();
                    ListRoles.Add(role);
                }
                roleComboBox.ItemsSource = ListRoles;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void LoadPrivileges(string type, ListView l, string username)
        {
            string sql = "";
            string tbName = "tables";
            switch (type)
            {
                case "select":
                    sql = "SELECT TABLE_NAME tables FROM USER_TAB_PRIVS WHERE USER_TAB_PRIVS.PRIVILEGE = 'SELECT' and USER_TAB_PRIVS.GRANTEE = '" + username + "'";
                    break;
                case "insert":
                    sql = "SELECT TABLE_NAME tables FROM USER_TAB_PRIVS WHERE USER_TAB_PRIVS.PRIVILEGE = 'INSERT' and USER_TAB_PRIVS.GRANTEE = '" + username + "'";
                    break;
                case "update":
                    sql = "SELECT TABLE_NAME tables FROM USER_TAB_PRIVS WHERE USER_TAB_PRIVS.PRIVILEGE = 'UPDATE' and USER_TAB_PRIVS.GRANTEE = '" + username + "'";
                    break;
                case "delete":
                    sql = "SELECT TABLE_NAME tables FROM USER_TAB_PRIVS WHERE USER_TAB_PRIVS.PRIVILEGE = 'DELETE' and USER_TAB_PRIVS.GRANTEE = '" + username + "'";
                    break;
                case "role":
                    sql = $"select GRANTED_ROLE from DBA_ROLE_PRIVS  where GRANTEE = '{username}'";
                    tbName = "GRANTED_ROLE";
                    break;
                case "sys":
                    sql = $"select PRIVILEGE from DBA_SYS_PRIVS where GRANTEE = '{username}'";
                    tbName = "PRIVILEGE";
                    break;
                default:
                    break;
            }
            DataTable table = GetDataToTable(sql);
            BindingList<string> temp = new BindingList<string>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string privilege = table.Rows[i][tbName].ToString();
                temp.Add(privilege);
            }
            l.ItemsSource = temp;
        }
        public static void LoadCSYTPage(CSYTPage CSYTPage, string keyword="")
        {
            BindingList<CSYT> ListCSYT = new BindingList<CSYT>();
            try
            {
                string sql;
                sql = "SELECT * FROM CSYT";
                if(keyword.Length > 0)
                {
                    sql += $" where \"Ma_CSYT\" like '%{keyword}%' or \"Ten_CSYT\" like '%{keyword}%'";
                    //sql += $" where \"Ma_Benh_Nhan\" like '%{keyword}%' or CMND like '%{keyword}%'";
                }
                var tableCSYT = Utils.GetDataToTable(sql);
                ListCSYT.Clear();
                for (int i = 0; i < tableCSYT.Rows.Count; i++)
                {
                    CSYT csyt = new CSYT();
                    csyt.Id = Convert.ToInt32(tableCSYT.Rows[i]["Ma_CSYT"]);
                    csyt.Name = tableCSYT.Rows[i]["Ten_CSYT"].ToString();
                    csyt.Address = tableCSYT.Rows[i]["DC_CSYT"].ToString();
                    csyt.PhoneNumber = tableCSYT.Rows[i]["SDT_CSYT"].ToString();

                    ListCSYT.Add(csyt);
                }
                CSYTPage.ListViewCSYT.ItemsSource = ListCSYT;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void LoadDoctorProfile(DoctorProfilePage doctorProfilePage)
        {
            
            try
            {
                String sql = "Select * from DBA_CSYT.\"Nhan_Vien\"";
                var doctor = GetDataToTable(sql);
                doctorProfilePage.IdTextBox.Text = doctor.Rows[0]["Ma_Nhan_Vien"].ToString();
                doctorProfilePage.NameTextBox.Text = doctor.Rows[0]["Ho_Ten"].ToString();
                doctorProfilePage.IdCardTextBox.Text = doctor.Rows[0]["CMND"].ToString();
                DateTime d = DateTime.Parse(doctor.Rows[0]["Ngay_Sinh"].ToString()).Date;
                doctorProfilePage.DOBPicker.SelectedDate = d;
                string gender = doctor.Rows[0]["Phai"].ToString();
                if(gender.Equals("Nam"))
                    doctorProfilePage.GenderComboBox.SelectedIndex = 0;
                else
                    doctorProfilePage.GenderComboBox.SelectedIndex = 1;
                doctorProfilePage.HomeTownTextBox.Text = doctor.Rows[0]["Que_Quan"].ToString();
                doctorProfilePage.PhoneTextBox.Text = doctor.Rows[0]["SDT"].ToString();
                doctorProfilePage.HospitalBox.Text = doctor.Rows[0]["CSYT"].ToString();
                doctorProfilePage.SpecialistTextBox.Text = doctor.Rows[0]["Chuyen_Khoa"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void LoadMedicalRecordPage(MedicalRecordPage medicalRecordPage, string keyword = "")
        {
            BindingList<MedicalRecord> ListMedicalRecord = new BindingList<MedicalRecord>();
            try
            {
                string sql;
                sql = "SELECT * FROM DBA_CSYT.HSBA";
                if (keyword.Length > 0)
                {
                    sql += $" where \"Ma_HSBA\" like '%{keyword}%'";
                    //sql += $" where \"Ma_Benh_Nhan\" like '%{keyword}%' or CMND like '%{keyword}%'";
                }
                var tableMedicalRecord = Utils.GetDataToTable(sql);
                ListMedicalRecord.Clear();
                for (int i = 0; i < tableMedicalRecord.Rows.Count; i++)
                {
                    MedicalRecord medicalRecord = new MedicalRecord();
                    medicalRecord.Id = Convert.ToInt32(tableMedicalRecord.Rows[i]["Ma_HSBA"]);
                    medicalRecord.PatientId = Convert.ToInt32(tableMedicalRecord.Rows[i]["Ma_Benh_Nhan"]);
                    DateTime d = DateTime.Parse(tableMedicalRecord.Rows[i]["Ngay"].ToString()).Date;
                    medicalRecord.DateChecked = d.ToString("d");
                    medicalRecord.Diagnose = tableMedicalRecord.Rows[i]["Chan_Doan"].ToString();
                    medicalRecord.DoctorId = Convert.ToInt32(tableMedicalRecord.Rows[i]["Ma_BS"]);
                    medicalRecord.SpecialistId = Convert.ToInt32(tableMedicalRecord.Rows[i]["Ma_Khoa"]);
                    medicalRecord.CSYTId = Convert.ToInt32(tableMedicalRecord.Rows[i]["Ma_CSYT"]);
                    medicalRecord.Conclusion = tableMedicalRecord.Rows[i]["Ket_Luan"].ToString();
                    ListMedicalRecord.Add(medicalRecord);
                }
                medicalRecordPage.ListViewMedicalRecord.ItemsSource = ListMedicalRecord;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        public static void LoadLookUpPatientPage(LookUpPatientPage lookUpPatientPage, string keyword = "")
        {
            BindingList<Patient> ListPatient = new BindingList<Patient>();
            try
            {
                string sql;
                sql = "SELECT * FROM DBA_CSYT.\"Benh_Nhan\"";
                if(keyword.Length > 0)
                {
                    sql += $" where \"Ma_Benh_Nhan\" like '%{keyword}%' or CMND like '%{keyword}%'";
                }
                
                var tablePatient = Utils.GetDataToTable(sql);
                ListPatient.Clear();
                for (int i = 0; i < tablePatient.Rows.Count; i++)
                {
                    Patient patient = new Patient();
                    patient.Id = Convert.ToInt32(tablePatient.Rows[i]["Ma_Benh_Nhan"]);
                    patient.CSYTId = Convert.ToInt32(tablePatient.Rows[i]["Ma_CSYT"]);
                    patient.Name = tablePatient.Rows[i]["Ten_Benh_Nhan"].ToString();
                    patient.IdNumber = tablePatient.Rows[i]["CMND"].ToString();
                    DateTime d = DateTime.Parse(tablePatient.Rows[i]["Ngay_Sinh"].ToString()).Date;
                    patient.DOB = d.ToString("d");
                    patient.HomeNumber = tablePatient.Rows[i]["So_Nha"].ToString();
                    patient.StreetName = tablePatient.Rows[i]["Ten_Duong"].ToString();
                    patient.District = tablePatient.Rows[i]["Quan_Huyen"].ToString();
                    patient.City = tablePatient.Rows[i]["Tinh_TP"].ToString();
                    patient.History = tablePatient.Rows[i]["Tieu_Su_Benh"].ToString();
                    patient.HistoryFamily = tablePatient.Rows[i]["Tieu_Su_Benh_GD"].ToString();
                    patient.Allergy = tablePatient.Rows[i]["Di_Ung_Thuoc"].ToString();
                    ListPatient.Add(patient);
                }
                lookUpPatientPage.ListViewPatient.ItemsSource = ListPatient;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void loadPatient(BenhNhanPage benhNhanPage)
        {
            try
            {
                string sql;
                sql = "select * from DBA_CSYT.\"Benh_Nhan\"";
                var bn = Utils.GetDataToTable(sql);
                DataRow bn_row = bn.Rows[0];
                benhNhanPage.maBnTBox.Text = bn_row["Ma_Benh_Nhan"].ToString();
                benhNhanPage.tenBnTBox.Text = bn_row["Ten_Benh_Nhan"].ToString();
                benhNhanPage.cmndTBox.Text = bn_row["CMND"].ToString();
                benhNhanPage.birthTBox.Text = Convert.ToDateTime(bn_row["Ngay_Sinh"]).Date.ToString("dd/MM/yyyy");
                benhNhanPage.soNhaTBox.Text = bn_row["So_Nha"].ToString();
                benhNhanPage.tenDuongTBox.Text = bn_row["Ten_Duong"].ToString();
                benhNhanPage.quanHuyenTBox.Text = bn_row["Quan_Huyen"].ToString();
                benhNhanPage.tinhtpTBox.Text = bn_row["Tinh_TP"].ToString();
                benhNhanPage.csytTBox.Text = bn_row["Ma_CSYT"].ToString();
                benhNhanPage.tiensSuBenhTBox.Text = bn_row["Tieu_Su_Benh"].ToString();
                benhNhanPage.diUngThuocTBox.Text = bn_row["Tieu_Su_Benh_GD"].ToString();
                benhNhanPage.tienSuBenhGdTBox.Text = bn_row["Di_Ung_Thuoc"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }


}
