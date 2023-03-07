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
            int courseID = Convert.ToInt32(txtCourseID.Text);
            string connectionString = @"Data Source=LABSCIFIPC04\LOCALHOST; Initial Catalog=project_Semester1; Integrated Security=True";
            //int courseID = Convert.ToInt32(txtCourseID.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Course WHERE Course_ID = '"+Convert.ToInt32( this.txtCourseID.Text ) +"'";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@courseID", courseID);

                CourseInfo ci = new CourseInfo();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    courseID = reader.GetInt32(reader.GetOrdinal("Course_ID"));
                    string courseField = reader.GetString(reader.GetOrdinal("Field"));
                    //int teacher = reader.GetInt32(reader.GetOrdinal("Instructor_ID"));
                    //int numberOfStuds = reader.GetInt32(reader.GetOrdinal("Number_Of_Students"));

                    CourseInfo courseInfoWindow = new CourseInfo(courseID.ToString(), courseField/*, teacher, numberOfStuds*/);
                    courseInfoWindow.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Course not found.");
                }

            }
        }

        private void GoBack1_Click(object sender, RoutedEventArgs e)
        {
            Info goback1 = new Info();
            goback1.Show();
            this.Close();
        }
    }
}
