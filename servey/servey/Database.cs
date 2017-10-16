using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace servey
{
    class Database
    {
        private string CONN_STRING = @"Server=tcp:sstorage.database.windows.net,1433;Initial Catalog=survey;Persist Security Info=False;User ID={sqladmin};Password={Project1};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private SqlConnection conn;

        public Database()
        {
            conn = new SqlConnection();
            conn.ConnectionString = connString;
            conn.Open();
        }

        public int AddSurvey(Survey s)
        {
            SqlCommand insertCommand = new SqlCommand("INSERT INTO Survey (Titel) VALUES (@Titel); SELECT SCOPE_IDENTITY();", conn);
            insertCommand.Parameters.Add(new SqlParameter("Titel", s.Titel));
         
            //insertCommand.ExecuteNonQuery();
            int id = (int)insertCommand.ExecuteScalar(); // return ID of the record just created
            return id;
        }


        //Database db;

        //public MainWindow()
        //{
        //    InitializeComponent();
        //    db = new Database();
        //    List<Survey> surveyList = db.GetAllSurveys();
        //    lsSurveys.Clear();
        //    foreach (Survey s as surveyList)
        //    {
        //        lvSurveys.Add(s);
        //    }
        //}

    }
}