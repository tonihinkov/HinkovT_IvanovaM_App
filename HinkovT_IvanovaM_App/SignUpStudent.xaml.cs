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
    public partial class SignUpStudent : Window
    {
        public SignUpStudent()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=(localdb)\LABSCIFIPC04\LOCALHOST; Initial Catalog=project_Semester1; Integrated Security=True");

            try
            {


                //opening the connection to the db 

                sqlCon.Open();

                //Build our actual query 

                string query = "INSERT INTO Register_Student(Student_Firstname,Student_LastName,Student_Email,Student_Username,Student_Password,Student_Phone,Aadhar)values ('" + this.txtFirst_name.Text + "','" + this.txtSecond_name.Text + "','" + this.txtEmail.Text + "','" + this.txtUsername.Text + "','" + this.PasswordBox.Password + "') ";

                //Establish a sql command

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully saved");

                LogInMain signupstudysubmit = new LogInMain();
                signupstudysubmit.Show();
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
        //LogInMain signupstudysubmit = new LogInMain();
        //signupstudysubmit.Show();
        //this.Close();
    }
    }
}
