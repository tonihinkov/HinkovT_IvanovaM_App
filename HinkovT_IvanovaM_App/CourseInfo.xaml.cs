using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
using System.Xml.Linq;

namespace HinkovT_IvanovaM_App
{
    /// <summary>
    /// Interaction logic for CourseInfo.xaml
    /// </summary>
    public partial class CourseInfo : Window
    {
        public CourseInfo()
        {

        }
        public CourseInfo(string courseID, string courseField, int teacher, int numberOfStuds)
        {
            InitializeComponent();

            DataContext = new CourseInfoViewModel(courseID, courseField, teacher, numberOfStuds);
        }

        private void GoBack2_Click(object sender, RoutedEventArgs e)
        {
            

            Info goback2 = new Info();
            goback2.Show();
            this.Close();
        }
    }

    public class CourseInfoViewModel
    {
        public string CourseID { get; set; }
        public string CourseField { get; set; }
        public string Teacher { get; set; }
        public string NumberOfStuds { get; set; }

        public CourseInfoViewModel(string courseID, string courseField, int teacher, int numberOfStuds)
        {
            CourseID = courseID;
            CourseField = courseField;
        }

    }
}
