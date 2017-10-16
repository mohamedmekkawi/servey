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

namespace Survey
{
    /// <summary>
    /// Interaction logic for AddSurvey.xaml
    /// </summary>
    public partial class AddSurvey : Window
    {
        public AddSurvey()
        {
            InitializeComponent();
        }

        private void btnCancelAddSurvey_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow nomodal = new MainWindow();
            nomodal.Show();
            Close();
        }
    }
}


