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
    /// Interaction logic for CSYTPage.xaml
    /// </summary>
    public partial class CSYTPage : Page
    {
        public CSYTPage()
        {
            InitializeComponent();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string keyword = keywordTextbox.Text;
            Utils.LoadCSYTPage(MainWindow.csytPage, keyword);
        }

        private void AddCSYTButton_Click(object sender, RoutedEventArgs e)
        {
            var addCSYTScreen = new AddCSYT();
            addCSYTScreen.Show();
        }
    }
}
