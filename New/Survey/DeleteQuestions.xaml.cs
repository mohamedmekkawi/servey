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
    /// Interaction logic for DeleteQuestions.xaml
    /// </summary>
    public partial class DeleteQuestions : Window
    {
        public DeleteQuestions()
        {
            InitializeComponent();
        }

        private void btnCancelDelete_Click(object sender, RoutedEventArgs e)
        {
            EditQuestions nomodal = new EditQuestions();
            nomodal.Show();
            Close();
        }

        private void btnDeleteQuestion_Click(object sender, RoutedEventArgs e)
        {
            // Create the connexion to our database calling info from app.config
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connexion"].ConnectionString);
            conn.Open();

            // Create the SqlCommand = connexion
            using (SqlCommand command = conn.CreateCommand())
            {
                // Declare command to delete in the server
                command.CommandText = "delete RegisterSurvey where Survey = '" + txtSurvey.Text + "'";

                // Command.ExecuteNonQuery() ? = gave us the number of afected lines 
                int status = command.ExecuteNonQuery();

                // If > 0, the user has been registered
                if (status > 0)
                {
                    txtStatusDelete.Text = "Survey has been Deleted";
                }
                else
                {
                    txtStatusDelete.Text = "Something is wrong";
                }
                conn.Close();
                MainWindow nomodal = new MainWindow();
                nomodal.Show();
                Close();

            }
        }

        private void btnSearchSurvey_Click_1(object sender, RoutedEventArgs e)
        {
            // Create the connexion to our database calling info from app.config
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connexion"].ConnectionString);
            conn.Open();

            // Create the SqlCommand = connexion
            using (SqlCommand command = conn.CreateCommand())
            {
                SqlCommand cms = new SqlCommand("Select* from RegisterSurvey where Survey='" + txtSurvey.Text + "'", conn);
                // Create dataReader to search in the database the Number of Survey
                SqlDataReader dr = cms.ExecuteReader();
                // once we have the information, we assign to the text fields
                while (dr.Read())
                {
                    txtQuestion.Text = dr["Question"].ToString();
                    txtAnswerOne.Text = dr["Answer_One"].ToString();
                    txtAnswerTwo.Text = dr["Answer_Two"].ToString();
                    txtAnswerThree.Text = dr["Answer_Three"].ToString();
                    txtAnswerFour.Text = dr["Answer_Four"].ToString();
                }

                // Close datareader
                dr.Close();

                // Close connexion
                conn.Close();
            }
        }
    }
}
