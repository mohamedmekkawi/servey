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

namespace servey
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public object NavigationService { get; private set; }

        Database db;

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

        private void btViewResult_Click(object sender, RoutedEventArgs e)
        {
            ViewResult windo = new ViewResult();
            windo.ShowDialog();
            // this.Close();
        }

  

        private void btAddNewSurvey_Click(object sender, RoutedEventArgs e)
        {
            AddNewSurvey windo = new AddNewSurvey();
            windo.ShowDialog();
            // this.Close();
        }

        private void btEditSurvey_Click(object sender, RoutedEventArgs e)
        {
            Edit windo = new Edit();
            windo.ShowDialog();
            // this.Close();
        }

        private void bttakeSurvey_Click(object sender, RoutedEventArgs e)
        {
            TakeSurvey windo = new TakeSurvey();
            windo.ShowDialog();
            // this.Close();
        }

        private void lvSurveys_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<Surveys> list = db.GetAllSurveys();
            lvSurveys.Items.Clear();
            foreach (Survey S in list)
            {
                lvSurveys.Items.Add(S);
            }
        }
    }
}
