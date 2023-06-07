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
    /// Interaction logic for AddUser.xaml
    /// </summary>
    public partial class AddUser : Window
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddPatientButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            var addPatientScreen = new AddPatient();
            addPatientScreen.Show();
        }

        private void AddEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            var addEmployeeScreen = new AddEmployee();
            addEmployeeScreen.Show();
        }
    }
}
