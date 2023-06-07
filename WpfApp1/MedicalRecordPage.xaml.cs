﻿using System;
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
    /// Interaction logic for MedicalRecordPage.xaml
    /// </summary>
    public partial class MedicalRecordPage : Page
    {
        public MedicalRecordPage()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string keyword = keywordTextbox.Text;
            Utils.LoadMedicalRecordPage(Doctor.medicalReportPage, keyword);
        }

        private void SeeDetail_Click(object sender, RoutedEventArgs e)
        {
            string medicalRecordId = (sender as Button).Tag.ToString();
            MedicalRecordResultWindow medicalRecordResultScreen = new MedicalRecordResultWindow(medicalRecordId);
            medicalRecordResultScreen.Show();
        }
    }
}
