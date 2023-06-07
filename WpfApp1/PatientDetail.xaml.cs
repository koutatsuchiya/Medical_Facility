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
    /// Interaction logic for PatientDetail.xaml
    /// </summary>
    public partial class PatientDetail : Window
    {
        public PatientDetail(string patientId)
        {
            InitializeComponent();
            string sql = "select * from DBA_CSYT.\"Benh_Nhan\" where \"Ma_Benh_Nhan\"  = " + patientId;
            DataTable patient = Utils.GetDataToTable(sql);
            IdTextBox.Text = patient.Rows[0]["Ma_Benh_Nhan"].ToString();
            NameTextBox.Text = patient.Rows[0]["Ten_Benh_Nhan"].ToString();
            IdCardTextBox.Text = patient.Rows[0]["CMND"].ToString();
            HospitalBox.Text = patient.Rows[0]["Ma_CSYT"].ToString();
            DateTime d = DateTime.Parse(patient.Rows[0]["Ngay_Sinh"].ToString()).Date;
            DOB.Text = d.ToString("d");
            HistoryTextBox.Text = patient.Rows[0]["Tieu_Su_Benh"].ToString();
            HistoryFamilyTextBox.Text = patient.Rows[0]["Tieu_Su_Benh_GD"].ToString();
            string homeNumber = patient.Rows[0]["So_Nha"].ToString();
            string district = patient.Rows[0]["Quan_Huyen"].ToString();
            string city = patient.Rows[0]["Tinh_TP"].ToString();
            string address = homeNumber + " " + district + " " + city;
            AddressTextBox.Text = address;
            AllergyTextBox.Text = patient.Rows[0]["Di_Ung_Thuoc"].ToString();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
