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
    /// Interaction logic for UpdateQuestions.xaml
    /// </summary>
    public partial class UpdateQuestions : Window
    {
        public UpdateQuestions()
        {
            InitializeComponent();
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

        private void btnCancelUpdate_Click(object sender, RoutedEventArgs e)
        {
            EditQuestions nomodal = new EditQuestions();
            nomodal.Show();
            Close();
        }

        private void btnSaveUpdate_Click(object sender, RoutedEventArgs e)
        {
            // Create the connexion to our database calling info from app.config
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connexion"].ConnectionString);
            conn.Open();

            // Create the SqlCommand = connexion
            using (SqlCommand command = conn.CreateCommand())
            {
                // Validate information
                if (
                    txtQuestion.Text != "" &&
                    txtAnswerOne.Text != "" &&
                    txtAnswerTwo.Text != "" &&
                    txtAnswerThree.Text != "" &&
                    txtAnswerFour.Text != ""
                    )
                {

                    // Create update with all the parameters based in the Number of Survey
                    command.CommandText = "Update RegisterSurvey set Question=@Question,Answer_One=@Answer_One,Answer_Two=@Answer_Two,Answer_Three=@Answer_Three,Answer_Four=@Answer_Four where Survey='" + txtSurvey.Text + "'";

                    // Assign to the variables (Update), the new/updated information 
                    command.Parameters.AddWithValue("@Question", txtQuestion.Text);
                    command.Parameters.AddWithValue("@Answer_One", txtAnswerOne.Text);
                    command.Parameters.AddWithValue("@Answer_Two", txtAnswerTwo.Text);
                    command.Parameters.AddWithValue("@Answer_Three", txtAnswerThree.Text);
                    command.Parameters.AddWithValue("@Answer_Four", txtAnswerFour.Text);

                    // Validate the updated information with ExecuteNonQuery (return the # of afected lines)
                    int status = command.ExecuteNonQuery();

                    // If the afected lines > 0 change will be notified
                    if (status > 0)

                    {
                        txtStatusUpdate.Text = "Information was successfuly updated";
                    }
                    else
                    {
                        txtStatusUpdate.Text = "Something goes wrong";
                    }
                }
                else
                {
                    txtStatusUpdate.Text = "Please fill in the blank spaces";
                }
                MainWindow nomodal = new MainWindow();
                nomodal.Show();
                Close();
            }
        }
    }
}
