using System;
using System.ComponentModel;
using System.Data;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Doctor.xaml
    /// </summary>
    public partial class Doctor : Window
    {
        public static DoctorProfilePage doctorProfilePage = new DoctorProfilePage();
        public static MedicalRecordPage medicalReportPage = new MedicalRecordPage();
        public static LookUpPatientPage lookUpPatientPage = new LookUpPatientPage();
        public Doctor()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Utils.LoadDoctorProfile(doctorProfilePage);
            Main.Content = doctorProfilePage;
        }

        private void ProfileButton_Click(object sender, RoutedEventArgs e)
        {

            Utils.LoadDoctorProfile(doctorProfilePage);
            Main.Content = doctorProfilePage;
        }
   
        private void ViewMedicalRecordButton_Click(object sender, RoutedEventArgs e)
        {
            Utils.LoadMedicalRecordPage(medicalReportPage);
            Main.Content = medicalReportPage;
        }

        private void LookUpPatientButton_Click(object sender, RoutedEventArgs e)
        {
            Utils.LoadLookUpPatientPage(lookUpPatientPage);
            Main.Content = lookUpPatientPage;
        }
        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
