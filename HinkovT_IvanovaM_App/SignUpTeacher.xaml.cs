using System;
using System.Collections.Generic;
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

namespace HinkovT_IvanovaM_App
{
    /// <summary>
    /// Interaction logic for SignUpTeacher.xaml
    /// </summary>
    public partial class SignUpTeacher : Window
    {
        public SignUpTeacher()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {

            SqlConnection sqlCon = new SqlConnection(@"Data Source=LABSCIFIPC04\LOCALHOST; Initial Catalog=project_Semester1; Integrated Security=True");

            try
            {


                //opening the connection to the db 

                sqlCon.Open();

                //Build our actual query 

                string query = "INSERT INTO Register_Instructor(Instructor_ID,Instructor_Username,Instructor_Password,Instructor_FirstName,Instructor_LastName,Instructor_Email)values ('" + this.txtID.Text + "','" + this.txtUsername.Text + "','" + this.txtPassword.Password + "','" + this.txtFirst_name.Text + "','" + this.txtSecond_name.Text + "','" + this.txtEmail.Text + "') ";

                //Establish a sql command

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully saved");

                Info signupteachsubmit = new Info();
                signupteachsubmit.Show();
                this.Close();

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);

            }

            finally

            {

                sqlCon.Close();

            }
        }

    }
}
