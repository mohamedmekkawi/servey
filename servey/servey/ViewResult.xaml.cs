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

namespace servey
{
    /// <summary>
    /// Interaction logic for ViewResult.xaml
    /// </summary>
    public partial class ViewResult : Window
    {
        public ViewResult()
        {
            InitializeComponent();
        }

        private void btViewsSurveyResult_Click(object sender, RoutedEventArgs e)
        {
            Window8 windo = new Window8();
            windo.Show();
            this.Close();
        }
    }
}
