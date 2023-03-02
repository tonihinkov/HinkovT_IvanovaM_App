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

namespace HinkovT_IvanovaM_App
{
    /// <summary>
    /// Interaction logic for Course.xaml
    /// </summary>
    public partial class Course : Window
    {
        public Course()
        {
            InitializeComponent();
        }

        private void SubmitCourse_Click(object sender, RoutedEventArgs e)
        {
            CourseInfo submitcourse = new CourseInfo();
            submitcourse.Show();
            this.Close();
        }

        private void GoBack1_Click(object sender, RoutedEventArgs e)
        {
            Info goback1 = new Info();
            goback1.Show();
            this.Close();
        }
    }
}
