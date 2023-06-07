using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for MedicalRecordResultWindow.xaml
    /// </summary>
    public partial class MedicalRecordResultWindow : Window
    {
        public MedicalRecordResultWindow(string medicalRecordId)
        {
            InitializeComponent();
            BindingList<MedicalRecordResult> ListMedicalRecordResult = new BindingList<MedicalRecordResult>();
            try
            {
                string sql;
                sql = "SELECT * FROM DBA_CSYT.HSBA_DV where \"Ma_HSBA\" = " + medicalRecordId;
                var tableMedicalRecordResult = Utils.GetDataToTable(sql);
                ListMedicalRecordResult.Clear();
                for (int i = 0; i < tableMedicalRecordResult.Rows.Count; i++)
                {
                    MedicalRecordResult medicalRecordResult = new MedicalRecordResult();
                    medicalRecordResult.MedicalRecordId = tableMedicalRecordResult.Rows[i]["Ma_HSBA"].ToString();
                    DateTime d = DateTime.Parse(tableMedicalRecordResult.Rows[i]["Ngay"].ToString()).Date;
                    medicalRecordResult.DateChecked = d.ToString("d");
                    medicalRecordResult.Result = tableMedicalRecordResult.Rows[i]["Ket_Qua"].ToString();
                    ListMedicalRecordResult.Add(medicalRecordResult);
                }
                ListViewMedicalRecordResult.ItemsSource = ListMedicalRecordResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
