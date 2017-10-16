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
    /// Interaction logic for EditQuestions.xaml
    /// </summary>
    public partial class EditQuestions : Window
    {
        public EditQuestions()
        {
            InitializeComponent();
        }

        private void btnAddQuestion_Click(object sender, RoutedEventArgs e)
        {
            AddQuestions nomodal = new AddQuestions();
            nomodal.Show();
            Close();
        }

        private void btnEditQuestion_Click(object sender, RoutedEventArgs e)
        {
            UpdateQuestions nomodal = new UpdateQuestions();
            nomodal.Show();
            Close();



        }

        //// Apply BlurEffect
        //public void ApplyEffect(Window win)
        //{
        //    var effect = new System.Windows.Media.Effects.BlurEffect();
        //    win.Effect = effect;
        //}

        //// Remove BlurEffect
        //public void RemoveEffect(Window win)
        //{
        //    win.Effect = null;
        //}

        private void btnDeleteQuestion_Click(object sender, RoutedEventArgs e)
        {
            DeleteQuestions nomodal = new DeleteQuestions();
            nomodal.Show();
            Close();
        }
    }
}
