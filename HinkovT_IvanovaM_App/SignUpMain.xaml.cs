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
    /// Interaction logic for SignUpMain.xaml
    /// </summary>
    public partial class SignUpMain : Window
    {
        public SignUpMain()
        {
            InitializeComponent();
        }

        private void SignUpTeach_Click(object sender, RoutedEventArgs e)
        {
            SignUpTeacher signupteach = new SignUpTeacher();
            signupteach.Show();
            this.Close();
        }

        private void SignUpStudy_Click(object sender, RoutedEventArgs e)
        {
            SignUpStudent signupstudy = new SignUpStudent();
            signupstudy.Show();
            this.Close();
        }
    }
}
