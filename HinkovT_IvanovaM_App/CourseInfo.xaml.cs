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
    /// Interaction logic for CourseInfo.xaml
    /// </summary>
    public partial class CourseInfo : Window
    {
        public CourseInfo()
        {
            InitializeComponent();
        }

        private void GoBack2_Click(object sender, RoutedEventArgs e)
        {
            Info goback2 = new Info();
            goback2.Show();
            this.Close();
        }
    }
}
