using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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

namespace Survey
{
    /// <summary>
    /// Interaction logic for DeleteSurvey.xaml
    /// </summary>
    public partial class DeleteSurvey : Window
    {
        public DeleteSurvey()
        {
            InitializeComponent();
        }

        private void btnCancelDeleteSurvey_Click(object sender, RoutedEventArgs e)
        {
            MainWindow nomodal = new MainWindow();
            nomodal.Show();
            Close();
        }

        private void btnDeleteSurvey_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSearchSurvey_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
