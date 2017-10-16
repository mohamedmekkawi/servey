using System;
using System.Collections.Generic;
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

namespace servey
{
    /// <summary>
    /// Interaction logic for AddNewSurvey.xaml
    /// </summary>
    public partial class AddNewSurvey : Window
    {
        public AddNewSurvey()
        {
            InitializeComponent();
        }


        private void btSubmitSurvey_Click(object sender, RoutedEventArgs e)
        {
            string Titel = tbAddTitel.Text;
           
            try
            {
                Survey s = new Survey { Titel = Titel };
                db.AddSurvey(s);
                ReloadPersonList();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Input error: " + ex.Message);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }

        }
    }
    }
}
