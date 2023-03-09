using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
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
    /// Interaction logic for LogInMain.xaml
    /// </summary>
    public partial class LogInMain : Window
    {
        public LogInMain()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=LABSCIFIPC04\LOCALHOST; Initial Catalog=project_Semester1; Integrated Security=True");

            try
            {

                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                string query = "SELECT COUNT(1) FROM LogInTest Where ID=@ID and username=@username and pass=@pass";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@ID", txtID.Text);
                sqlCmd.Parameters.AddWithValue("@username", txtUsername.Text);
                sqlCmd.Parameters.AddWithValue("@pass", txtPassword.Password);

                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 1)
                {
                    Info loginsubmit = new Info();
                    loginsubmit.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username or password are not correct!");
                }


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
