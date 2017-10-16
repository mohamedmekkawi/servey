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
    /// Interaction logic for AddQuestions.xaml
    /// </summary>
    public partial class AddQuestions : Window
    {
        public AddQuestions()
        {
            InitializeComponent();
        }

        private void btnCancelQuestion_Click(object sender, RoutedEventArgs e)
        {
            EditQuestions nomodal = new EditQuestions();
            nomodal.Show();
            Close();



        }

        private void btnSaveQuestion_Click(object sender, RoutedEventArgs e)
        {
            if (
                // Validate information
                txtQuestion.Text != "" &&
                txtAnswerOne.Text != "" &&
                txtAnswerTwo.Text != "" &&
                txtAnswerThree.Text != "" &&
                txtAnswerFour.Text != ""                 
                )
            {
            // Create the connexion to our database calling info from app.config
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connexion"].ConnectionString);

            // Create the SqlCommand = connexion
            using (SqlCommand command = conn.CreateCommand())
            {
                // Generate insert = Sql Server
                command.CommandText = "insert into RegisterSurvey(Question, Answer_One, Answer_Two, Answer_Three, Answer_Four) values (@Question, @Answer_One, @Answer_Two, @Answer_Three, @Answer_Four)";

                // Asign insert variables (values of the survey) 
                //command.Parameters.AddWithValue("@number", int.Parse(txtQuestionNumber.Text));
                command.Parameters.AddWithValue("@Question", txtQuestion.Text);
                command.Parameters.AddWithValue("@Answer_One", txtAnswerOne.Text);
                command.Parameters.AddWithValue("@Answer_Two", txtAnswerTwo.Text);
                command.Parameters.AddWithValue("@Answer_Three", txtAnswerThree.Text);
                command.Parameters.AddWithValue("@Answer_Four", txtAnswerFour.Text);

                // Open the connexion
                conn.Open();

                // Command.ExecuteNonQuery() ? = gave us the number of afected lines
                int status = command.ExecuteNonQuery();

                // If > 0, the user has been registered
                if (status > 0)
                {
                    txtStatus.Text = "Survey has been register";
                }
                else
                {
                    txtStatus.Text = "Something is wrong";
                }
            }

            // Close connexion 
            conn.Close();
        }
            else
            {
                // If the user is missing any information
                txtStatus.Text = "Please insert all information to continue";
            }
}


    }
}


