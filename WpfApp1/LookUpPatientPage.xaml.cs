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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for LookUpPatientPage.xaml
    /// </summary>
    public partial class LookUpPatientPage : Page
    {
        public LookUpPatientPage()
        {
            InitializeComponent();
            
        }

        private void SeeDetail_Click(object sender, RoutedEventArgs e)
        {
            string patientId = (sender as Button).Tag.ToString();
            PatientDetail patientDetailScreen = new PatientDetail(patientId);
            patientDetailScreen.Show();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            Utils.LoadLookUpPatientPage(Doctor.lookUpPatientPage, keyword.Text);
        }
    }
}
