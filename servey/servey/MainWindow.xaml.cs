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

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btViewResult_Click(object sender, RoutedEventArgs e)
        {
            ViewResult windo = new ViewResult();
            windo.Show();
            this.Close();
        }

  

        private void btAddNewSurvey_Click(object sender, RoutedEventArgs e)
        {
            AddNewSurvey windo = new AddNewSurvey();
            windo.Show();
            this.Close();
        }

        private void btEditSurvey_Click(object sender, RoutedEventArgs e)
        {
            Edit windo = new Edit();
            windo.Show();
            this.Close();
        }

        private void bttakeSurvey_Click(object sender, RoutedEventArgs e)
        {
            TakeSurvey windo = new TakeSurvey();
            windo.Show();
            this.Close();
        }
    }
}
