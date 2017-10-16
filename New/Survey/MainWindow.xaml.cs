using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Survey
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connexion"].ConnectionString);
            //conn.Open();
            //conn.Close();
        }

        private void btnAddSurvey_Click(object sender, RoutedEventArgs e)
        {
            AddSurvey nomodal = new AddSurvey();
            nomodal.Show();
            
        }

        private void btnEditSurvey_Click(object sender, RoutedEventArgs e)
        {
            AddSurvey nomodal = new AddSurvey();
            nomodal.Show();
            Close();
        }

        private void btnEditQuestions_Click(object sender, RoutedEventArgs e)
        {
            EditQuestions nomodal = new EditQuestions();
            nomodal.Show();
            Close();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAnalizeResults_Click(object sender, RoutedEventArgs e)
        {
            // Create the connexion to our database calling info from app.config
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connexion"].ConnectionString);

            // Create the SqlAdapter = retrieve information
            SqlDataAdapter ada = new SqlDataAdapter("Select * from RegisterSurvey", conn);

            // Create Dataset
            DataSet ds = new DataSet();

            // Open connexion
            conn.Open();

            // Add/Update Rows in the dataset
            ada.Fill(ds, "RegisterSurvey");

            // Close connection
            conn.Close();

            // Load the information to our datagrid = dataview
            dgSurveys.ItemsSource = new DataView(ds.Tables["RegisterSurvey"]);
        }
    }
}